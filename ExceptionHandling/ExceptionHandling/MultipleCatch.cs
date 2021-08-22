using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class MultipleCatch
    {

     
            int result;
            int[] arr = { };

            public void divide(int a, int b)
            {
                try
                {
                    result = a / b;
                    arr[5] = result;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Divide By Zero Exception caught: {0}", e);
                }
                catch (NullReferenceException e1)
                {
                    Console.WriteLine("Null Reference Exception caught: {0}", e1);
                }
                catch (IndexOutOfRangeException e2)
                {
                    Console.WriteLine("Index out of Range Exception caught: {0}", e2);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }

        }
    }
