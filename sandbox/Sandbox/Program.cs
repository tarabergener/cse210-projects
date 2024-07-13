using System;
using System.Collections.Generic;

class Program
{
        static void Main(string[] args)
        {
                List<string> wordList = new List<string>() { "mom_loves", "apples", "bananas", "cats", "dogs" };
                Random rand = new Random();

                while (true)
                {
                        Console.Write("Enter text: ");
                        string input = Console.ReadLine();

                        if (string.IsNullOrEmpty(input))
                        {
                                break;
                        }

                        string[] words = input.Split(' ');
                        string randomWord = wordList[rand.Next(wordList.Count)];

                        for (int i = 0; i < words.Length; i++)
                        {
                                if (words[i].ToLower() == randomWord.ToLower())
                                {
                                        string newWord = randomWord.Replace('_', '*');
                                        words[i] = newWord;
                                }
                        }

                        Console.WriteLine(string.Join(" ", words));
                }
        }
}