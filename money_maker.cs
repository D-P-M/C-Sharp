using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins!");
      string totalAsString = Console.ReadLine();
      // Console.WriteLine(totalAsString);
      double total = Convert.ToDouble(totalAsString);
      total = Math.Floor(total);
      Console.WriteLine($"{total} cents is equal to...");
      
      // Coin values
      int gold = 10;
      int silver = 5; 

      // Calculate change
      double goldCoins = Math.Floor(total / gold);
      double remainder = total % gold;

      Console.WriteLine(goldCoins);
      Console.WriteLine(remainder);

      double silverCoins = Math.Floor(remainder / silver);
      remainder = remainder % silver;
      
      // Print results
      Console.WriteLine($"Gold coins: {goldCoins}\nSilver coins: {silverCoins}\nBronze coins: {remainder}");
    }
  }
}
