using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets("James","Jimmy");
      NamePets("Toby","Billybob","Skippy");
      NamePets();
    }
    
    static void NamePets(string name1, string name2)
    {
      Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
    }

    static void NamePets(string name3, string name4, string name5)
    {
      Console.WriteLine($"Your pets {name3}, {name4}, and {name5} will be joining your voyage across space!");
    }

    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }


  }
}
