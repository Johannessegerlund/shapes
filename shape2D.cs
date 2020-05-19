using System;


namespace examination_2
{
    public abstract class Shape2D : Shape
    {

        private double _width;
        private double _length;

      private ShapeType _shapeType;
        protected Shape2D (ShapeType shapeType, double width, double length ) : base(shapeType)
        {
          Width = width;
          Length = length;
          _shapeType = shapeType;
       
         
        }

        public override string ToString() 
        {
            return ToString("G");
        } 

        public override string ToString(string format)
        {
        
            switch (format)
            {
                case null:
                case "":
                case "G": 
                return 
                       "shapeType: " + _shapeType +  "\nLength: " + Length + "\nWidth: " + Width + "\nArea: " + Area + " \nOmkrets: " + Perimeter + "\n";
                    
                case "R": 
                   
                    return "shapeType: " + _shapeType + " Length: " + Length + " Width: " + Width + " Area: " + Area + " Omkrets: " + Perimeter;
                default:
                    throw new FormatException();
            }

        }
         public virtual double Area 
        {

        get;
        
        
        }

        public virtual double Perimeter 
        {
        
        get;
    
        }

        public double Length 
        {
          get 
          {
            return _length;
          }

          set 
          {
          if(_length < 0) 
          {
          throw new ArgumentOutOfRangeException("Value less thean 0");
          }
            _length = value;
        }
        }

        public double Width 
        {
           get 
          {
            return _width;
          }

          set 
          {
          if(_width < 0) 
          {
          throw new ArgumentOutOfRangeException("Value less thean 0");
          }
          _width = value;

        }
        }

        
    }
}
