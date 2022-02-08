using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ObserverByInterfaces
{
    public class Observable
    {
        public class CanDoSomethind : IObservable<bool>
        {
            private bool canIDo;
            private List<IObserver<bool>> observers;
            public CanDoSomethind()
            {
                observers = new List<IObserver<bool>>();
                canIDo = false;
                Console.WriteLine("Некая значимая для подписчика работа выполнена");
            }

            internal void Rise()
            {
                foreach (var observer in observers)
                    observer.OnNext(canIDo);
                Console.WriteLine("Подписчики уведомлены, следуют действия от подписчиков");
            }

            public IDisposable Subscribe(IObserver<bool> observer)
            {
                if (!observers.Contains(observer))
                {
                    observers.Add(observer);
                    Console.WriteLine("Добавлен подписчик");
                }
                return new Unsubscriber(observers, observer);
            }
            public void EndOfWork()
            {
                foreach (var observer in observers)
                    observer.OnCompleted();

                observers.Clear();
                Console.WriteLine("Работа закончека, подписчики отписаны");
            }
        }

        public class Unsubscriber : IDisposable
        {
            private List<IObserver<bool>> _observers;
            private IObserver<bool> _observer;

            internal Unsubscriber(List<IObserver<bool>> observers, IObserver<bool> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                    _observers.Remove(_observer);
                Console.WriteLine("Подписчик удалён");
            }
        }
    }
}
