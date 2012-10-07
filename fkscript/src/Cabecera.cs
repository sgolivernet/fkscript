using System;

namespace FKVM
{
	public class Cabecera
	{
		public int magic          = 8080;
        public int version        = 1;
        public int revision       = 0;
		public string programName = "";
		public int stackSize      = 1024;
		public int heapSize       = 1024;
		public int nConst         = 0;
        public int nLocals        = 0;
		
		public Cabecera()
		{
		}
	}
}
