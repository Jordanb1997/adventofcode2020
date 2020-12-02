using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent1
{

    class Program
    {
        static void Main(string[] args)
        {
            //instantiate data structures
            List<string> readFile = new List<string>();
            List<int> numbers1 = new List<int>();
            List<int> numbers2 = new List<int>();
            List<int> numbers3 = new List<int>();

            int part1result;
            int part2result;

            //read in file
            readFile = File.ReadAllLines(@"C:\Users\Jordan\Documents\code projects\advent of code 2020\advent1\advent1\input.txt").ToList();
            
            //convert and send file contents to int lists
            foreach (var i in readFile)
            {
                numbers1.Add(Convert.ToInt32(i));
                numbers2.Add(Convert.ToInt32(i));
                numbers3.Add(Convert.ToInt32(i));
            }

            //find sum to 2020 for part 1
            part1result = SearchListp1(numbers1, numbers2);
            Console.WriteLine(part1result);
            //part2
            part2result = SearchListp2(numbers1, numbers2, numbers3);
            Console.WriteLine(part2result);
        }
        public static int SearchListp1(List<int> list1, List<int> list2)
        {
            //initailise containers for the sum numbers
            int num1 = 0, num2 = 0;
            int sumTarget = 2020;

            //loop through lists to find sum 2020
            //then store sum numbers into an array
            foreach (var i in list1)
            {
                
                foreach (var a in list2)
                {
                    if (i + a == sumTarget)
                    {
                        num1 = i;
                        num2 = a;
                    }
                }
            }
            return num1 * num2;
        }
        public static int SearchListp2(List<int> list1, List<int> list2, List<int> list3)
        {
            //initialise containers for the sum numbers
            int num1 = 0, num2 = 0, num3 = 0;
            int sumTarget = 2020;

            //loop through lists to find sum 2020
            //then store sum numbers into an array
            foreach (var i in list1)
            {

                foreach (var a in list2)
                {
                    foreach (var b in list3)
                    {
                        if (i + a + b == sumTarget)
                        {
                            num1 = i;
                            num2 = a;
                            num3 = b;
                        }
                    }
                }
            }
            return num1 * num2 * num3;
        }
    }
}
