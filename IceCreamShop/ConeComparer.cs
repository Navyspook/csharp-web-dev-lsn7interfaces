using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            //string xToString = x.Cost.ToString(); //F not working, but works
            //string yToString = y.Cost.ToString(); //F not working, but works
            int xint = (int)(x.Cost * 100);
            int yint = (int)(y.Cost * 100);
            return xint - yint;


            //return string.Compare(xToString, yToString);  //
        }
    }
}
