using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Btth.Models
{
    public class kethua
    {
        public double GiaiPhuongTrinh(double heSoA, double heSoB)
        {
            double x = -heSoB / heSoA;
            return x;
        }
    }
}