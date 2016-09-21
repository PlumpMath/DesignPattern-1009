using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        //Observer pattern 
        //Let one or more objects be notified of state changes in other objects within system
        //Provides: broadcast capabilities; events trigger
        //subject(post office) + observer(mailbox)
        static void Main(string[] args)
        {
            ISubject postOffice= new PostOffice("45788, Brandeis Ter");

            IObserver mailBox_Zhang = new MailBox("212-1");
            IObserver mailBox_Wang = new MailBox("212-2");
            IObserver mailBox_Ma = new MailBox("212-3");

            postOffice.AddObserver(mailBox_Zhang);
            postOffice.AddObserver(mailBox_Wang);
            postOffice.AddObserver(mailBox_Ma);

            postOffice.NotifyObservers();

            Console.WriteLine("------------------");

            postOffice.RemoveObserver(mailBox_Zhang);

            postOffice.NotifyObservers();
              
            
        }
    }
}
