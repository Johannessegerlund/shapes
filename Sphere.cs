using System;

namespace examination_2
{
    class Sphere : Shape3D
    {

    private double _radie;
     public Sphere (double diameter ) : base(ShapeType.Sphere, new Ellipse(diameter), diameter) 
    {
        _radie = diameter/2.0;
        
        
    }
    public double Diameter {
    get
    {
        return Hight; 
    }

    set 
    {
        Hight = value;
    }
    }

    public override double TotalSurfaceArea 
    {
    get 
    {
    return _baseShape.Area * 4.0; 

    }

    }
    public override double MentalArea 
    {
     get 
    {
    return _baseShape.Area * 4.0; 

    }

    }
    public override double Volume
    {
    get 
    {
    return 4.0/3.0 * _baseShape.Area * _radie; 

    }
    
    }
}
}