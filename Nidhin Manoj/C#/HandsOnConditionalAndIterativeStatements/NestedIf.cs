﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalAndIterativeStatements
{
    internal class NestedIf
    {
        static void Main()
        {
           
         byte m1 = 89, m2 = 78, m3 = 56;

            if (m1 > m2)

            {

                if (m1 > m3)

                {

                    Console.WriteLine($"{m1} marks are highest");

                }

                else

                    Console.WriteLine($"{m3} marks are highest");


            }

            else

            {

                if (m2 > m3)

                {

                    Console.WriteLine($"{m2} marks are highest");

                }

                else

                    Console.WriteLine($"{m3} marks are highest");

            }
        }
    }
}
