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
        firstObserver.ReactionToWork();
        secondObserver.Subscribe(provider);
        secondObserver.ReactionToWork();
        firstObserver.Unsubscribe();
        secondObserver.Unsubscribe();
        provider.EndOfWork();
    }
}