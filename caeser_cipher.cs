using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
    Console.WriteLine("Write your secret message: ");
    string input = Console.ReadLine();
    // Console.WriteLine(input);
    char[] secretMessage = input.ToCharArray();
    char[] encryptedMessage = new char[secretMessage.Length];

      // Console.WriteLine(secretMessage.Length);
      // Console.WriteLine(encryptedMessage.Length);

    for(int i = 0; i < secretMessage.Length; i++)
    {
       char letter = secretMessage[i]; 
       int letterPosition = Array.IndexOf(alphabet,letter);
       int newLetterPos = (letterPosition + 3) % alphabet.Length;
       char newLetter = alphabet[newLetterPos];
       encryptedMessage[i] = newLetter;    
    }

      string encodedString = String.Join("",encryptedMessage);

      Console.WriteLine(encodedString);


    }
  }
}