using HW_ObserverByEvents;
using System;
using System.Collections.Generic;
using System.Threading;

namespace HWObserver
{
    public class Program
    {
    static void Main(string[] args)
        {
            var subject = new Observable("Объект 1");

            var firstObserver = new Observer("Наблюдатель 1", subject);
            var secondObserver = new Observer("Наблюдатель 2", subject);

            subject.Work();

            Console.ReadLine();
        }
    } 
}


