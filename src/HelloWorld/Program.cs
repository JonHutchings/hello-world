using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var messenger = new StockMessenger("Hello World!");
      Console.WriteLine(messenger.GetMessage());
    }
  }
}
