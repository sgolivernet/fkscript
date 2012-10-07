using System;
using System.Collections.Generic;
using System.Text;

namespace FKVM
{
    class Instruccion
    {
        public string nombre;   //Nombre de la instrucción
        public int opcode;      //Código de instrucción
        public int numpar;      //Número de parámetros

        public Instruccion(string nombre, int opcode, int numpar)
        {
            this.nombre = nombre;
            this.opcode = opcode;
            this.numpar = numpar;
        }
    }
}
