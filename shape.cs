using System;

namespace examination_2
{
    public abstract class Shape
    {
      
      protected Shape (ShapeType shapeType)
      {
      
      }


      public abstract string ToString (string format);

      
     
      public bool Is3D 

      {
        get 
        {
        if(shapeType == ShapeType.Cylinder || shapeType == ShapeType.Cuboid || shapeType == ShapeType.Sphere) {
         return true;
        } 
        else 
        {
          return false;
        }

        }
      }

      public enum ShapeType
      {
        Rectangle,
        Ellipse,
        Cuboid,
        Cylinder,
        Sphere
      }


       public ShapeType shapeType
      {
        get;
        private set;

      }


    }
}
