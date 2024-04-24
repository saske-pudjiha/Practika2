using System;

class Program
{
    public static int[][] CombinationSum(int[] candidates, int target) 
    {
        Array.Sort(candidates);
        var result = new int[0][];

        FindCombinations(candidates, target, 0, new int[0], ref result);

        return result;
    }
    
    public static void FindCombinations(int[] candidates, int target, int start, int[] path, ref int[][] result)
    {
        if(target == 0)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = path;
            return;
        }
        
        for(int i = start; i < candidates.Length; i++)
        {
            if(i > start && candidates[i] == candidates[i-1]) 
            {
                continue;
            }
            
            if(target - candidates[i] >= 0)
            {
                int[] newPath = new int[path.Length + 1];
                Array.Copy(path, newPath, path.Length);
                newPath[path.Length] = candidates[i];
                FindCombinations(candidates, target - candidates[i], i + 1, newPath, ref result);
            }
        }
    }

    static void Main()
    {
        int[] candidates1 = {2, 5, 2, 1, 2};
        int target1 = 5;
        var result1 = CombinationSum(candidates1, target1);
        
        Console.WriteLine("[");
        foreach(var arr in result1)
        {
            Console.Write("[");
            foreach(var num in arr)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("]");
        }
        Console.WriteLine("]");

        int[] candidates2 = {10, 1, 2, 7, 6, 1, 5};
        int target2 = 8;
        var result2 = CombinationSum(candidates2, target2);
        
        Console.WriteLine("[");
        foreach(var arr in result2)
        {
            Console.Write("[");
            foreach(var num in arr)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("]");
        }
        Console.WriteLine("]");
    }
}