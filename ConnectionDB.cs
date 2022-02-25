using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS
{
    public static class ConnectionDB
    {
        public static string ConnectionString()
        {
            string constring = "Server=localhost; Database=sdp; Uid=root; Pwd=''; SslMode=none";
            return constring;
        }
    }
}
