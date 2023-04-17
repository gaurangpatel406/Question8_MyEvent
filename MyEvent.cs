using NetMQ;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EventDel : EventArgs
{
    public string Message { get; set; }

    public EventDel(string passing Msg)
    {
        Message = Message;
    }

    public EventDel(string message)
    {
        Message = message;
    }

    public EventDel()
    {
    }

    public static implicit operator EventSource(EventDel v)
    {
        throw new NotImplementedException();
    }
}

public delegate void MyEventHandler(object sender, EventDel args);