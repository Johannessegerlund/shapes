using System;
using System.Collections.Generic;

namespace examination_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like 3D or 2D?");
            string read = Console.ReadLine();
            string treeD = "3D";
            string twoD = "2D";
            Console.WriteLine("choose how many shapes you would like");
            int numOfShapes = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (counter < numOfShapes )
            {
                if(read == treeD)
                {
                Log(random(true));    
                }
                if (read == twoD)
                {
                Log(random(false)); 
                }
                counter ++;
            }
              
        }


        static void Log (Shape shape) 
        {
            Console.WriteLine(shape.ToString("R"));
        }

        static public double GetRandomeNumber(double minimum, double maximum)
        {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
        }



       static public Shape random (bool Is3D)
        {
        
        List<Shape> intList = new List<Shape>();
        double min = 1.0;
        double max = 200.0;
        Random rand = new Random(); 
        

       if(Is3D)
       {
        Shape Cuboid = new Cuboid(GetRandomeNumber(min, max), GetRandomeNumber(min, max), GetRandomeNumber(min, max));
        
        Shape Cylinder = new Cylinder(GetRandomeNumber(min, max), GetRandomeNumber(min, max), GetRandomeNumber(min, max)); 
       
        Shape Sphere = new Sphere(GetRandomeNumber(min, max));
        Console.WriteLine(Shape.is3D);

        intList.Add(Cuboid);
        intList.Add(Cylinder);
        intList.Add(Sphere);
        
        int index = rand.Next(0,3);
        return intList[index];
       }
        else 
       {
        Shape Rectangle = new Rectangle (GetRandomeNumber(min, max), GetRandomeNumber(min, max));
        Shape Ellipse = new Ellipse(GetRandomeNumber(min, max), GetRandomeNumber(min, max));
        Console.WriteLine(Shape.is3D);
        intList.Add(Rectangle);
        intList.Add(Ellipse);
        
        int index = rand.Next(0,2);
        
        return intList[index];
       }
     } 

      
    }
}
