using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net.NetworkInformation;

namespace AON_Ticket_Tracker
{
    class Connection
    {
        public string connectString, mySvr, myIP;

        public Connection()
        {
            getString();
        }
        private void chSvr()
        {
             try
            {
                myIP = System.IO.File.ReadAllText("svrcnf.cnf");
            }
            catch
            {

            }
        }
        private void checkHostExist()
        {
            chSvr();
            Ping pingCh = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "ping test";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            try
            {
                PingReply reply = pingCh.Send("16.188.53.123", 1000, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    mySvr = "16.188.53.123";
                }
                else if (reply.Status == IPStatus.TimedOut)
                {
                    mySvr = myIP;
                }
                else
                {
                    mySvr = myIP;
                }
            }
            catch
            { mySvr = myIP;}
        }
        private void getString()
        {
            try
            {
                checkHostExist();
                string db, uid, passwd, tmeout;
                db = "seadrill";
                uid = "aonautics";
                passwd = "f@!rYt@!l@2013";
                tmeout = "20";
                //Based From http://bitdaddys.com/MySQL-ConnectorNet.html
                connectString = "Database=" + db + ";Data Source=" + mySvr + ";User Id=" + uid + ";Password=" + passwd + ";Connection Timeout=" + tmeout + ";";
            }
            catch
            {
                
            }
        }
    }
}
