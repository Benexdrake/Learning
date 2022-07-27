using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Request_Manager.Classes
{

    public static class Save
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static Guid UserGuid { get; set; }
    }
}
