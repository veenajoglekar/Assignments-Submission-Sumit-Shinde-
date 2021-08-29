using System;
using System.Collections.Generic;
using System.Threading;

namespace Threading
{
    class ThreadMethods
    {
        static Thread t1, t2, t3;
        public static void TMethod1()
        {
            Console.WriteLine("Printing 1");
            for(int i =0; i<10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void TMethod2()
        {
            Console.WriteLine("Printing 2");
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void TMethod3()
        {
            Console.WriteLine("Printing 3");
        }

        public static void ThreadMethodCall()
        {
            ThreadStart ts1 = new ThreadStart(TMethod1);
            ThreadStart ts2 = new ThreadStart(TMethod2);
            ThreadStart ts3 = new ThreadStart(TMethod3);
            t1 = new Thread(ts1);
            t2 = new Thread(ts2);
            t3 = new Thread(ts3);

            // Equals
            Console.WriteLine(t1.Equals(t1));
            Console.WriteLine(t1.Equals(t2));

            //GetType  
            Console.WriteLine(t1.GetType());

            //Interrupt
            t1.Start();
            t2.Start();
            t1.Interrupt();
            Console.WriteLine("Interrupting");

            //Sleep / Start
            t3.Start();
            Console.WriteLine(Thread.CurrentThread);
            Thread.Sleep(5000);
        }
    }
}
