using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern
{
    public abstract class EventHandler
    {
        protected EventHandler _nextHandler;

        public void SetNext(EventHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
        public abstract void HandleRequest(EventRequest request);
    }
}
