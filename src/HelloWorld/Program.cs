using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        var messenger = new StockMessenger(args[args.Length-1]);
        Console.WriteLine(messenger.GetMessage());
      }
    }
  }
}
