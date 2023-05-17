using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Sherewood";
      f.biome = "Temperate forest";
      f.trees = 400;
      f.age = 100;

      Console.WriteLine(f.name);
      Console.WriteLine(f.biome);
      Console.WriteLine(f.trees);
      Console.WriteLine(f.age);
    }
  }
}
