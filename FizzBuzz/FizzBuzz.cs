using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {          

        }
        public void Calculation() 
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Podaj jakas liczbe calkowita");
                    var number = int.Parse(Console.ReadLine());
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        break;
                    }
                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine("Twoja liczba to:" + number.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }  
    }
}
