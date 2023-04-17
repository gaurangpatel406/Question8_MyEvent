using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8_MyEvent
{
    public class EventDel
    {
        public event MyEventHandler MyEvent;

        public void RaiseEvent(string message)
        {
            Console.WriteLine("EventSource is raising an event.");
            OnMyEvent(args: new global::EventDel(message));
        }

        protected virtual void OnMyEvent(global::EventDel args)
        {
            MyEvent?.Invoke(this, args);
        }
    }

}
