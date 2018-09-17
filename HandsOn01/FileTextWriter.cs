using System.IO;

namespace HandsOn01
{

  public class FileTextWriter : ITextWriter
  {
    private readonly string fileName = "";

    public FileTextWriter(string fileName)
    {
      this.fileName = fileName;
    }

    public void Clear()
    {
      File.WriteAllText(this.fileName, "");
    }

    public void WriteLine(string text)
    {
      File.AppendAllLines(this.fileName, new string[] { text });
    }
  }
}