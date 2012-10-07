using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FKVM;

namespace FKVMTest
{
    class Program
    {
        private static FKVMVirtualMachine vm = new FKVMVirtualMachine();

        static void Main(string[] args)
        {
            InicializarApi();

            //Generamos el código intermedio
            Console.WriteLine("Compilando...");
            FKVMCompiler comp = new FKVMCompiler();
            comp.compilarFichero("codigo.fks", "entrada.fka");

            //Si la compilación ha ido bien ensamblamos y ejecutamos
            if (comp.compilacionOK)
            {
                //Ensamblamos
                Console.WriteLine("Ensamblando...");
                FKVMAssembler ens = new FKVMAssembler();
                ens.ensamblar("entrada.fka", "salida.fk");

                //Ejecutamos
                Console.WriteLine("Ejecutando...");

                vm.cargarPrograma("salida.fk");
                vm.ejecutar();

                Console.WriteLine("Resultado: " + vm.retInt);
            }

            Console.Read();
        }

        private static void InicializarApi()
        {
            ApiTest api = new ApiTest(vm);

            vm.registrarFuncionApi("imprimirMensaje", api.imprimirMensaje);
        }
    }
}
