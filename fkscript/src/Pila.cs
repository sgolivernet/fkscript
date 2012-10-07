using System;
using System.Collections.Generic;
using System.Text;

namespace FKVM
{
    class Pila : List<float>
    {
        public Pila(int locals) : base()
        {
            for (int i = 0; i < locals; i++)
                push(0F);
        }

        public void push(float elem)
        {
            this.Add(elem);
        }

        public float pop()
        { 
            float elem = this[this.Count-1];

            this.RemoveAt(this.Count - 1);

            return elem;
        }
    }
}
