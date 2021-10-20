using System;
using System.Collections.Generic;
using System.Text;

namespace AreaObjects
{
    class Circle
    {
        public double Radius { get; set; }
        public double CircleArea => (Radius * 2) * Math.PI;
        public double CircleCircumference => Radius * Radius * Math.PI;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        //Overrides ToString with radius and circle calculations, while rounding to 2nd decimal place.
        public override string ToString()
        {
            string output = $"Radius: {Math.Round(Radius, 2)}\nCircumference: {Math.Round(CircleCircumference, 2)}\nArea: {Math.Round(CircleArea, 2)}";
            return output;
        }

    }
}
