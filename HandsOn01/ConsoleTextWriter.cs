using System;

namespace HandsOn01
{

  public class ConsoleTextWriter : ITextWriter
  {
    public ConsoleTextWriter()
    {
    }

    public void Clear()
    {
      Console.Clear();
    }

    public void WriteLine(string text)
    {
      Console.WriteLine(text);
    }
  }
}