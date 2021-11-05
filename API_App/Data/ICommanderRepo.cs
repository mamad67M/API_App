using API_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommand();
        Command GetCommandeById(int id);
        void CreatCommand(Command cmd);
        
    }
}
