using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      f.Trees = 0;

      Forest r = new Forest("Rendlesham");
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
      Console.WriteLine(r.Biome);
    }
  }
}
