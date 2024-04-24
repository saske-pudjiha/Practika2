using System;

public class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }

    public double GetSalary()
    {
        return Rate * Days;
    }

    public static void Main()
    {
        Worker worker = new Worker()
        {
            Name = "Иван",
            Surname = "Диванов",
            Rate = 8.5,
            Days = 14
        };

        Console.WriteLine($"Работник: {worker.Name} {worker.Surname}, с ставкой за день {worker.Rate}," +
                          $" за {worker.Days} дней, получил {worker.GetSalary()}.");
    }
}