using System;

namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      
      do
      {
        Console.WriteLine("RING RING!!");
      } while (!buttonClick);

        Console.WriteLine("Time for a five minute break.");
    }
  }
}