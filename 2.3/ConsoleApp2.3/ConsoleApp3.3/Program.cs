using System;
class Calculation
{
    private string CalculationLine;
    public void SetCalculationLine(string line)
    {
        CalculationLine = line;
    }
    public void AddSymbolToCalculationLine(char symbol)
    {
        CalculationLine += symbol;
    }
    public string GetCalculationLine()
    {
        return CalculationLine;
    }
    public char GetLastSymbol()
    {
        return CalculationLine[CalculationLine.Length - 1];
    }
    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(CalculationLine))
        {
            CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        calc.SetCalculationLine("2 / 2 / 2 ");
        calc.AddSymbolToCalculationLine('=');
        
        Console.WriteLine("Изначальная строчка:  " + calc.GetCalculationLine());
        Console.WriteLine($"Последний символ: < {calc.GetLastSymbol()} >");
        
        calc.DeleteLastSymbol();
        
        Console.WriteLine("Удаление последнего символа » " + calc.GetCalculationLine());
    }
}