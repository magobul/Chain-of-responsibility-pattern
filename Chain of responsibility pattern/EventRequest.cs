using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern
{
    public class EventRequest
    {
        public string EventType { get; set; }
        public string Content { get; set; }

        public EventRequest(string eventType, string content)
        {
            EventType = eventType;
            Content = content;
        }
    }
}
