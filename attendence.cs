namespace practice1
{
    class Program
    {using System;


       public static void Main(string[] args)
        {
            Random random = new Random();
            int  empCHeck = random.Next(0, 2);
            Console.WriteLine("enter random number");

            if (empCHeck == 0)
                Console.WriteLine("employee present");
            else
                Console.WriteLine("employee absent");


        }
      
        }

}
