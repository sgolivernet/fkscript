using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr.StringTemplate;

namespace FKVM
{
    public class FKVMVirtualMachine
    {
        #region Estructuras de Datos

        //Pila
        private Pila pila = null;

        //Heap
        private List<string> heap = null;

        //Código
        private List<float> codigo = null;

        //Registros
        private int pc = 0;  //Puntero de código
        
        //Cabecera
        private Cabecera cab = new Cabecera();

        //Valores de retorno
        public int retInt = 0;
        public float retFloat = 0F;
        public bool retBool = false;
        public string retString = "";

        #endregion

        #region Constantes

        //Instrucciones
        public const int IPUSH = 1; //Coloca una constante entera en la pila
        public const int FPUSH = 2; //Coloca una constante real en la pila
        public const int SPUSH = 3; //Coloca una constante cadena en la pila
        public const int BPUSH = 4; //Coloca una constante booleana en la pila
        public const int ILOAD = 5; //Carga el valor de una variable entera en la pila
        public const int FLOAD = 6; //Carga el valor de una variable real en la pila
        public const int SLOAD = 7; //Carga el valor de una variable cadena en la pila
        public const int BLOAD = 8; //Carga el valor de una variable booleana en la pila
        public const int ISTORE = 9; //Almacena en una variable entera el primer elemento de la pila
        public const int FSTORE = 10; //Almacena en una variable real el primer elemento de la pila
        public const int SSTORE = 11; //Almacena en una variable cadena el primer elemento de la pila
        public const int BSTORE = 12; //Almacena en una variable booleana el primer elemento de la pila
        public const int POP = 13; //Elimina el primer elemento de la pila
        public const int IADD = 14; //Suma de enteros
        public const int FADD = 15; //Suma de reales
        public const int ISUB = 16; //Resta de enteros
        public const int FSUB = 17; //Resta de reales
        public const int IMUL = 18; //Producto de enteros
        public const int FMUL = 19; //Producto de reales
        public const int IDIV = 20; //División de enteros
        public const int FDIV = 21; //División de reales
        public const int NNEG = 22; //Negación numérica
        public const int BNEG = 23; //NO lógico
        public const int NCMP = 24; //Comparación numérica
        public const int BCMP = 25; //Comparación booleana
        public const int GOTO = 26; //Salto incondicional
        public const int IFEQ = 27; //Salto si igual a 0
        public const int IFNE = 28; //Salto si distinto de 0
        public const int IFLT = 29; //Salto si menor que 0
        public const int IFGT = 30; //Salto si mayor que 0
        public const int IFGE = 31; //Salto si mayor o igual que 0
        public const int IFLE = 32; //Salto si menor o igual que 0
        public const int SCMP = 33; //Comparación de cadenas
        public const int SADD = 34; //Concatenación de cadenas
        public const int IRET = 35; //Retorno de entero
        public const int FRET = 36; //Retorno de real
        public const int SRET = 37; //Retorno de cadena
        public const int BRET = 38; //Retorno de booleano
        public const int CALLAPI = 39; //Llamada a función de la API del HOST

        #endregion

        #region Constructores

        public FKVMVirtualMachine()
        {
            //Inicialización de estructuras
            codigo = new List<float>();

            //Reseteo de funciones API
            registroApi = new Dictionary<string, ApiCall>();
        }

        #endregion

        #region Registro Llamadas API

        public delegate void ApiCall();
        private Dictionary<string, ApiCall> registroApi = null;

        public void registrarFuncionApi(string nombre, ApiCall ac)
        {
            registroApi.Add(nombre, ac);
        }

        public void deregistrarFuncionApi(string nombre)
        {
            registroApi.Remove(nombre);
        }

        #endregion

        #region Metodos Publicos Generales

