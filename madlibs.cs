using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This is a Mad Libs program
      Author: Dylan
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Here we go!!!");


      // Give the Mad Lib a title:
      string title = "Story Time";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      // The template for the story:
      // Adjectives
      Console.Write("Pick an adjective 1: ");
      string adj1 = Console.ReadLine();
      Console.Write("Pick a 2nd adjective: ");
      string adj2 = Console.ReadLine();
      Console.Write("Pick a 3rd adjective: ");
      string adj3 = Console.ReadLine();
      // Verb
      Console.Write("Pick a verb: ");
      string verb = Console.ReadLine();   
      // Nouns
      Console.Write("Pick a noun: ");
      string noun1 = Console.ReadLine();  
      Console.Write("Pick a 2nd noun: ");
      string noun2 = Console.ReadLine();  
      // Animal
      Console.Write("Pick an animal: ");
      string animal = Console.ReadLine();  
      // Food
      Console.Write("Pick a food: ");
      string food = Console.ReadLine();  
      // Fruit
      Console.Write("Pick a fruit: ");
      string fruit = Console.ReadLine(); 
      // Superhero
      Console.Write("Pick a superhero: ");
      string superhero = Console.ReadLine(); 
      // Country
      Console.Write("Pick a country: ");
      string country = Console.ReadLine(); 
      // Dessert
      Console.Write("Pick a dessert: ");
      string dessert = Console.ReadLine(); 
      // Year
      Console.Write("Pick a year: ");
      string year = Console.ReadLine(); 

      Console.WriteLine(name);
      Console.WriteLine(adj1);
      Console.WriteLine(adj2);
      Console.WriteLine(adj3);


      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
Console.WriteLine(story);
    }
  }
}
