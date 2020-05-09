using System;

namespace examination_2
{
    class Program
    {
        static void Main(string[] args)
        {
        Shape Rectangle = new Rectangle (10.8, 10.7);
        Log(Rectangle);

        Shape Ellipse = new Ellipse(200, 20);
        Log(Ellipse);

        Shape Cuboid = new Cuboid(200, 20, 20);
        Log(Cuboid);

        Shape Cylinder = new Cylinder(2.0, 2.0, 2.0);
        Log(Cylinder);
        
        Shape Sphere = new Sphere(29.6);
        Log(Sphere);
        }

        

        static void Log (Shape shape) {
            Console.WriteLine(shape.ToString("G"));
        }
    }
}
