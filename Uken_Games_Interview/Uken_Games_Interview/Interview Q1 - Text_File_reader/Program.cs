using System;
using System.IO;
using System.Collections.Generic;

namespace Interview_Q1_Text_File_reader
{
    //The purpose of this program is to find the smallest, least occuring number in a given Dataset
    //Time Complexity O(n) Space Complexity O(n), thanks to the key-value pairs that come with a hash table
    class Program
    {
        //Checks file and processes all the Data into an easy to use Array
        static List<int> ReadFile(String filename)
        {
            List<int> numList = new List<int> {};
            
            String line;
            StreamReader readerFile = new StreamReader(filename);

            //initializing the line variable
            line = readerFile.ReadLine();
            numList.Add(Int32.Parse(line));

            //Continue to read until the end of file
            int i = 1;
            while (line != null)
            {           

                line = readerFile.ReadLine();                
                numList.Add(Convert.ToInt32(line));
                i++;
            }

            numList.Sort();
            readerFile.Close();
            return numList;
        }

        static void CalculateFrequency(String filename, List<int> List)
        {
            //Inserts all elements into a hash.
            Dictionary<int, int> count = new Dictionary<int, int>();

            //Counts frequency by using the key-value pairs
            for (int i = 0; i < List.Count; i++)
            {
                int key = List[i];
                if (count.ContainsKey(key))
                {
                    int frequency = count[key];
                    frequency++;
                    count[key] = frequency;
                }
                else { count.Add(key, 1); }
            }

            int lowestCount = List.Count + 1;
            int lowestNumber = int.MaxValue;

            // finds the minimum frequency
            foreach (KeyValuePair<int, int> pair in count)
            {
                if (lowestCount >= pair.Value)
                {                                     
                    lowestCount = pair.Value;
                }
            }

            //finds the lowest Number among the minimum frquency
            foreach (KeyValuePair<int, int> pair in count)
            {
                if (pair.Value == lowestCount && pair.Key < lowestNumber)
                {
                    lowestNumber = pair.Key;
                }
            }

            Console.WriteLine($"File: {filename}, Number: {lowestNumber}, Repeated: {lowestCount} times\n\n");
        }


        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Here are the results: \n\n");

            Console.ForegroundColor = ConsoleColor.Red;

            List<int> List1 = ReadFile("1.txt");
                CalculateFrequency("1.txt", List1);

            List<int> List2 = ReadFile("2.txt");
                CalculateFrequency("2.txt", List2);

            List<int> List3 = ReadFile("3.txt");
                CalculateFrequency("3.txt", List3);

            List<int> List4 = ReadFile("4.txt");
                CalculateFrequency("4.txt", List4);

            List<int> List5 = ReadFile("5.txt");
                CalculateFrequency("5.txt", List5);

            Console.WriteLine("Press any key to Exit...");
            Console.ReadKey();
        }        
    }
}