        public void cargarPrograma(string path)
        {
            BinaryReader fent = new BinaryReader(
                                    new FileStream(path,
                                            FileMode.Open, FileAccess.Read));

            //Cabecera
            cab.magic = fent.ReadInt32();
            cab.version = fent.ReadInt32();
            cab.revision = fent.ReadInt32();
            cab.programName = fent.ReadString();
            cab.stackSize = fent.ReadInt32();
            cab.heapSize = fent.ReadInt32();
            cab.nLocals = fent.ReadInt32();
            cab.nConst = fent.ReadInt32();

            //Inicialización de estructuras
            pc = 0;
            codigo = new List<float>();
            pila = new Pila(cab.nLocals);
            heap = new List<string>(cab.heapSize);

            //Literales
            for (int i = 0; i < cab.nConst; i++)
            {
                heap.Add(fent.ReadString());
            }

            //Código
            while (fent.PeekChar() != -1)
            {
                codigo.Add(fent.ReadSingle());
            }

            fent.Close();
        }

        public void ejecutar()
        {
            //Inicialización de registros y estructuras
            inicializarEstado();

            //Bucle principal
            while (pc < codigo.Count)
            {
                ejecutarInstruccion();
            }
        }

        #endregion

        #region Metodos Privados

        private void inicializarEstado()
        {
            pc = 0;  //Contador de programa
            pila = new Pila(cab.nLocals);  //Pila
            heap.RemoveRange(cab.nConst, heap.Count - cab.nConst);  //Memoria dinámica

            //Valores de retorno
            retInt = 0;
            retFloat = 0F;
            retBool = false;
            retString = "";
        }

        private void ejecutarInstruccion()
        {
            int opcode = (int)codigo[pc++];

            switch (opcode)
            {
                case ILOAD:
                case FLOAD:
                case BLOAD:
                case SLOAD:
                    ejecutarLOAD();
                    break;
                case ISTORE:
                case FSTORE:
                case BSTORE:
                case SSTORE:
                    ejecutarSTORE();
                    break;
                case IPUSH:
                case FPUSH:
                case SPUSH:
                case BPUSH:
                    ejecutarPUSH();
                    break;
                case POP:
                    ejecutarPOP();
                    break;
                case IADD:
                case FADD:
                    ejecutarADD();
                    break;
                case ISUB:
                case FSUB:
                    ejecutarSUB();
                    break;
                case IMUL:
                case FMUL:
                    ejecutarMUL();
                    break;
                case IDIV:
                    ejecutarIDIV();
                    break;
                case FDIV:
                    ejecutarFDIV();
                    break;
                case NNEG:
                    ejecutarNNEG();
                    break;
                case BNEG:
                    ejecutarBNEG();
                    break;
                case NCMP:
                    ejecutarNCMP();
                    break;
                case BCMP:
                    ejecutarBCMP();
                    break;
                case GOTO:
                    ejecutarGOTO();
                    break;
                case IFEQ:
                    ejecutarIFEQ();
                    break;
                case IFNE:
                    ejecutarIFNE();
                    break;
                case IFGT:
                    ejecutarIFGT();
                    break;
                case IFGE:
                    ejecutarIFGE();
                    break;
                case IFLT:
                    ejecutarIFLT();
                    break;
                case IFLE:
                    ejecutarIFLE();
                    break;
                case IRET:
                    ejecutarIRET();
                    break;
                case FRET:
                    ejecutarFRET();
                    break;
                case BRET:
                    ejecutarBRET();
                    break;
                case SRET:
                    ejecutarSRET();
                    break;
                case CALLAPI:
                    ejecutarCALLAPI();
                    break;
            }
        }

        private void ejecutarCALLAPI()
        {
            string fun = heap[(int)codigo[pc++]];

            if (registroApi.ContainsKey(fun))
                registroApi[fun]();
        }

        private void ejecutarIRET()
        {
            retInt = (int)pila.pop();
        }

        private void ejecutarFRET()
        {
            retFloat = pila.pop();
        }

        private void ejecutarBRET()
        {
            retBool = (int)pila.pop() == 0F ? false : true;
        }

        private void ejecutarSRET()
        {
            retString = heap[(int)pila.pop()];
        }

        private void ejecutarSTORE()
        {
            int op1 = (int)codigo[pc++];
            pila[op1] = pila.pop();
        }

        private void ejecutarLOAD()
        {
            int op1 = (int)codigo[pc++];
            pila.Add(pila[op1]);
        }

