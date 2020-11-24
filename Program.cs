using System;
using payslip_kata;

namespace payslip_taka
{
    class Program
    {
        static void Main(string[] args)
        {
            // If you want, you can have a function in PayslipInput class to return the employee with all the input, then call that function here only instead of call all the Prompt functions. So that the Main will look cleaner.
            Console.WriteLine("Welcome to the payslip generator!\n");
            var payslipInput = new PayslipInput();
            var name = payslipInput.PromptName();
            var surname = payslipInput.PromptSurname();
            var salary = payslipInput.PromptSalary();
            var superRate = payslipInput.PromptSuperRate();
            var startDate = payslipInput.PromptStartDate();
            var endDate = payslipInput.PromptEndDate();
            
            Employee employee = new Employee(name, surname, salary, superRate);
            // I like the idea of having the taxBrackets. As the rate might change every year, and with this way, we can easily change the csv file for each year.
            TaxBracket[] taxBrackets = new TaxBracketParser().ParseCSV("/Users/Tom.vanDinther/Documents/payslip-kata/tax_brackets.csv"); //TODO: Use absolute path in Rider. Issue: Cannot run.
            PayslipFactory payslipFactory = PayslipFactory.GetInstance(); 
            /* 
            Would it be easier if in PayslipFactory, we have a constructor, so that once we instantiate the payslipFactory, it constructs the taxBrackets, startDate, endDate. Something like: 
                PayslipFactory payslipFactory = new PayslipFactory(taxBrackets, startDate, endDate);
            */
            payslipFactory.SetTaxBrackets(taxBrackets);
            payslipFactory.SetStartDate(startDate);
            payslipFactory.SetEndDate(endDate);
            Payslip payslip = payslipFactory.GetPayslip(employee);
            
            // Same as input, I think output can be in separate class as well. So when we look at the main,  it shows a clear flow of the program. 
            Console.WriteLine("Your payslip has been generated:\n");
            PrintPayslip(payslip);
            Console.WriteLine("\nThank you for using MYOB!");
        }

        static void PrintPayslip(Payslip payslip)
        {
            Console.WriteLine($"Name: {payslip.name}");
            // Console.WriteLine($"Pay Period: {} - {}");
            Console.WriteLine($"Gross Income: {payslip.grossIncome}");
            Console.WriteLine($"Income Tax: {payslip.incomeTax}");
            Console.WriteLine($"Net Income: {payslip.netIncome}");
            Console.WriteLine($"Super: {payslip.superAmount}");
        }
    }
}
