using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int result;

            int a = 10;
            int b = 0;

            Calculator calculator = new Calculator();

            try {
               
                System.Console.WriteLine($"{a} / {b} = {calculator.divide(a, b)}");
            } catch(DivideByZeroException e) {
                
                System.Console.WriteLine("Error: división entre 0");
            }


            try
            {
                Bus bus = new Bus();

                bus.SetDriverName("Gabriel Herrera");
                bus.SetRoute("R");
                bus.BeginRoute();

                System.Console.WriteLine("Bus is ok");
                // System.Console.WriteLine("Bus execution complete.");
            }
            catch (ArgumentException e)
            {
                System.Console.WriteLine("Invalid Bus params");
                System.Console.WriteLine(e.Message);

                // System.Console.WriteLine("Bus execution complete.");
            } catch (InvalidOperationException e) {
                System.Console.WriteLine("Invalid Bus state");
                System.Console.WriteLine(e.Message);

                // System.Console.WriteLine("Bus execution complete.");
            } finally {
                System.Console.WriteLine("Bus execution complete.");
            }



        }
    }
}
