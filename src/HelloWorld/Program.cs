using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string message = args.Length == 0 ? "Hello, World!" : args[args.Length - 1];
      var messenger = new StockMessenger(message);
      Console.WriteLine(messenger.GetMessage());
    }
  }
}
