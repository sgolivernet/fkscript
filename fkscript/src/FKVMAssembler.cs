using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace FKVM
{
    public class FKVMAssembler
    {
        #region Estructuras de datos

        //Instrucciones
        private Dictionary<string,Instruccion> instSet = null;

        //Fichero de entrada
        private StreamReader fe = null; 

        //Fichero de salida
        private BinaryWriter fsal = null;

        //Tabla de cadenas
        private List<string> cadenas = new List<string>();
        
        //Cabecera
        private Cabecera cab = new Cabecera();

        //Primera pasada
        private int progCounter = 0;
        private Dictionary<string, int> etiquetas = new Dictionary<string, int>();

        public bool ensambladoOK = false;

        #endregion

        #region Constructores

        public FKVMAssembler() {
            inicializarInstSet();
        }

        #endregion

        #region Metodos Publicos

        public void ensamblar(string pathEntrada, string pathSalida)
        {
            ensambladoOK = true;

            //Primera pasada
            generacionP1(pathEntrada);

            //Generar el Código
            if(ensambladoOK)
                generacionP2(pathEntrada, pathSalida);
        }

        #endregion

        #region Metodos Privados

        private void inicializarInstSet()
        {
            instSet = new Dictionary<string, Instruccion>();

            instSet.Add("ipush", new Instruccion("ipush", 1, 1));
            instSet.Add("fpush", new Instruccion("fpush", 2, 1));
            instSet.Add("spush", new Instruccion("spush", 3, 1));
            instSet.Add("bpush", new Instruccion("bpush", 4, 1));
            instSet.Add("iload", new Instruccion("iload", 5, 1));
            instSet.Add("fload", new Instruccion("fload", 6, 1));
            instSet.Add("sload", new Instruccion("sload", 7, 1));
            instSet.Add("bload", new Instruccion("bload", 8, 1));
            instSet.Add("istore", new Instruccion("istore", 9, 1));
            instSet.Add("fstore", new Instruccion("fstore", 10, 1));
            instSet.Add("sstore", new Instruccion("sstore", 11, 1));
            instSet.Add("bstore", new Instruccion("bstore", 12, 1));
            instSet.Add("pop", new Instruccion("pop", 13, 0));
            instSet.Add("iadd", new Instruccion("iadd", 14, 0));
            instSet.Add("fadd", new Instruccion("fadd", 15, 0));
            instSet.Add("isub", new Instruccion("isub", 16, 0));
            instSet.Add("fsub", new Instruccion("fsub", 17, 0));
            instSet.Add("imul", new Instruccion("imul", 18, 0));
            instSet.Add("fmul", new Instruccion("fmul", 19, 0));
            instSet.Add("idiv", new Instruccion("idiv", 20, 0));
            instSet.Add("fdiv", new Instruccion("fdiv", 21, 0));
            instSet.Add("nneg", new Instruccion("nneg", 22, 0));
            instSet.Add("bneg", new Instruccion("bneg", 23, 0));
            instSet.Add("ncmp", new Instruccion("ncmp", 24, 0));
            instSet.Add("bcmp", new Instruccion("bcmp", 25, 0));
            instSet.Add("goto", new Instruccion("goto", 26, 1));
            instSet.Add("ifeq", new Instruccion("ifeq", 27, 1));
            instSet.Add("ifne", new Instruccion("ifne", 28, 1));
            instSet.Add("iflt", new Instruccion("iflt", 29, 1));
            instSet.Add("ifgt", new Instruccion("ifgt", 30, 1));
            instSet.Add("ifge", new Instruccion("ifge", 31, 1));
            instSet.Add("ifle", new Instruccion("ifle", 32, 1));
            instSet.Add("scmp", new Instruccion("scmp", 33, 0));
            instSet.Add("sadd", new Instruccion("sadd", 34, 0));
            instSet.Add("iret", new Instruccion("iret", 35, 0));
            instSet.Add("fret", new Instruccion("fret", 36, 0));
            instSet.Add("sret", new Instruccion("sret", 37, 0));
            instSet.Add("bret", new Instruccion("bret", 38, 0));
            instSet.Add("callapi", new Instruccion("callapi", 39, 1));
        }

        private void generacionP1(string pathEntrada)
        { 
            string linea;

            //Se abre el fichero de entrada
            fe = File.OpenText(pathEntrada);

            linea = fe.ReadLine();

            //Se procesan todas las lineas que no sean
            //comentarios ni lineas en blanco
            while (linea != null)
            {
                if (linea != null)
                {
                    linea = linea.Trim();

                    if (!linea.StartsWith("#") && !linea.Equals(""))
                    {
                        procesarLineaP1(linea);
                    }
                }

                linea = fe.ReadLine();
            }

            fe.Close();
        }

        private void procesarLineaP1(string linea)
        {
            if (linea.Trim().EndsWith(":"))  //Etiqueta
            {
                procesarEtiquetaP1(linea);
            }
            else if (linea.Trim().StartsWith("."))  //Directiva
            {
                procesarDirectivaP1(linea);
            }
            else  //Instrucción
            {
                procesarInstruccionP1(linea);
            }
        }

        private void procesarDirectivaP1(string linea)
        {
            string[] tokens = linea.Split(new char[] { ' ' });

            if (tokens[0].StartsWith(".program"))
            {
                cab.programName = tokens[1];
            }
            else if (tokens[0].StartsWith(".stack"))
            {
                cab.stackSize = Convert.ToInt32(tokens[1]);
            }
            else if (tokens[0].StartsWith(".heap"))
            {
                cab.heapSize = Convert.ToInt32(tokens[1]);
            }
            else if (tokens[0].StartsWith(".locals"))
            {
                cab.nLocals = Convert.ToInt32(tokens[1]);
            }
        }

        private void procesarEtiquetaP1(string linea)
        {
            etiquetas.Add(linea.Substring(0, linea.Length - 1), progCounter);
        }

        private void procesarInstruccionP1(string linea)
        {
            string[] tokens = linea.Split(new char[] { ' ' });

            Instruccion inst = instSet[tokens[0]];

            //Si la instrucción existe
            if (inst != null)
            {
                //Si el número de parámetros de la instrucción es correcto
                if ((tokens.Length - 1) == inst.numpar)
                {
                    progCounter += inst.numpar + 1;

                    //Si es una instrucción SPUSH almacenamos la constante en la tabla de cadenas
                    if (tokens[0].Equals("spush"))
                    {
                        cadenas.Add(tokens[1].Substring(1, tokens[1].Length - 2));
                    }
                    else if (tokens[0].Equals("callapi"))
                        cadenas.Add(tokens[1]);
                }
                else
                {
                    Console.WriteLine("Número de parámetros incorrecto:");
                    Console.WriteLine(linea);
                    ensambladoOK = false;
                }
            }
            else
            {
                Console.WriteLine("Instrucción inexistente:");
                Console.WriteLine(linea);
                ensambladoOK = false;
            }
        }

        private void generacionP2(string pathEntrada, string pathSalida)
        {
            string linea;

            //Abrimos el fichero de entrada
            fe = File.OpenText(pathEntrada);

            //Abrimos el fichero de salida
            fsal = new BinaryWriter(new FileStream(pathSalida, FileMode.Create));

            //Generación de la Cabecera
            escribirCabecera();

            //Generación del Código
            linea = fe.ReadLine();

            while (linea != null)
            {
                if (linea != null)
                {
                    //Si no es un comentario o una linea en blanco se procesa
                    if (!linea.Trim().StartsWith("#") && !linea.Trim().Equals(""))
                    {
                        procesarLineaP2(linea);
                    }
                }

                linea = fe.ReadLine();
            }

            fe.Close();

            fsal.Flush();
            fsal.Close();
        }

        private void procesarLineaP2(string linea)
        {
            //Procesamos tan sólo la líneas que contengan instrucciones
            if(!linea.Trim().StartsWith(".") && !linea.Trim().EndsWith(":"))
            {
                procesarInstruccionP2(linea);
            }
        }

        private void procesarInstruccionP2(string linea)
        {
            string[] tokens = linea.Split(new char[] { ' ' });

            Instruccion inst = instSet[tokens[0]];

            fsal.Write((float)inst.opcode);

            if (inst.nombre.Equals("ipush") ||
               inst.nombre.Equals("iload") ||
               inst.nombre.Equals("istore") ||
               inst.nombre.Equals("bpush") ||
               inst.nombre.Equals("bload") ||
               inst.nombre.Equals("bstore") ||
               inst.nombre.Equals("sload") ||
               inst.nombre.Equals("sstore") ||
               inst.nombre.Equals("fpush") ||
               inst.nombre.Equals("fload") ||
               inst.nombre.Equals("fstore"))
            {
                fsal.Write(Convert.ToSingle(tokens[1]));

                //Debug.WriteLine(inst.nombre + " " + tokens[1]);
            }
            else if (inst.nombre.Equals("goto") ||
               inst.nombre.Equals("ifeq") ||
               inst.nombre.Equals("ifne") ||
               inst.nombre.Equals("ifgt") ||
               inst.nombre.Equals("ifge") ||
               inst.nombre.Equals("iflt") ||
               inst.nombre.Equals("ifle"))
            {
                fsal.Write((float)etiquetas[tokens[1]]);

                //Debug.WriteLine(inst.nombre + " " + tokens[1] + " " + etiquetas[tokens[1]]);
            }
            else if (inst.nombre.Equals("spush"))
            {
                fsal.Write((float)cadenas.IndexOf(tokens[1].Substring(1, tokens[1].Length - 2)));
            }
            else if(inst.nombre.Equals("callapi"))
            {
                fsal.Write((float)cadenas.IndexOf(tokens[1]));
            }
        }

        private void escribirCabecera()
        {
            //Cabecera
            fsal.Write(cab.magic);
            fsal.Write(cab.version);
            fsal.Write(cab.revision);
            fsal.Write(cab.programName);
            fsal.Write(cab.stackSize);
            fsal.Write(cab.heapSize);
            fsal.Write(cab.nLocals);
            fsal.Write(cadenas.Count);

            //Tabla de constantes
            foreach (string c in cadenas)
                fsal.Write(c);
        }

        #endregion
    }
}
