using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ATA_Cisco_187.utils;

namespace ATA_Cisco_187
{
    internal class ATAConfig
    {
        private readonly string file = "C:\\Users\\lucas\\source\\repos\\ATA Cisco 187\\ATA Cisco 187\\model\\ATA.cnf.xml";
        public string Server { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Mac { get; set; }
        public FTPServer FTPServer { get; set; }

        public ATAConfig(string server, string user, string pass, string mac, FTPServer ftpServer)
        {
            Server = server;
            User = user;
            Pass = pass;
            Mac = mac;
            FTPServer = ftpServer;
        }
    }
}
