using System;

namespace Events
{
    // The class who raises events is called Publisher, and the class who receives the notification is called Subscriber.
    // There can be multiple subscribers of a single event. Typically, a publisher raises an event when some action occurred.
    // The subscribers, who are interested in getting a notification when an action occurred, should register with an event and handle it.

    // In C#, an event is an encapsulated delegate.
    // It is dependent on the delegate.
    // The delegate defines the signature for the event handler method of the subscriber class.

    public delegate void Notify();  // delegate

    public class One // Publisher class!
    {
        public int x = 1;
        public event Notify ProcessCompleted; // event

        public void CallEvent()
        {
            if (x == 1)
            {
                OnProcessCompleted();
            }
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            var myObject = new One();

            myObject.ProcessCompleted += Completed; // register with an event
            myObject.ProcessCompleted += SayHello;

            myObject.CallEvent();

            myObject.ProcessCompleted -= Completed;
            myObject.CallEvent();
        }

       
        public static void Completed()  // event handler
        {
            Console.WriteLine("Process Completed!");
        }

        public static void SayHello() // event handler
        {
            Console.WriteLine("Hello Word");
        }
    }
}
