﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    /// <summary>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new _10_模板方法模式();
            s.Main();

            Console.ReadLine();
        }
    }
    class A
    {
        public virtual void Amethod()
        {
            Console.Write("A");
        }
    }

    class B:A
    {
        public override void Amethod()
        {
            Console.Write("A->B");
        }  
        public void Bmethod()
        {
            Console.Write("B");
        }
    }

}
