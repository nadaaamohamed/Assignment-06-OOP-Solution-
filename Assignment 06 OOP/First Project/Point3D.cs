using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.First_Project
{
    internal class Point3D : IComparable<Point3D> , ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D()
        {
            
        }
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        override public string ToString()
        {
            return $"“Point Coordinates : ({X},{Y},{Z})”";
        }

        public int CompareTo(Point3D? Point01)
        {
            if (Point01 is not null )
            {
              int x= X.CompareTo(Point01.X);
                if(x != 0) return x;
                return Y.CompareTo(Point01.Y);

            }
            return 1;

        }

        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }
    }
}
