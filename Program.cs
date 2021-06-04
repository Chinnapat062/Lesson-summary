using System;

namespace สรุปบทเรียน
{
    class Program
    {
        static void Main()
        {

            float tax, income;
            Console.Write("Enter Income of person : ");
            income = float.Parse(Console.ReadLine());


            //คำนวณค่าภาษีเงินได้
            if (income <= 150000.00f)
            {
                tax = 0.00f;
                Console.WriteLine("Your tax is :{0}", tax);
            }
                
            else if (income <= 300000.00f)
            {
                tax = (income - 150000.00f) * 5 / 100;
                Console.WriteLine("Your tax is :{0}", tax);
            }

            else if (income <= 500000.00f)
            {
                tax = (income - 300000.00f) * 10 / 100 + 7500;
                Console.WriteLine("Your tax is :{0}", tax);
            }
                 
            else if (income <= 750000.00f)
            {
                tax = (income - 500000.00f) * 15 / 100 + 27500;
                Console.WriteLine("Your tax is :{0}", tax);
            }
                     
            else if (income <= 1000000.00f)
            {
                tax = (income - 750000.00f) * 20 / 100 + 65000;
                Console.WriteLine("Your tax is :{0}", tax);
            }
                
            else if (income <= 2000000.00f)
            {
                tax = (income - 1000000.00f) * 25 / 100 + 115000;
                Console.WriteLine("Your tax is :{0}", tax);
            }
                
            else if (income <= 5000000.00f)
            {
                tax = (income - 2000000.00f) * 30 / 100 + 365000;
                Console.WriteLine("Your tax is :{0}", tax);
            }
               
            else if (income > 5000000.00f)
            {
                tax = (income - 5000000.00F) * 35 / 100 + 1265000;
                Console.WriteLine("Your tax is :{0}", tax);
            }
                
            

        }
    }
}
