using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var array=new List<int>(); 
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            array.Add(pi);
        }
        array.Sort();
        var min=int.MaxValue;
        for (int i = 0; i < N-1; i++)
        {
            var t=array[i+1]-array[i];
            if(t<min)
            min=t;
        }
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(min);
    }
}
