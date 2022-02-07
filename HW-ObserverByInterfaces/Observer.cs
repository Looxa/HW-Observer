using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_ObserverByInterfaces.Observable;

namespace HW_ObserverByInterfaces
{
    public class Observer : IObserver<bool>
    {
        private string name;
        private IDisposable cancellation;

        public void Subscribe(CanDoSomethind provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            cancellation.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Вход в метод OnCimpleted"); ;
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(bool value)
        {
            Console.WriteLine("Некая значимая для подписчика работа выполнена");
        }
    }
}
