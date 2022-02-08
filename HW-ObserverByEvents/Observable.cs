using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ObserverByEvents
{
    internal class Observable
    {

        private string _namOfSubject { get; set; }

        public event EventHandler OnSaved;

        public Observable(string name)
        {
            _namOfSubject = name;
        }

        public void Work()
        {
            Console.WriteLine("Субъект некую совершает значимую работу");
            OnSaved?.Invoke(this, EventArgs.Empty);
        }
    }
}
