using System;
using System.Collections.Generic;
using System.Text;
namespace examination_2
{
    public abstract class Shape
    {
    
      static public bool is3D;
      protected Shape (ShapeType shapeType)
      {
        ShapeType = shapeType;
        is3D = Is3D;

        
      }

      public abstract string ToString (string format);

       public bool Is3D
       {
        get 
        {  
        if(ShapeType == ShapeType.Cylinder || ShapeType == ShapeType.Cuboid || ShapeType == ShapeType.Sphere) {
         
         return true;
        } 
        else
        {
       
          return false;
        }

        }
      }


     static public ShapeType ShapeType
      {
        get;
        private set;
      }
    }
}
