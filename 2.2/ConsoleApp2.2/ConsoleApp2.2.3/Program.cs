using System;

class Numbers
{
    public int Num1 { get; set; }
    
    public int Num2 { get; set; }

    public void Display()
    {
        Console.WriteLine("Число 1: " + Num1);
        Console.WriteLine("Число 2: " + Num2);
    }

    public int Sum()
    {
        return Num1 + Num2;
    }

    public int Comprasion()
    {
        return Math.Max(Num1, Num2);
    }
}

class Program
{
    static void Main()
    {
        Numbers numbers = new Numbers();
        numbers.Num1 = 1;
        numbers.Num2 = 5;
        
        numbers.Display();
        
        Console.WriteLine();
        Console.WriteLine("Сумма чисел: " + numbers.Sum());
        Console.WriteLine("Наибольшее число: " + numbers.Comprasion());
        
    }
}