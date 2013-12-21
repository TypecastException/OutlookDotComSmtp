using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmtpMailConnections
{
    class Program
    {
        static void Main(string[] args)
        {
            string mailUser = "YourAccount@outlook.com";
            string mailUserPwd = "aotuptnagnkbfiez";

            var sender = new OutlookDotComMail(mailUser, mailUserPwd);
            sender.SendMail("recipient@example.com", "Test Mail", "Hello!");
        }
    }
}
