using DatenstrukturenSingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenstrukturenSingleLinkedList
{
    public class Queues: ISubject
    {
        private SingleLinkedList internalList = new SingleLinkedList();
        private List<IObserver> _observer = new List<IObserver>();

        public Node Enqueue(int argValue)
        {
            var nodeToAdd = new Node(argValue);
            internalList.insert_AtTheEnd(argValue);
            Notify();
            return nodeToAdd;
        }

        public Node Dequeue()
        {
            var retval = internalList.GetFirst();
            internalList.DeleteFirst();
            Notify();
            return retval;
        }

        public override string ToString()
        {
            return internalList.ToString();
        }
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observer.Add(observer);
        }
        public void Dettach(IObserver observer)
        {
            this._observer.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observer)
            {
                observer.Update(this);
            }
        }
    }
}
