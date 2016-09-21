using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonThreadSafe
    {
        //private constructor 
        private SingletonThreadSafe() { }

        public static SingletonThreadSafe Instance {
            get {
                return Nested._instance;
            }
        }

        //lazy 
        private class Nested
        {
            //static constructor trigger laziness of type initializer
            //this type will be initialized only when it's referred 
            static Nested() { }

            internal static readonly SingletonThreadSafe _instance = new SingletonThreadSafe();
        }

        //class variable 
        private int x = 1;
        public void InstanceCheck()
        {
            x += 1;
            Console.WriteLine($"Current value of x : {x}");
        }
    }
}
