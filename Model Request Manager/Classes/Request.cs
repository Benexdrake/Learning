using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Request_Manager.Classes
{
    public class Request
    {
        public string note { get; set; }
        public int category { get; set; }
        public string username { get; set; }
        public string text { get; set; }
        public string fileName { get; set; }
        public string guid { get; set; }
        public int requestId { get; set; }
        public int requestUserId { get; set; }
        public bool whiteBox { get; set; }
        public bool lowPoly { get; set; }
        public bool highPoly { get; set; }
        public bool texture { get; set; }
        public bool available { get; set; }
        public bool like { get; set; }
        public string requestDate { get; set; }
    }
}
