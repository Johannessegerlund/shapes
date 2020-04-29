using System;

namespace examination_2
{
    class Program
    {
        static void Main(string[] args)
        {
          Rectangle rect = new Rectangle(5,5);
          Console.WriteLine(rect.Area);
          Console.WriteLine(rect.Perimeter);
          Elipse eli = new Elipse(30);
          Console.WriteLine(eli.Area);
          Console.WriteLine(eli.Perimeter);
        }
    }
}
