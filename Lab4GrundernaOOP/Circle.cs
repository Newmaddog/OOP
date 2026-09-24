using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4GrundernaOOP
{
    internal class Circle
    {
        float Radius;

        public Circle(float radius)
        {
            Radius = radius;
        }

        internal float GetArea()
        {
            float area;
            area = Radius * Radius * ((float)Math.PI);
            return area;
        }
    }
}
