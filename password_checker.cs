using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*_+";

      Console.Write("Enter your password: ");
 
      string password = Console.ReadLine();

      Console.WriteLine($"You entered {password}");

      int score = 0;

      if(password.Length >= minLength){
        score++;
      }
        Console.WriteLine($"Length: {score}");

      if(Tools.Contains(password,uppercase)){
        score++;
      }
        Console.WriteLine($"uppercase: {score}");

      if(Tools.Contains(password,lowercase)){
      score++;
      }
      Console.WriteLine($"lowercase: {score}");

      if(Tools.Contains(password,digits)){
      score++;
      }
      Console.WriteLine($"digits: {score}");

      if(Tools.Contains(password,specialChars)){
      score++;
      }
      Console.WriteLine($"specialChars: {score}");

      switch(score)
      {
        case 5:
        case 4:
        Console.WriteLine("Extremely strong");
        break;
        case 3:
        Console.WriteLine("Strong");
        break;
        case 2:
        Console.WriteLine("Medium");
        break;
        case 1:
        Console.WriteLine("Weak");
        break;                 
        default:
        Console.WriteLine("Doesn't meet standards");
        break;
      }

    }
  }
}
