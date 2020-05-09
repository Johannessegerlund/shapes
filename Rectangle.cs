using System;

namespace examination_2
{
    class Rectangle : Shape2D
    {

      
        public Rectangle (double width, double length ) : base(ShapeType.Rectangle, width, length) 
        {
            Width = width;
            Length = length;
            
            
        }
        public override double Area 
        {
            get
            {
            return Width * Length;
            }
        }

        public override double Perimeter 
        {
            get
            {
            return Width * 2.0 + Length * 2.0;
            }
        }
    }
}