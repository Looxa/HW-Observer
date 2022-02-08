using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ObserverByEvents
{
    internal class Observer
    {
        private string _nameOfSubscriber { get; set; }

        public Observer(string nameOfSubscriber, Observable subject)
        {
            _nameOfSubscriber = nameOfSubscriber;
            subject.OnSaved += ReactionToEvent;
        }


        private void ReactionToEvent(object sender, EventArgs e)
        {
            Console.WriteLine($"Наблюдатель '{this}' отреагировал на действие субъекта '{sender}'");
        }

    }
}
