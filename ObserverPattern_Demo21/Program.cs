namespace ObserverPattern_Demo21
{


    public delegate void NotifyEventHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Observer Design pattern 
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();   


            //Coupling of event with event handler and 
            // coupling of event handler with methods

            publisher.Notify += new NotifyEventHandler(subscriber.A_Subscriber);
            publisher.Notify += new NotifyEventHandler(subscriber.B_Subscriber);



            //for some reason user B has unsubscribed from the event

            publisher.Notify -= new NotifyEventHandler(subscriber.B_Subscriber);


            //Raise the event : if alert recieved ..

            publisher.TriggerEvent();

            publisher.NotifySubscribers("High ALert!!");







        }
    }



















    public class Subscriber
    {
        public void A_Subscriber(string message)
        {
            Console.WriteLine($"A subscriber received: {message} message.");
        }
        public void B_Subscriber(string message)
        {
            Console.WriteLine($"B subscriber received: {message} message.");
        }





    }

    //Observable
    public class  Publisher
    {
        public event NotifyEventHandler Notify;



        //Wrapper method to invoke the event
        public void TriggerEvent()
        {
            Notify?.Invoke("Event triggered");
        }

        public void NotifySubscribers(string message)
        {
            Notify?.Invoke(message);
        }





    }








}
