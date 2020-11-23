using System;

class Employee {
    string name;
    string surname;
    int annualSalary;
    double superRate;

    public Employee(string name, string surname) {
        this.name = name;
        this.surname = surname;
    }

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