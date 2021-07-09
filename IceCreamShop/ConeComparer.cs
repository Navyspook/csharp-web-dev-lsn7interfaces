using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            //string xToString = x.Cost.ToString("F"); //F not working, but works
            //string yToString = y.Cost.ToString("F"); //F not working, but works
            int xInt = (int)(x.Cost * 100);
            int yInt = (int)(y.Cost * 100);
            return xInt - yInt;


           // return string.Compare(x.Cost, y.Cost);  //xToString, yToString
        }
    }
}
