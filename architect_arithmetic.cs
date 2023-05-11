using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("What monument would you like to work with?");
      Console.Write("Choose Teotihuaca (1), Taj Mahal (2), or Mecca (3): ");

      string monument = Console.ReadLine();

      double totalArea;

      switch(monument)
      {
        case "1":
        // Teotihuacan
        totalArea = Rect(2500,1500)+Tri(750,500)+ 0.5 * Circ(375);
        break;
        case "2":
        // Taj Majal
        totalArea = Rect(90.5, 90.5) - 4 * Tri(24,24);  
        break; 
        case "3":
        // Mecca
        totalArea = Rect(180,106) + Rect(200,264) + Tri(264,84);
        break;
        default:
        totalArea = 0;
        break;
      }
    
      double totalCost = totalArea * 180;
      Console.WriteLine($"The total cost is: {Math.Round(totalCost,2)}");
    }

    static double Rect(double length, double width)
    {
      return length * width;
    }

    static double Circ(double radius)
    {
      return Math.PI * Math.Pow(radius,2);
    }

    static double Tri(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}
