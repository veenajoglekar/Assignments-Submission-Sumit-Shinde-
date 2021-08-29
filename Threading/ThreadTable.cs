using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    public class ThreadTable
    {
        static Thread thread1, thread2, thread3;
        public static void TableOfTwo()
        {
            //if (thread2.ThreadState != ThreadState.Unstarted)
            //{
            //    thread2.Join(2000);
            //}

            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(2 * i);
            }
        }

        public static void TableOfFour()
        {
            if (thread2.ThreadState != ThreadState.Unstarted)
            {
                thread2.Join(2000);
            }
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(4 * i);
            }
        }

        public static void TableOfThree()
        {
            //if(thread3.ThreadState != ThreadState.Unstarted)
            //{
            //    thread3.Join(2000);
            //}
            if (thread1.ThreadState != ThreadState.Unstarted)
            {
                thread1.Join(2000);
            }
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(3 * i);
            }
        }
        public static void StartThread()
        {

            ThreadStart childref1 = new ThreadStart(TableOfTwo);
            thread1 = new Thread(childref1);
            thread1.Name = "Thread1";
            thread1.Start();

            ThreadStart childref2 = new ThreadStart(TableOfThree);
            thread2 = new Thread(childref2);
            thread2.Name = "Thread2";
            thread2.Start();

            ThreadStart childref3 = new ThreadStart(TableOfFour);
            thread3 = new Thread(childref3);
            thread3.Name = "Thread3";
            thread3.Start();
        }

    }
}
