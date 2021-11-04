using API_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderDbContext _dbCtxt;

        public SqlCommanderRepo( CommanderDbContext dbCtxt)
        {
            _dbCtxt = dbCtxt;
        }
        public IEnumerable<Command> GetAllCommand()
        {
            return _dbCtxt.Commands.ToList();
        }

        public Command GetCommandeById(int id)
        {
            return _dbCtxt.Commands.SingleOrDefault(o => o.Id == id);
        }
    }
}
