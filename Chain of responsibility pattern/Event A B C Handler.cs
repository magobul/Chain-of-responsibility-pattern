using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern
{
    public class Event_AHandler:EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == "A")
            {
                Console.WriteLine($"Обработка события A: {request.Content}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
    public class Event_BHandler:EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == "B")
            {
                Console.WriteLine($"Обработка события B: {request.Content}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
    public class Event_CHandler : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == "C")
            {
                Console.WriteLine($"Обработка события C: {request.Content}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
