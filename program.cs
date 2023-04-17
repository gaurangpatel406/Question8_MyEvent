using System.Diagnostics.Tracing;

namespace Question8_MyEvent
{
    public class Program
    {
        static void Main(string[] args)       
        {
            EventSource eventSource = new global::EventDel();
            EventHandler eventHandler = new EventHandler();
            eventSource.MyEvent += eventHandler.HandleEvent;
            eventSource.RaiseEvent("Hello, world!");

            Console.WriteLine();
        }
    }
}