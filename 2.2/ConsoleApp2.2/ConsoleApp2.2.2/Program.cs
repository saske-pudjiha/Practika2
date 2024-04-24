using System;
class Train
{
    public int TrainNumber { get; set; }
    
    public string Destination { get; set; }
    
    public DateTime DepartureTime { get; set; }

    public void TrainInfo()
    {
        Console.WriteLine($"Номер поезда:      {TrainNumber}");
        Console.WriteLine($"Номер назначения:  {Destination}");
        Console.WriteLine($"Время направления: {DepartureTime}");
    }
}

class Program
{
    static void Main()
    {
        Train train = new Train
        {
            Destination = "Томск",
            TrainNumber = 12345,
            DepartureTime = new DateTime(2024, 4, 9, 8, 25, 0)
        };

        Console.WriteLine("Напишите номер поезда: ");
        int userTrainNumber = int.Parse(Console.ReadLine());

        if (userTrainNumber == train.TrainNumber)
        {
            train.TrainInfo();
        }
        else
        {
            Console.WriteLine("Такого поезда нету");
        }
    }
    
}