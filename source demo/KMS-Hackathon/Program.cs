using System;
using System.Collections.Generic;

namespace KMS_Hackathon
{
    class Program
    {
        static string input;
        static int n, color, max;
        static int[,] a = new int[100, 100];
        static int[] colors = new int[100];

        static bool[] flags = new bool[100];
        static Stack<int> stack = new Stack<int>();
        static Dictionary<int, List<int>> colorPoints = new Dictionary<int, List<int>>();
        static void Main(string[] args)
        {
            ReadInput();
            StandardInput();
            DoQuestion1();
            DoQuestion2();
        }

        static void ReadInput()
        {
            Console.Write("Input string: ");
            input = Console.ReadLine();
        }

        static void StandardInput()
        {
            n = (int)Math.Sqrt(input.Length);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = int.Parse(input[n * i + j].ToString());
        }

        static void FillColor()
        {
            while (stack.Count > 0)
            {
                int point = stack.Pop();
                for (int i = 0; i < n; i++)
                    if (!flags[i] && (a[point, i] == 1 || a[i, point] == 1))
                    {
                        flags[i] = true;
                        colors[i] = color;
                        stack.Push(i);
                        colorPoints[color].Add(i);
                    }
            }
        }

        static void DoQuestion1()
        {
            color = 0;
            max = 0;
            for (int i = 0; i < n; i++)
                if (!flags[i])
                {
                    color++;
                    flags[i] = true;
                    colors[i] = color;
                    stack.Push(i);
                    colorPoints.Add(color, new List<int>());
                    colorPoints[color].Add(i);
                    FillColor();
                    if (colorPoints[color].Count > max) max = colorPoints[color].Count;
                }


        }

        static void ProcessHighest(List<int> points)
        {
            int max = 0;
            int index = points.Count / 2;

            foreach (var point in points)
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    count += a[point, i];
                }

                if (count > max)
                {
                    max = count;
                    index = point;
                }
            }

            Console.WriteLine("Result: " + index);
        }

        static void DoQuestion2()
        {
            foreach (var key in colorPoints.Keys)
                if (colorPoints[key].Count == max)
                {
                    Console.Write("Points: ");
                    for (int i = 0; i < colorPoints[key].Count; i++)
                        Console.Write(colorPoints[key][i] + " ");
                    Console.WriteLine();
                    ProcessHighest(colorPoints[key]);
                }
        }
    }
}