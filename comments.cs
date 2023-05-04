using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      /*This program writes your age to the console*/
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}
