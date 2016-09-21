using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonExample
    {
        //private constructor 
        private SingletonExample() { }

        private static SingletonExample _instance;

        public static SingletonExample Instance {
            get {
                if (_instance == null)
                {
                    _instance = new SingletonExample();
                }
                return _instance;
            }
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
