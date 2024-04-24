using System;
public class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    public void SetSurname(string surname)
    {
        this.surname = surname;
    }
    public string GetSurname()
    {
        return surname;
    }
    public void SetRate(double rate)
    {
        this.rate = rate;
    }
    public double GetRate()
    {
        return rate;
    }
    public void SetDays(int days)
    {
        this.days = days;
    }
    public int GetDays()
    {
        return days;
    }
    public double GetSalary()
    {
        return rate * days;
    }
    
    public static void Main()
    {
        Worker worker = new Worker();

        worker.SetName("Иван");
        worker.SetSurname("Диванов");
        worker.SetRate(8.5);
        worker.SetDays(14);

        Console.WriteLine($"Работник: {worker.GetName()} {worker.GetSurname()}, с ставкой за день {worker.GetRate()}," +
                          $" за {worker.GetDays()} дней, получил {worker.GetSalary()}.");
        
    }
}