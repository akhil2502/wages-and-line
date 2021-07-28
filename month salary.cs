using System;

namespace salary
{
    class Program
    {
        public static void Main(string[] args)
            
            
        {
            const int wage_per_hr = 30;
            const int full_time = 8;
            const int part_time = 4;
            const int month = 30;
            int salary;
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == 0)
                {
                    empCheck = 8;
                    int total_salary = wage_per_hr * full_time * month;
                    Console.WriteLine("total_salary" + total_salary);
                }
                else
                {
                    empCheck=4
                    int total_salary = wage_per_hr * part_time * month;
                    Console.WriteLine("total_salary" + total_salary);
                }
            }
        }
    }
}
