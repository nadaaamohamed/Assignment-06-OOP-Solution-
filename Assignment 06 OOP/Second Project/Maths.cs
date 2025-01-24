﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.Second_Project
{
    public static class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0) return 0;
                      
            return a / b;
        }
    }
}
