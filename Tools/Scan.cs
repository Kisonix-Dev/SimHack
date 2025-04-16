using System;
namespace SimHck.Tools
{
  class Scan
  {
    public void Scanning()
    {
      try
      {
        while (true)
        {
          Console.Write("Scan IP > ");
          string Input = Console.ReadLine()!;

          switch (Input)
          {
            case "192.168.0.0.1":
              break;
            default:
              break;
            case "exit":
              return;
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"{ex.Message}");
      }
    }
  }
}