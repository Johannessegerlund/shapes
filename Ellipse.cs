using System;

namespace examination_2
{
    class Ellipse : Shape2D
    {

      private double _diameter;
      private double _hdiameter;

      private double _vdiameter;

      private double _radie;

      private double _a;

      private double _b;
      
        public Ellipse (double diameter): base(ShapeType.Ellipse, diameter, diameter ) 
        {
            _radie = diameter/2;
            _diameter = diameter;
            
        }

        public Ellipse (double vdiameter, double hdiameter): base(ShapeType.Ellipse, vdiameter, hdiameter ) 
        {
          _a = vdiameter / 2.0;
          _b = hdiameter / 2.0;
          _vdiameter = vdiameter;
          _hdiameter = hdiameter;
          

        }
        public override double Area 
        {
          
            get{

              if(_vdiameter != _hdiameter ) { 
                return Math.PI * _a * _b;
              } else {
               return Math.PI * _radie * _radie;
              }
                }
        }

        public override double Perimeter 
        {
          get{
          if(_vdiameter != _hdiameter ) 
          {
            return Math.PI * Math.Sqrt((2.0 *_a)*(2.0 *_a)  + (2.0 * _b)*(2.0 * _b) );
          } else 
          {
             return 2 * Math.PI * _radie;
         
          }
        }
        }

    }
}