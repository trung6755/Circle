using System;

namespace Circle
{
    public class Circle
    {
        private double radius { get; set; }
        private string color { get; set; }
        
        public Circle()
        {

        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }
        public double GetRadius()
        {
            return radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public double GetPerimeter()
        {
            return radius * 2 * Math.PI;
        }

        public override string ToString()
        {
            return "This is a " + GetColor() + 
                " circle with radius of " + GetRadius() + 
                ", perimeter is " + GetPerimeter() + 
                " and area is " + GetArea() + ".";
        }

    }

    public class Cylinder : Circle
    {
        
        private double height { get; set; }
        

        public Cylinder()
        {

        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            
            this.height = height;
            
        }
        public double GetTotalPerimeter()
        {
            return GetPerimeter() + height;
        }
        public double GetTotalArea()
        {
            return GetPerimeter() * height + GetArea() *2;
        }
        public double GetVolume()
        {
            return GetArea() * height;
        }
        public override string ToString()
        {
            return "This is a " + GetColor()+ 
                " cylinder with radius of " + GetRadius() + 
                ", perimeter is " + GetTotalPerimeter() + 
                ", total area is " + GetTotalArea() + 
                ", and volume is " + GetVolume() + ".";
        }
    }
}
