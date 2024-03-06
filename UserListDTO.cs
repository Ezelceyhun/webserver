using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webserver
{
    internal class UserListDTO
    {
        public int id { get; set; }
        public string webUserID { get; set; }
        public string name { get; set; }
        public string authType { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public long readOnlyAccess { get; set; }
        public long readWriteAccess { get; set; }
        public int isActive { get; set; }
    }
}