        private void ejecutarPUSH()
        {
            float op1 = codigo[pc++];
            pila.Add(op1);
        }

        private void ejecutarPOP()
        {
            pila.pop();
        }

        private void ejecutarADD()
        {
            float op1, op2;

            op1 = pila.pop();
            op2 = pila.pop();
            pila.Add(op1 + op2);
        }

        private void ejecutarSUB()
        {
            float op1, op2;

            op1 = pila.pop();
            op2 = pila.pop();
            pila.Add(op2 - op1);
        }

        private void ejecutarMUL()
        {
            float op1, op2;

            op1 = pila.pop();
            op2 = pila.pop();
            pila.Add(op1 * op2);
        }

        private void ejecutarIDIV()
        {
            int op1, op2, res;

            op1 = (int)pila.pop();
            op2 = (int)pila.pop();
            res = op2 / op1;
            pila.Add(res);
        }

        private void ejecutarFDIV()
        {
            float op1, op2;

            op1 = pila.pop();
            op2 = pila.pop();
            pila.Add(op2 / op1);
        }

        private void ejecutarNNEG()
        {
            float op1;

            op1 = pila.pop();
            pila.Add(-op1);
        }

        private void ejecutarBNEG()
        {
            float op1;

            op1 = pila.pop();
            pila.Add(op1 == 1F ? 0F : 1F);
        }

        private void ejecutarNCMP()
        {
            //Si OP1 > OP2 --> -1
            //Si OP1 = OP2 -->  0
            //Si OP1 < OP2 --> +1

            float op1, op2, res = 0F;

            op1 = pila.pop();
            op2 = pila.pop();

            if (op1 > op2)
                res = -1.0F;
            else if (op1 < op2)
                res = +1.0F;

            pila.Add(res);
        }

        private void ejecutarBCMP()
        {
            //Si OP1 == OP2 -->  0
            //Si OP1 != OP2 -->  1

            float op1, op2, res = 0F;

            op1 = pila.pop();
            op2 = pila.pop();

            if (op1 != op2)
                res = 1.0F;

            pila.Add(res);
        }

        private void ejecutarGOTO()
        {
            pc = (int)codigo[pc];
        }

        private void ejecutarIFEQ()
        {
            float op1;

            op1 = pila.pop();

            if (op1 == 0F)
                pc = (int)codigo[pc];
            else
                pc++;
        }

        private void ejecutarIFNE()
        {
            float op1;

            op1 = pila.pop();

            if (op1 != 0F)
                pc = (int)codigo[pc];
            else
                pc++;
        }

        private void ejecutarIFLT()
        {
            float op1;

            op1 = pila.pop();

            if (op1 < 0F)
                pc = (int)codigo[pc];
            else
                pc++;
        }

        private void ejecutarIFLE()
        {
            float op1;

            op1 = pila.pop();

            if (op1 <= 0F)
                pc = (int)codigo[pc];
            else
                pc++;
        }

        private void ejecutarIFGT()
        {
            float op1;

            op1 = pila.pop();

            if (op1 > 0F)
                pc = (int)codigo[pc];
            else
                pc++;
        }

        private void ejecutarIFGE()
        {
            float op1;

            op1 = pila.pop();

            if (op1 >= 0F)
                pc = (int)codigo[pc];
            else
                pc++;
        }

        #endregion

        #region Metodos Publicos API

        public int obtenerParametroInt()
        {
            return (int)pila.pop();
        }

        public float obtenerParametroFloat()
        {
            return pila.pop();
        }

        public bool obtenerParametroBool()
        {
            return pila.pop() == 0F ? false : true;
        }

        public string obtenerParametroString()
        {
            return heap[(int)pila.pop()];
        }

        public void devolverRetornoInt(int ret)
        {
            pila.push((float)ret);
        }

        public void devolverRetornoFloat(float ret)
        {
            pila.push(ret);
        }

        public void devolverRetornoInt(bool ret)
        {
            pila.push(ret == true ? 1F : 0F);
        }

        public void devolverRetornoString(string ret)
        {
            heap.Add(ret);

            pila.push((float)heap.Count-1);
        }

        #endregion
    }
}
