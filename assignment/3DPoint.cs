using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class _3DPoint :ICloneable,IComparable
    {
        public double  X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public _3DPoint()
        {
           
        }
        public _3DPoint(double x)
        {
             X = x;            
        }
        public _3DPoint(double x, double y, double z) :this(x)
        {
            X=x; Y=y; Z=z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({this.X},{this.Y}, {this.Z})";
        }

        public object Clone( )
        {
            return new _3DPoint()
            {
              X=this.X,
              Y=this.Y,
              Z=this.Z
            };
        }

        public int CompareTo(object? obj)
        {
            _3DPoint other=(_3DPoint)obj;

            if (this.X < other.X && this.Y < other.Y)
            {
                return 1;
            }
            else if (other.X == this.X)
            {
                if (other.Y > this.Y)
                {
                    return 1;
                }
                else
                    return 0;
            }
            else
                return 0;

            
        }

        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            return (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z);
        }
        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return  (p1.X != p2.X && p1.Y != p2.Y && p1.Z != p2.Z);
        }




    }
}
