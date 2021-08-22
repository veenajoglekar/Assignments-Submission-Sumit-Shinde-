using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandling eh = new ExceptionHandling();
            eh.divide(4, 0);
            eh.arrException();
            eh.stringConvert();
            MultipleCatch multicatch = new MultipleCatch();
            multicatch.divide(4, 0);
        }


        public class ExceptionHandling
        {
            int result;

            public void divide(int a, int b)
            {
                try
                {
                    result = a / b;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }

            public void arrException()
            {
                try
                {
                    int[] arr = { 1 };
                    arr[1] = 100;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
            }

            public void stringConvert()
            {
                try
                {
                    string str = "alsdn";
                    int a = int.Parse(str);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
            }
        }
    }
}

