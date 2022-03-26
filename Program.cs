
/*
 * --------------- Publisher subscriber Model------------------
 1. Publisher class:
       - event define
       - event fire
 2. subscriber class:
       - define what action to take if an event above occurs. and this eventHandler will handle it if an event is registered against it

 */


/*
 * 1.  ----------- EVENT HANDLING BASIC EXAMPLE
 * 
using System;
namespace Program
{
    delegate void MyEventHandler();
    class button
    {
        //define event
        public event MyEventHandler ButtonClick;
        //fire event
        public void Onclick()
        {
            if(ButtonClick != null)
                ButtonClick();
        }
    }
    class listener
    {
        public static void eventHandler()
        {
            Console.WriteLine("\nI'm fired");
        }
    }
    public class MyEvents
    {
        public static void Main(string[] args)
        {
            button btn= new button();
            btn.ButtonClick += listener.eventHandler;
            btn.Onclick();
        }
    }
}
*/