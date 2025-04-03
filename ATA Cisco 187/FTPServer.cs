using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

        public async Task Upload(string file)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{IP}/{file}");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(User, Pass);

            using (FileStream fileStream = File.Open(file, FileMode.Open, FileAccess.Read))
            {
                using (Stream requestStream = request.GetRequestStream())
                {
                    await fileStream.CopyToAsync(requestStream);
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
                    }
                }
            }
        }
    }
}
