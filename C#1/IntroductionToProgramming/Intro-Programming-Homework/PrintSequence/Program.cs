﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
             int x = -1;
             int y = -1;
             for (int i = 0; i < 10; i++)
             {
                 if (x > 0)
                 {
                     x = (x + 1) * y;

                 }
                 else
                 {
                     x = (x - 1) * y;

                 }
                 Console.WriteLine(x);

             }             
        }
    }
}