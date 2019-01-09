using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {

        int temp = 0;
        bool sorted = true;
        int swaps = 0;

        for(int i = 0; i < q.Length; i++)
        {
            if (q[i] -1 -i > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
        }

        for (int i = 0; i < q.Length; i++)
        {
            sorted = true;
            for (int j = 0; j < q.Length - 1; j++)
            {
                if (q[j] > q[j + 1])
                {
                    temp = q[j + 1];
                    q[j + 1] = q[j];
                    q[j] = temp;
                    sorted = false;
                    swaps++;
                }
            }
            if (sorted) { break; /*early escape*/ }
        }
        Console.WriteLine(swaps);
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
