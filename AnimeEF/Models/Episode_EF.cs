using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeEF.Models
{
    public class Episode_EF
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Story { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string SeasonId { get; set; }
    }
}
