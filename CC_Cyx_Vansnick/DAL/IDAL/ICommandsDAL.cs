using CC_Cyx_Vansnick.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.DAL.IDAL
{
    public interface ICommandsDAL
    {
        List<Command> FindCommand(int idStore, int delay);
        bool DeleteCommand(int idCommand);
        bool CreateCommand(Command command, int idClient);
    }
}
