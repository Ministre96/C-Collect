using CC_Cyx_Vansnick.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.DAL.IDAL
{
    public interface ILigneCommandsDAL
    {
        bool CreateLC(int idCommand, int idArticle, int quantity);
    }
}
