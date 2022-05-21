using CC_Cyx_Vansnick.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public class Client : User
    {
        
        public Client(string pw, string fn, string ln,  string e, string ph, string a) : base(pw, fn, ln, e, ph, a)
        {
            this.Type = "Client";
        }
        public Client():base()
        {
            this.Type = "Client";
        }
        public void Create(IUsersDAL usersdal)
        {
            usersdal.CreateUser(this);
        }
    }
}
