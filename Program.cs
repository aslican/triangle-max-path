using System;
using System.Collections.Generic;
using System.IO;
public class Program
{


    public static bool isPrime(int a)
        {
            if (a == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(a)); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static int maxPath(int x, int y, List<List<int>> triangle)
        {
            if (x >= triangle.Count)
            {
                return 0;
            }

            if (isPrime(triangle[x][y]))
            {
                return 0;
            }
            else
            {
                return triangle[x][y] + Math.Max(maxPath(x + 1, y, triangle), maxPath(x + 1, y + 1, triangle));
            }
        }


        static void Main(string[] args)
        {

            string fileName = @"file.txt";

            string[] lines = System.IO.File.ReadAllLines(fileName);
            List<List<int>> myList = new List<List<int>>();

            foreach (string line in lines)
            {
                string[] chars = line.Split(' ');
                List<int> number = new List<int>();

                foreach (string numb in chars)
                {
                    number.Add(int.Parse(numb));

                }
                myList.Add(number);

            }

            int result = maxPath(0, 0, myList);
            Console.WriteLine(result);
        }
    }
