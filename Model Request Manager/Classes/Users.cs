using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Request_Manager.Classes
{
    public class Users
    {
        public int UserID { get; set; }
        public Guid UserGuid { get; set; }
        public string Username { get; set; }
    }
}
