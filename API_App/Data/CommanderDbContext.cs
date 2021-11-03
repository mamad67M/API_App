using API_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Data
{
    public class CommanderDbContext: DbContext
    {
        public CommanderDbContext(DbContextOptions<CommanderDbContext> options): base(options)
        {

        }
        public DbSet<Command> commands { get; set; }
    }
}
