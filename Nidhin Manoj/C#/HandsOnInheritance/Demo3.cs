﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class II
    {
        protected int a;
        protected int b;
        public II(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
        class JJ : II
        {
        public JJ() : base(34, 45)
        {

        }
        public JJ(int k,int l):base(k,l)
            {

            }
            public void f()
            {
                Console.WriteLine($"a={a} b={b}");
            }
        }
    

    internal class Demo3
    {
        static void Main()
        {
            JJ obj = new JJ();
            obj.f();
            JJ obj1 = new JJ(23,46);
            obj1.f();

        }
    }
}
