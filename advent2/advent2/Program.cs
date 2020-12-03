using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent2
{
    public struct Password
    {
        public string unvalidatedpass;
        public int low, high;
        public char letter;
    }

    class Program
    {
        public static void Main(string[] args)
        {
             
            List<Password> passSet = new List<Password>();
            List<string> passValid = new List<string>();

            Readin(passSet);

            PassCheck1(passSet, passValid);

        }
        public static void PassCheck1(List<Password> passwords, List<string> validPass)
        {
            
            int validCount = 0;
            

            foreach (var i in passwords)
            {
                string passString = i.unvalidatedpass;
                char checkLetter = i.letter;
                
                int letterCount = 0;

                foreach(char c in passString)
                {
                    if(c == checkLetter)
                    {
                        letterCount++;
                    }
                }
                //Console.WriteLine(letterCount);

                if (letterCount <= i.high && letterCount >= i.low)
                {
                    validCount++;
                }
                
            }
            Console.WriteLine(validCount);

        }
        public static void Readin(List<Password> list)
        {
            List<string> readFile = new List<string>();

            Password newPass = new Password();

            char[] delimiters = {'-', ' ', ':', '\n' };

            readFile = File.ReadAllLines(@"C:\Users\Jordan\Documents\code projects\advent of code 2020\advent2\advent2\input.txt").ToList();
            
            foreach(var i in readFile)
            {
                //element [3] is blank space content is elements [0][1][2][4]
                string[] seperated = i.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                //load data into the struct
                newPass.low = Convert.ToInt32(seperated[0]);
                newPass.high = Convert.ToInt32(seperated[1]);
                newPass.letter = Convert.ToChar(seperated[2]);
                newPass.unvalidatedpass = seperated[3];
                
                //load into the password list
                list.Add(newPass);
            }
            
        }
    }
}
