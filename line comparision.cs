using System;

namespace line_comparison
{
    class program
    {
        static void Main(String[] agrs)
        {


            
            Example length1 = new Example(5, 5, 5, 5);
            length1.calculatelength();
            Example length22 = new Example(2, 2, 2, 2);
            length22.calculatelength();

            if (length1 ==(length22)) 
            {
                Console.WriteLine("two lengths r equal");

            }
            else if (length1 >> (length22)) 
            {
                Console.WriteLine("length 1 is greater");
            }
            else
            {
                Console.WriteLine("length 22 is greater");

            }




        }
        }
}
