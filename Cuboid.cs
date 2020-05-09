using System;

namespace examination_2
{
    class Cuboid : Shape3D
    {

        public Cuboid (double length, double width, double hight) : base(ShapeType.
        Cuboid, new Rectangle(width, length), hight)
        {
          Length = length;
          Width = width;
          Hight = hight;
    }
}
}