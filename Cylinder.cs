using System;

namespace examination_2
{
    class Cylinder : Shape3D
    {

        public Cylinder (double hdiameter, double vdiameter, double hight) : base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), hight)
        {
          Length = hdiameter;
          Width = vdiameter;
          Hight = hight;
    }
}
}