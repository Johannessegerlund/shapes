using System;

namespace examination_2
{

   
    public abstract class Shape3D: Shape
    {

        protected Shape2D _baseShape;
        private double _hight;
        

        protected Shape3D (ShapeType shapeType, Shape2D baseShape, double hight) : base(shapeType)
        {
         _baseShape = baseShape;
        
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
                case "G": 
                        return "shapeType: " + ShapeType + "\nvolume: " + Volume   + "\nMentalarea: " + MentalArea + "\nTotalSurfaceArea: " +
                        TotalSurfaceArea +  "\nLength: " + Length + "\nWidth: " + Width + "\nHight: " + Hight + "\n";
                    
                case "R": 
                   
                    return "shapeType: " + ShapeType +  ", volume: " + Volume + ", Mentalarea: " + MentalArea + ", TotalSurfaceArea: " + TotalSurfaceArea +  ", Length: " + Length + ", Width: " + Width + ", Hight: " + Hight ;
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

