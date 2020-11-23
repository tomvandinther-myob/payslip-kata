using System;
using payslip_kata;

namespace payslip_taka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the payslip generator!\n");
            var payslipInput = new PayslipInput();
            var name = payslipInput.PromptName();
            var surname = payslipInput.PromptSurname();
            var salary = payslipInput.PromptSalary();
            var superRate = payslipInput.PromptSuperRate();
            var startDate = payslipInput.PromptStartDate();
            var endDate = payslipInput.PromptEndDate();
            
            Employee employee = new Employee(name, surname, salary, superRate);
            TaxBracket[] taxBrackets = new TaxBracketParser().ParseCSV("/Users/Tom.vanDinther/Documents/payslip-kata/tax_brackets.csv"); //TODO: Use absolute path in Rider. Issue: Cannot run.
            PayslipFactory payslipFactory = PayslipFactory.GetInstance();
            payslipFactory.SetTaxBrackets(taxBrackets);
            payslipFactory.SetStartDate(startDate);
            payslipFactory.SetEndDate(endDate);
            Payslip payslip = payslipFactory.GetPayslip(employee);

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
