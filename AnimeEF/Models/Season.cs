using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeEF.Models
{
    public class Season
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public Episode[] Episodes { get; set; }
    }
}
