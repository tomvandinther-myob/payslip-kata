using System;

class Employee {
    string name;
    string surname;
    int annualSalary;
    double superRate;

    // In C#, we can use property with getter & setter so that we don't need to create Get & Set method. eg: we can try with SuperRate
    public double SuperRate {get; set;}
    
    // I think this constructor was created from the beginning but it's not in used now. Should it be removed?
    public Employee(string name, string surname) {
        this.name = name;
        this.surname = surname;
    }

    // I think this constructor was created from the beginning but it's not in used now. Should it be removed?
    public Employee(string name, string surname, int annualSalary) {
        this.name = name;
        this.surname = surname;
        this.annualSalary = annualSalary;
    }

    public Employee(string name, string surname, int annualSalary, double superRate) {
        this.name = name;
        this.surname = surname;
        this.annualSalary = annualSalary;
        this.superRate = superRate;
        SuperRate = superRate;
    }
    
    public string GetName()
    {
        return this.name;
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