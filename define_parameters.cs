using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(2);
      VisitPlanets(3);
      VisitPlanets(4);
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}
