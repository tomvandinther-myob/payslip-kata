using System;

class Employee {
    // an example of changing these to auto-implemented properties
    // see https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
    // string name;
    public string Name { get; set; }
    string surname;
    int annualSalary;
    double superRate;

    public Employee(string name, string surname) {
        // 'this' keyword is redundant in C#
        Name = name;
        this.surname = surname;
    }

    public Employee(string name, string surname, int annualSalary) {
        Name = name;
        this.surname = surname;
        this.annualSalary = annualSalary;
    }

    public Employee(string name, string surname, int annualSalary, double superRate) {
        Name = name;
        this.surname = surname;
        this.annualSalary = annualSalary;
        this.superRate = superRate;
    }

    public string GetSurname()
    {
        return this.surname;
    }

    public int GetAnnualSalary()
    {
        return this.annualSalary;
    }
    public void SetAnnualSalary(int annualSalary)
    {
        this.annualSalary = annualSalary;
    }

    public double GetSuperRate()
    {
        return this.superRate;
    }

    public void SetSuperRate(int superRate)
    {
        this.superRate = superRate;
    }
}