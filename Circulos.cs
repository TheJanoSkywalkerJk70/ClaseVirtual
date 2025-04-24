using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVirtual
{
    internal class Circulos
    {
        private float r;

        public Circulos(float r)
        {
            this.r = r;
        }

        public float Area()
        {
            return 3.14f * r * r;
        }
    }
}
