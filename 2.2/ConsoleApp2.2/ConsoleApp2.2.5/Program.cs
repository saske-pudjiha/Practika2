using System;

class MyClass
{
    public int Number  { get; set; }
    
    public string Text { get; set; }

    public MyClass(int number, string text)
    {
        Number = number;
        Text = text;
    }

    public MyClass()
    {
        Number = 0;
        Text = "Empty";
    }

    ~MyClass()
    {
        Console.WriteLine("Объект удален");
    }

    public void output()
    {
        Console.WriteLine($"Число: {Number}, Текст: {Text}");
    }
}

class Program
{
    static void Main()
    {
        MyClass object1 = new MyClass(10, "Hello");
        Console.WriteLine("Информация об объекте 1: ");
        object1.output();

        MyClass object2 = new MyClass();
        Console.WriteLine("Информация об объекте 2: ");
        object2.output();
    }
}