using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //static class
    //containar of static member [property,constructor ,method]
   // and constant
   //you cant create object from this class (helper class)
   //no inheritance from this class

    internal static class Utility
    {
       

        //class member property must deal with [static attribute or constant =>with only static]

        //static property 
        //readonly with static or non static
        //private static readonly double pi = 3.14;


        //Constant 
        private const double pi = 3.14;
        //static constructor omly one per class
        //you cant specify acces modifier or paramter
        //will be called just one time per class lifetime befor first usage of the class
        static Utility()
        {
            //pi = 3.14;
        }

        public static double  CalcArea (double radius)
        {
            return Utility.pi * radius * radius;
        }
    }
}
