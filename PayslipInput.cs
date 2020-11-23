using System;
using System.Globalization;

namespace payslip_kata
{
    public class PayslipInput
    {
        private readonly CultureInfo culture = new CultureInfo("en-US");
        
        public string PromptName()
        {
            Console.Write("Please input your name: ");
            var input = Console.ReadLine();
            return input;
        }

        public string PromptSurname()
        {
            Console.Write("Please input your surname: ");
            var input = Console.ReadLine();
            return input;
        }

        public int PromptSalary()
        {
            Console.Write("Please enter your annual salary: ");
            var input = Console.ReadLine();
            return Convert.ToInt32(input);
        }

        public double PromptSuperRate()
        {
            Console.Write("Please enter your super rate: ");
            var input = Console.ReadLine();
            return Convert.ToDouble(input) / 100;
        }

        public DateTime PromptStartDate()
        {
            Console.Write("Please enter your payment start date: ");
            var input = Console.ReadLine();
            // if (!Boolean.Parse(input)) return DateTime.Today; //TODO: How best to deal with no input here?
            return DateTime.ParseExact(input, "d MMMM", culture);
        }
        
        public DateTime PromptEndDate()
        {
            Console.Write("Please enter your payment end date: ");
            var input = Console.ReadLine();
            // if (!Boolean.Parse(input)) return DateTime.Today.AddDays(1);
            return DateTime.ParseExact(input, "d MMMM", culture);
        }
    }
}