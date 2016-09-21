using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonExample se = SingletonExample.Instance;
            //se.InstanceCheck();

            //SingletonExample se1 = SingletonExample.Instance;
            //se1.InstanceCheck();
            //se.InstanceCheck();

            SingletonThreadSafe stf = SingletonThreadSafe.Instance;
            stf.InstanceCheck();
            stf.InstanceCheck();

            SingletonThreadSafe stf1 = SingletonThreadSafe.Instance;
            stf1.InstanceCheck();
            stf.InstanceCheck();
        }
    }
}
