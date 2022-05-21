using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public class OrderPicker : Employee
    {
        public OrderPicker(string fn, string ln, string e, string ph, string a, string pw, int ids) : base( fn, ln, e, ph, a, pw, ids)
        {
        }
        public OrderPicker():base()
        {

        }
    }
}
