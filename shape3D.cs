using System;

namespace examination_2
{

   
    public abstract class Shape3D: Shape
    {

        protected Shape2D _baseShape;
        private double _hight;
        private ShapeType _shapeType;
        protected Shape3D (ShapeType shapeType, Shape2D baseShape, double hight) : base(shapeType)
        {
         _baseShape = baseShape;
         _shapeType = shapeType;
        Hight = hight;
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
                case "G": // long year pattern
                    
                        return "Length: " + Length + " Width: " + Width + " Hight: " + Hight + " Mentalarea: " + MentalArea + " TotalSurfaceArea: " +
                        TotalSurfaceArea + " volume: " + Volume;
                    
                case "R": // short year pattern
                   
                    return "shapeType: " + _shapeType + " Length: " + Length + " Width: " + Width + " Hight: " + Hight + " Mentalarea: " + MentalArea + " TotalSurfaceArea: " +
                        TotalSurfaceArea + " volume: " + Volume;
                default:
                    throw new FormatException();
            }

        }

        public double Hight {
            get 
            {
                return _hight;
            }
             set 
          {

          if(value < 0) 
          {
          throw new ArgumentOutOfRangeException("Value less thean 0");
          }
            _hight = value;
        }
        }
        public double Length 
        {
               get 
            {
                return _baseShape.Length;
            }
             set 
          {

          if(value < 0) 
          {
          throw new ArgumentOutOfRangeException("Value less thean 0");
          }
            _baseShape.Length = value;
        }

        }
        public virtual double MentalArea 
        {
            get {
              return _baseShape.Perimeter * Hight;
            }
        }

        public virtual double TotalSurfaceArea 
        {
        get 
        {
            return MentalArea + 2.0 * _baseShape.Area;
        }
        }
        public virtual double Volume 
        {
            get 
            {
                return _baseShape.Area * Hight;
            }
        }

        public double Width 
        {
                get 
            {
                return _baseShape.Width;
            }
             set 
          {

          if(value < 0) 
          {
          throw new ArgumentOutOfRangeException("Value less thean 0");
          }
            _baseShape.Width = value;
        }
        }

        }

        
    }

