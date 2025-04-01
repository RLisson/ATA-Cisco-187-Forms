using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATA_Cisco_187
{
    internal class FTPServer
    {
        public string IP { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public int Port { get; set; }

        public FTPServer(string iP, string user, string pass, int port)
        {
            IP = iP;
            User = user;
            Pass = pass;
            Port = port;
        }
    }
}
