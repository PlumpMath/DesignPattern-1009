using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class MailBox : IObserver
    {
        public string Address { get; set; }

        public MailBox(string address)
        {
            Address = address;
        }

        public void ChangeAddress(string address)
        {
            Address = address;
        }

        public void Update()
        {
            Console.WriteLine($"{this.Address} has new mail ...");
        }
    }
}
