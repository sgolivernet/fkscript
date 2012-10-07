using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FKVM;

namespace FKVMTest
{
    class ApiTest
    {
        private FKVMVirtualMachine vm = null;

        public ApiTest(FKVMVirtualMachine vm)
        {
            this.vm = vm;
        }

        public void imprimirMensaje()
        {
            string msg = vm.obtenerParametroString();

            Console.WriteLine(msg);
        }
    }
}
