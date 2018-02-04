using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_TicketPrinterService
{
    public class PrinterConfiguration
    {
        public string PrinterName { get; set; }
        public int Id { get; set; }

        public static PrinterConfiguration GetConfiguration()
        {
            PrinterConfiguration config = null;

            if (System.IO.File.Exists("print_config.txt"))
            {

                config = JsonConvert.DeserializeObject<PrinterConfiguration>(System.IO.File.ReadAllText("print_config.txt"));
            }
            else
            {
                config = new PrinterConfiguration();
                config.PrinterName = "UNSELECTED";
                System.IO.File.WriteAllText("print_config.txt", JsonConvert.SerializeObject(config));
            }

            return config;
        }
    }
}
