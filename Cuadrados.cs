﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVirtual
{
    internal class Cuadrados
    {
        private int b;

        private int h;

        public Cuadrados(int b, int h)
        {
            this.b = b;
            this.h = h;
        }

        public int Area()
        {
            return b * h;
        }
    }
}
