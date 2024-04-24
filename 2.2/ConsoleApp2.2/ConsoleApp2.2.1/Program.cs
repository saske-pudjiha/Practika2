using System;

class Student
{
    public string Name { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public string GroupNumber { get; set; }
    
    public int[] Grades { get; set; }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public void ChangeDateOfBirth(DateTime newDateOfBirth)
    {
        DateOfBirth = newDateOfBirth;
    }

    public void ChangeGroupNumber(string newGroupNumber)
    {
        GroupNumber = newGroupNumber;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Информация студента: ");
        Console.WriteLine("Имя - " + Name);
        Console.WriteLine("День рождения: " + DateOfBirth.ToShortTimeString());
        Console.WriteLine("Группа: " + GroupNumber);
        Console.Write("Успеваемость: ");
        foreach (var grade in Grades)
        {
            Console.Write(grade + " ");
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student()
        {
            DateOfBirth = new DateTime(2005, 12, 20),
            GroupNumber = "A",
            Grades = new int[] {5, 4, 3, 2, 5}
        };
        
        student.PrintInfo();

        Console.WriteLine("Напишите новое имя:");
        string newName = Console.ReadLine();
        student.ChangeName(newName);
        
        Console.WriteLine("Напишите новую дату рожжения в формате: yyyy.mm.dd):");
        DateTime newDateOfBirth = DateTime.Parse(Console.ReadLine());
        student.ChangeDateOfBirth(newDateOfBirth);
        
        Console.WriteLine("Напишите новую группу:");
        string newGroupNumber = Console.ReadLine();
        student.ChangeGroupNumber(newGroupNumber);
        
        Console.WriteLine("Обновленная информация: ");
        student.PrintInfo();
    }
}