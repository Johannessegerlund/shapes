using System;

namespace examination_2
{
    class Ellipse : Shape2D
    {

      private double _radie;

      private double _a;

      
      
        public Ellipse (double diameter): base(ShapeType.Ellipse, diameter, diameter ) 
        {
            Length = diameter;
            _radie = Length/2.0;
            
        }

        public Ellipse (double vdiameter, double hdiameter): base(ShapeType.Ellipse, vdiameter, hdiameter ) 
        {
          Width = vdiameter;
          Length = hdiameter;
          _a = Width / 2.0;
          _radie = Length / 2.0;
          

        }
        public override double Area 
        {
          
            get{

              if( Width != Length ) { 
                return Math.PI * _a * _radie;
              } else {
               return Math.PI * _radie * _radie;
              }
                }
        }

        public override double Perimeter 
        {
          get{
          if(Width != Length ) 
          {
            return Math.PI * Math.Sqrt((2.0 *_a)*(2.0 *_a)  + (2.0 * _radie)*(2.0 * _radie) );
          } else 
          {
             return 2 * Math.PI * _radie;
         
          }
        }
        }

    }
}