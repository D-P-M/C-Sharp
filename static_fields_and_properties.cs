/*
Static Fields and Properties
You already know how to create a field and property, like:

class Forest
{
  private string definition;
  public string Definition
  {
     get { return definition; }
     set { definition = value; }
   }
}
The definition of what a forest is applies to all Forest objects, not just one — there should only be one value for the whole class. This is a good use case for a static field/property.

To make a static field and property, just add static after the access modifier (public or private).

class Forest
{
  private static string definition;
  public static string Definition
  { 
    get { return definition; }
    set { definition = value; }
  }
}
Remember that static means “associated with the class, not an instance”. Thus any static member is accessed from the class, not an instance:

static void Main(string[] args)
{
  Console.WriteLine(Forest.Definition);
}
If you tried to access a static member from an instance (like f.Definition) you would get an error like:

error CS0176: Static member 'Forest.Definition' cannot be accessed with an instance reference, qualify it with a type name instead
*/

using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private static int forestsCreated;
    
    // CONSTRUCTORS
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }

    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    
    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }   
  }
}
