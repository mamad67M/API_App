using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.DTOs
{
    public class CommandReadDTO
    {  
        public int Id { get; set; }      
        public string HowTo { get; set; }
        public string Line { get; set; } 
    }
}
