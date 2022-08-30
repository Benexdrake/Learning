using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Printing;

namespace WPF_Test
{
    internal class Test
    {
        public string Methode()
        {
            var server = new LocalPrintServer();
            PrintQueue queue = server.DefaultPrintQueue;
            return queue.Name;
        }
    }
}
