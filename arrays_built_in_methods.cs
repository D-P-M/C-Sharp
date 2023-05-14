using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      int firstThreeStar = Array.IndexOf(ratings, 3);
      
        Console.WriteLine($"Song number {firstThreeStar + 1} is rated three stars.");

      string findName = Array.Find(summerStrut, song => song.Length > 10);

      Console.WriteLine($"The first song that has more tan 10 characters in the title is {findName}");

      Array.Sort(summerStrut);
      Console.WriteLine($"{summerStrut[0]} is the first song.");
      Console.WriteLine($"{summerStrut[7]} is the last song.");


    }
  }
}
