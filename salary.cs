using System;

namespace salary
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int wage_per_hr = 30;
            const int full_time = 8;


            int total_salary = wage_per_hr * full_time;
            Console.WriteLine("total_salary" + total_salary);
        }        
    }
}
