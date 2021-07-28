using System;

namespace line_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("line comparison");
        }
            public class Example
        {
            public int x1, x2, y1, y2;
        
        public  Example(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public void calculatelength()
        {
            double result = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y2) ^ 2);
            Console.WriteLine(result);
        }
        }
    }
}
