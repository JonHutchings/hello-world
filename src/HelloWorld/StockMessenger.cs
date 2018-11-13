using System;

namespace HelloWorld
{
  class StockMessenger : IMessenger
  {
    private readonly string _message;

    public StockMessenger(string message)
    {
      _message = message ?? throw new ArgumentNullException(nameof(message));
    }

    public string GetMessage()
    {
      return _message;
    }
  }
}
