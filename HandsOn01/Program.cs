using System;

namespace HandsOn01
{
    class Program
    {
        static void Main(string[] args)
        {
            ITextWriter writer = new CompositeTextWriter(
                new NullTextWriter(),
                new ConsoleTextWriter(),
                new FileTextWriter(@"./Messages.txt"));
            writer.WriteLine("Foo");
            writer.WriteLine("Bar");
            writer.WriteLine("Baz");
            writer.Clear();
            writer.WriteLine("Ploeh");
            writer.WriteLine("Fnaah");
        }
    }
}
