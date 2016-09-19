using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class PostOffice : ISubject
    {
        public List<IObserver> observers;
        public string Address { get; private set; }


        public PostOffice(string address) {
            Address = address;
            observers = new List<IObserver>();
        }
        
        public void AddObserver(IObserver obs)
        {
            if (observers.Contains(obs))
            {
                return;
            }
            else
            {
                observers.Add(obs);
            }
            
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void RemoveObserver(IObserver obs)
        {
            observers.Remove(obs);
        }
    }
}
