using System;

public abstract class Employee
{
    public string Name { get; set; }
    
    public abstract decimal CalculateSalary();
}

public class HourlyEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }


    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

public class MonthlyEmployee : Employee
{
    public decimal MonthlySalary { get; set; }

   
    public override decimal CalculateSalary()
    {
        return MonthlySalary;
    }
}

public class ContractEmployee : Employee
{
    public decimal ContractAmount { get; set; }

    
    public override decimal CalculateSalary()
    {
        return ContractAmount;
    }
}

public class Program
{
    public static void Main()
    {
        
        Employee[] employees = new Employee[]
        {
            new HourlyEmployee { Name = "Саша",  HourlyRate = 15, HoursWorked = 160 },
            new MonthlyEmployee { Name = "Дима",  MonthlySalary = 0 },
            new ContractEmployee { Name = "КАтя", ContractAmount = 50000000 }
        };

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} зарабатывает {employee.CalculateSalary()} тенге.");
        }
    }
}

