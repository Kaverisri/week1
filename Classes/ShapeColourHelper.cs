using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourColurHelper
    {
        private static readonly Random _random = new Random();

        public enum Colour
        {
            Yellow,
            Red,
            Blue,
            Green,
            Orange
        }
        public static Colour GetRandomColour()
        {
            Array values = Enum.GetValues(typeof(Colour));
            return (Colour)values.GetValue(_random.Next(values.Length));
        }

        public static Shape AddColour(Shape s)
        {
            s.colour = "Red";
            return s;
        }
        public static Shape ChangeColour(Shape s)
        {
            s.colour = "Blue";
            return s;
        }

    }
}
