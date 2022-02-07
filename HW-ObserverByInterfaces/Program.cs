using HW_ObserverByInterfaces;
using System;
using System.Collections.Generic;
using static HW_ObserverByInterfaces.Observable;

public class Example
{
    public static void Main()
    {
        CanDoSomethind provider = new CanDoSomethind();
        Observer firstObserver = new Observer();
        Observer secondObserver = new Observer();

        firstObserver.Subscribe(provider);
        secondObserver.Subscribe(provider);
        secondObserver.Unsubscribe();
        provider.EndOfWork();
    }
}