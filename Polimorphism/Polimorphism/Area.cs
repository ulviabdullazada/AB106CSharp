﻿using Polimorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Area : IAdd, IMultiply
    {
        public float Add(float num1, float num2)
        {
            throw new NotImplementedException();
        }

        public float Multiply(float num1, float num2)
        {
            throw new NotImplementedException();
        }
    }
}
