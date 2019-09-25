using System;
using System.Threading;


namespace MultiThreading1
{
    class Program
    {
        public void Display1()
        {
            Console.WriteLine("Display1 started");
            // Monitor.Enter(this);
          for(int i = 0;i<10;i++)
          {
             System.Console.WriteLine("Good Morning {0}",i+1);
             // Sleep method posses the thread for a Period of Time
            //  Thread.Sleep(1000);
             //  Thread.ResetAbort();
          }
          // Monitor.Exit(this);
           System.Console.WriteLine("Display1 Ended ");
        }
        public void Display2()
        {
            System.Console.WriteLine("Display2 started");
            // Monitor.Enter(this);
               for(int i = 0;i<10;i++)
               {
                  System.Console.WriteLine("Good Afternoon {0}",i+1 );
                //  Thread.Sleep(1000);
               }
              //  Monitor.Exit(this);
               System.Console.WriteLine("Display2 ended");
        }
        static void Main(string[] args)
        {
             /*This is the execution Path of a Program.Used to perfom multiple tasks
             at the same time. Single Thread Processes execute once.
             Multithreaded Processes create two or more threads
              How to access a Particular thread */
           /*  Thread th = Thread.CurrentThread;
                th.Name = "First Thread";
             System.Console.WriteLine(" Welcome " +th.Name);
             Program p = new Program();
             p.Display1();
             p.Display2(); */
             // Now to Run the two methods Parallely. We introduce The concept Of Thread. A Thread is A delegate which holds the reference of the method
                 Program p =  new Program();
             ThreadStart  ts1 = new ThreadStart(p.Display1);
             Thread th1 = new Thread(ts1);

               ThreadStart  ts2 = new ThreadStart(p.Display2);
             Thread th2 = new Thread(ts2);
             // Now to start the Thread. we use the start method
                th1.Start();
                th2.Start();
              //  Thread.Sleep(2000);
                th1.Priority =    ThreadPriority.Highest;             
                 th2.Priority = ThreadPriority.Lowest;
               // th1.Abort(); // Kills or Aborts the th1 thread. Thread goes to the dead state
                
                // it calls the th1 delegate automatically. Calls the method inside the delegate
                // The output shows two threads running Parallely

                
        }
    }
}
