using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenstrukturenSingleLinkedList
{
   public interface IObserver
    {
        void Update(ISubject subject);
    }
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Dettach(IObserver observer);
        void Notify();
    }
   
}
