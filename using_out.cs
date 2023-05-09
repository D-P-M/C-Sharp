using System;

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {
      string statement = "GRRRRRR";
      string sayIt = Whisper(statement, out bool marker);

      Console.WriteLine(sayIt);
    }  
      
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
    
	}
}
