using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeEF.Models
{
    public class Anime_EF
    {
        private int episodes;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Episodes { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public string Tags { get; set; }
        public string Publisher { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
