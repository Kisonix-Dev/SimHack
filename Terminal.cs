using System;
using SimHck.Tools;
namespace SimHack
{
  class Term
  {
    public void Terminal()
    {
      try
      {
        while (true)
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write("Terminal > ");
          Console.ResetColor();
          string Input = Console.ReadLine()!;

          switch (Input)
          {
            case "scan":
              Scan scan = new Scan();
              scan.Scanning();
              break;
            case "help":
              Help help = new Help();
              help.help();
              break;
            case "clear":
              Console.Clear();
              break;
            case "exit":
              Console.Clear();
              Console.CursorVisible = false;
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("Выход...");
              Console.ResetColor();
              Thread.Sleep(2000);
              Console.Clear();
              return;
            default:
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine($"Команда {Input} не найдена!");
              Console.ResetColor();
              break;
          }
        }
      }
      catch (Exception ex)
      {
        Console.CursorVisible = false;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Неизвестная ошибка! {ex.Message}\n");
        Console.ResetColor();
        Console.WriteLine("Для продолжения, нажмите на любую клавишу!");
        Console.ReadKey();
        Thread.Sleep(2000);
        Console.Clear();
      }
    }
  }
}