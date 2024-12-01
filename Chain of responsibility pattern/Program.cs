using Chain_of_responsibility_pattern;

class Program
{
    static void Main(string[] args)
    {
        var handlerA = new Event_AHandler();
        var handlerB = new Event_BHandler();
        var handlerC = new Event_CHandler();

        handlerA.SetNext(handlerB);
        handlerB.SetNext(handlerC);

        var requestA = new EventRequest("A", "Произошло событие A");
        var requestB = new EventRequest("B", "Произошло событие B");
        var requestC = new EventRequest("C", "Произошло событие C");
        var requestD = new EventRequest("D", "Произошло событие D");

        handlerA.HandleRequest(requestA);
        handlerA.HandleRequest(requestB);
        handlerA.HandleRequest(requestC);
        handlerA.HandleRequest(requestD);
    }
}