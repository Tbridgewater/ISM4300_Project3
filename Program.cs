using System;

namespace ISM4300_Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal conversion = 0.621371m;
           //Ask user to enter number
            Console.WriteLine("Please enter a number between 10 and 25");
            try
            {
                //Collect user input for increment and convert to integer
                string input = Console.ReadLine();
                int KM = int.Parse(input);
                if ((KM > 10) && (KM < 25)) ;
                {
                    for (int i = 0; KM<=200  ; KM+=5)
                    {
                        Console.WriteLine("KM: "+ KM + " , "+ "Miles: "+ (KM * conversion));
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a number between 10 and 25");
            }



        }
    }
}
