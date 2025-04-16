using System;
namespace SimHack
{
  class Program
  {
    static void Main()
    {
      Console.CursorVisible = true;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("SimHack\n");
      Console.ResetColor();
      Console.WriteLine("\n");

      //Loading terminal
      Term term = new Term();
      term.Terminal();
    }
  }
}