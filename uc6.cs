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
            const int num_of_working_days = 30;
            int emphrs = 0, empwage = 0, toyalempwage = 0;
            for(int day = 0; day< num_of_working_days-num_of_working_days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                if (empCheck == 0)
                {
                    empCheck = 8;
                    int total_salary = wage_per_hr * full_time * num_of_working_days;
                    Console.WriteLine("total_salary" + total_salary);
                }
                else
                {
                    empCheck = 4;
                    int total_salary = wage_per_hr * part_time * num_of_working_days;
                    Console.WriteLine("total_salary" + total_salary);
                }
            }
        }
    }
}

