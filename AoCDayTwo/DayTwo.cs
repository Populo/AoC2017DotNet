using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using AoCHelpers;

namespace AoCDayTwo
{
    public class DayTwo
    {
        private List<string> input;
        private static string fileName = "input.txt";
        
        
        static void Main(string[] args)
        {
            DayTwo d2 = new DayTwo(fileName);
            Console.WriteLine("Part 1: " + d2.RunPartOne());
            Console.WriteLine("Part 2: " + d2.RunPartTwo());
        }

        public DayTwo(string fileName)
        {
            input = FileReaderHelper.ReadFile(fileName);
        }

        public int RunPartOne()
        {
            int hash = 0;

            List<int[]> lists = new List<int[]>();
            
            foreach (string s in input)
            {
                string[] splitList = s.Split("\t");
                int[] currentLine = new int[splitList.Length];
                
                for (int i = 0; i < splitList.Length; i++)
                {
                    currentLine[i] = Int32.Parse(splitList[i]);
                }
                
                lists.Add(currentLine);
            }

            foreach (int[] i in lists)
            {
                int smallest = int.MaxValue, largest = 0;

                foreach (int element in i)
                {
                    if (element < smallest) smallest = element;
                    if (element > largest) largest = element;
                }

                hash += largest - smallest;
            }
            
            return hash;
        }

        public int RunPartTwo()
        {
            int hash = 0;
            
            List<int[]> lists = new List<int[]>();
            
            foreach (string s in input)
            {
                string[] splitList = s.Split("\t");
                int[] currentLine = new int[splitList.Length];
                
                for (int i = 0; i < splitList.Length; i++)
                {
                    currentLine[i] = Int32.Parse(splitList[i]);
                }
                
                lists.Add(currentLine);
            }

            foreach (int[] i in lists)
            {
                bool found = false;
                
                while (!found)
                {
                    for (int element = 0; element < i.Length; element++)
                    {

                        int pivot = i[element];
                    
                    
                        for (int j = 0; j < i.Length; j++)
                        {
                            if (pivot != i[j] && pivot % i[j] == 0)
                            {
                                hash += (pivot / i[j]);
                                found = true;
                            }
                        }
                        
                        
                    }
                }
            }

            return hash;
        }
    }
}