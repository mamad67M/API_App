using API_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommand();
        Command GetCommandeById(int id);
        
    }
}
