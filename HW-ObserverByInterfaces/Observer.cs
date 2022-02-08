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
        private bool _valueOnNext;
        private IDisposable _subscriber;

        public void Subscribe(CanDoSomethind provider)
        {
            _subscriber = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _subscriber.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Вход в метод OnCompleted");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(bool value)
        {
            var canDo = value;
            Console.WriteLine("Некая значимая для подписчика работа выполнена");
            _valueOnNext = canDo;
        }
        public void ReactionToWork()
        {
            if (_valueOnNext == true)
            {
                Console.WriteLine("Подписчик реагирует по 1 сценарию");
            }
            else
            {
                Console.WriteLine("Подписчик реагирует по 2 сценарию");
            }    
        }

    }
}
