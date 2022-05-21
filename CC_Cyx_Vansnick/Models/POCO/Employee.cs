using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public abstract class Employee : User
    {
        private int idStore;

        public int IdStore
        {
            get { return idStore; }
            set { idStore = value; }
        }
        protected Employee(string fn, string ln, string e, string ph, string a, string pw, int ids) : base(pw, fn, ln, e, ph, a)
        {
            idStore = ids;
        }
        public Employee():base()
        {

        }
    }
}
