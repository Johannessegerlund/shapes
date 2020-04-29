using System;

namespace examination_2
{
    class Rectangle
    {

      private int _width;
      private int _hight;
        public Rectangle (int width, int hight)
        {
            _width = width;
            _hight = hight;
            
        }
        public double Area 
        {
            get{return _width * _hight;}
        }

        public double Perimeter {
            get{return _width * 2 + _hight * 2;}
        }
    }
}