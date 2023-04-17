using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8_MyEvent
{
    public class EventHandler
    {
        public void HandleEvent(object sender, global::EventDel args)
        {
            Console.WriteLine("EventHandler received a message: " + args.Message);
        }
    }
}
