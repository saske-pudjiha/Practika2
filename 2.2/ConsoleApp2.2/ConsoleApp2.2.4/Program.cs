using System;
class reader
{
    public int count { get; set; }

    public reader()
    {
        count = 0;
    }

    public void decrement()
    {
        count--;
    }
    
    public void increment()
    {
        count++;
    }
}

class Program
{
    static void Main()
    {
        reader reader1 = new reader();

        Console.WriteLine("Начальное значение: " + reader1.count);
        reader1.increment();
        Console.WriteLine("Текущее состояние счетчика: " + reader1.count);
        reader1.decrement(); reader1.decrement();
        Console.WriteLine("Текущее состояние счетчика: " + reader1.count);
    }
}