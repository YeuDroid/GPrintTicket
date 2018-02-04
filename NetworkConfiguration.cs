using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_TicketPrinterService
{
    public class NetworkConfiguration
    {
        public string IP { get; set; }
        public string NAMESERVER { get; set; }
        public int PORT { get; set; }
        public string METOD_RESOLVED { get; set; }
        public int Id { get; set; }
        public string x1 { get; set; }
        public string x2 { get; set; }
        public string x3 { get; set; }
        public string x4 { get; set; }
        public string x5 { get; set; }
        public double d1 { get; set; }
        public double d2 { get; set; }
        public double d3 { get; set; }
        public double d4 { get; set; }


        public static NetworkConfiguration GetConfiguration()
        {
            var netconfig = MainForm.db.GetCollection<NetworkConfiguration>("network_config").FindById(1);

            if (netconfig == null)
            {
                netconfig = new NetworkConfiguration();
                netconfig.Id = 1;
                netconfig.METOD_RESOLVED = "IP";
                netconfig.IP = "192.168.1.84";
                netconfig.PORT = 12347;
                MainForm.db.GetCollection<NetworkConfiguration>("network_config").Insert(netconfig);
            }

            return netconfig;
        }
    }
}
