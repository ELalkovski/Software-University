using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.SetFirstName(firstName);
        this.SetLastName(lastName);
        this.SetAge(age);
        this.SetSalary(salary);
    }

    public string FirstName
    {
        get { return this.firstName; }
    }

    public string LastName
    {
        get { return this.lastName; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public double Salary
    {
        get { return this.salary; }
    }

    public void SetFirstName(string firstName)
    {
        if (firstName.Length < 3)
        {
            throw new ArgumentException("First name cannot be less than 3 symbols");

        }

        this.firstName = firstName;
    }
    public void SetLastName(string lastName)
    {
        if (lastName.Length < 3)
        {
            throw new ArgumentException("Last name cannot be less than 3 symbols");

        }

        this.lastName = lastName;
    }
    public void SetAge(int age)
    {
        if (age < 1)
        {
            throw new ArgumentException("Age cannot be zero or negative integer");

        }

        this.age = age;
    }
    public void SetSalary(double salary)
    {
        if (salary < 460.0)
        {
            throw new ArgumentException("Salary cannot be less than 460 leva");

        }

        this.salary = salary;
    }

    public void IncreaseSalary(double bonus)
    {
        this.salary += bonus;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary} leva";
    }
}

