using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webserver
{
    internal class ServerRootRespons
    {
        public int returnCode { get; set; }
        public string type { get; set; }
        public string columnDict { get; set; }
        public List<UserListDTO> data { get; set; }
        public string exMessage { get; set; }
        public string guid { get; set; }
        public string code { get; set; }
    }
}
