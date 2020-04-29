using System;

namespace examination_2
{
    class Elipse
    {

      private double _diameter;
      private double _hdiameter;

      private double _vdiameter;

      private double _radie;

      private double _a;

      private double _b;
      
        public Elipse (double diameter)
        {
            _radie = diameter/2;
            _diameter = diameter;
        }

        public Elipse (double vdiameter, double hdiameter) {
          _a = _vdiameter / 2;
          _b = _hdiameter / 2;
          _vdiameter = vdiameter;
          _hdiameter = hdiameter;
        }
        public double Area 
        {
          
            get{

              if(_vdiameter != _hdiameter ) { 
                return Math.PI * _a * _b;
              } else {
               return Math.PI * _radie * _radie;
              }
                }
        }

        public double Perimeter 
        {
          get{
          if(_vdiameter != _hdiameter ) 
          {
            return Math.PI * Math.Sqrt(_a * 2 + _b * 2);
          } else 
          {
             return 2 * Math.PI * _radie;
         
          }
        }
        }

    }
}