namespace HandsOn01
{
  internal class CompositeTextWriter : ITextWriter
  {

    private ITextWriter[] textWriters;

    public CompositeTextWriter(params ITextWriter[] textWriters) {
      this.textWriters = textWriters;
    }

    public void Clear()
    {
      foreach(var textWriter in textWriters) {
        textWriter.Clear();
      }
    }

    public void WriteLine(string text)
    {
      foreach(var textWriter in textWriters) {
        textWriter.WriteLine(text);
      }
    }
  }
}