using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {
        private double radius;

        public Circle()//constructor
        {

        }

        /*  public Circle(double r)
          {
              radius = r;
          }*/
        public void SetRadius(double r)
        {
            radius = r;
        }
        public override int GetArea()
        {

            double area = Math.PI * radius * radius;
            return (int)area;
        }
    }
}

