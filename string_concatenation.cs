using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
  string beginning = "Once upon a time, ";
  string middle = "an old man tried his best. ";
  string end = "But in the end he died!";
      // Concatenate the string and the variables
  string story = beginning + "\n" + middle + "\n" + end;

      // Print the story to the console 
  Console.WriteLine(story);
    }
  }
}
