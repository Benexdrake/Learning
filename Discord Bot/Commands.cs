using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot
{
    public class Commands
    {
        public int ID { get; set; }
        public string CommandName { get; set; }
        public string[] AliasName { get; set; } = { "No Aliases" };
        public string Information { get; set; }
        public string ErrorMessage { get; set; }
    }
}
