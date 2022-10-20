using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Spielerei
{
    public class Folder
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string FolderName { get; set; }
        public bool Expanded { get; set; }
        public bool HasSubFolders { get; set; }
    }
}
