using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");
      // Turn that answer into an int

      // int faveNumber = 
      // Console.ReadLine();

      // int faveNumber = (int)Console.ReadLine();

      int faveNumber = Convert.ToInt32(Console.ReadLine());
      Console.Write("Your fav number is " + faveNumber.ToString());
      Console.Write(faveNumber);


    }
  }
}
