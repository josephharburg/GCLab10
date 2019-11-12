using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Circle
    {
        private double radius;
        public string formattedNumber;
        public double circumference;
        public double area;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateCircumference()
        {
            double Radius = GetRadius();
            this.circumference = (2 * Math.PI) * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
           CalculateCircumference();
           return FormatNumber(circumference);
        }

        public double CalculateArea()        {
            double Radius = GetRadius();
            this.area = Math.PI * (Radius * Radius);
            return area;
        }

        public string CalculateFormattedArea()
        {
            CalculateArea();
            return FormatNumber(area);
        }
        private string FormatNumber(double x)
        {
            formattedNumber = Math.Round(x, 2).ToString();
            return formattedNumber;
        }        public double GetRadius()
        {
            return this.radius;
        }
       

    }
}
