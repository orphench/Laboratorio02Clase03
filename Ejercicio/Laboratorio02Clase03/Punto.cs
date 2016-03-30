using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public int DevolverX()
        {
            return this.x;
            
        }

        public int DevolverY()
        {
            return this.y;
        }

    } 
}
