using System;

class Program
{
    static void Main()
    {
        string J = "ab", S = "aabbccd";

        int Output = 0;

        foreach (char c in S)
        {
            for (int i = 0; i < J.Length; i++)
            {
                if (c == J[i])
                {
                    Output++;
                    break;
                }
            }
        }

        Console.WriteLine(Output);
    }
}