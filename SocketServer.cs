using System;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_TicketPrinterService
{
    class SocketServer
    {
        public NetworkConfiguration Configuration;
        System.Threading.Thread hiloEscucha;
        public SocketServer()
        {
            this.Configuration = NetworkConfiguration.GetConfiguration();
            hiloEscucha = new System.Threading.Thread(Run);
            hiloEscucha.Priority = System.Threading.ThreadPriority.Lowest;
        }
        public void Start()
        {
            hiloEscucha.Start();
        }
        public void Run()
        {
            String rawJsonCatched = "";
            while (true)
            {
                rawJsonCatched = ScanForValue();
                if(rawJsonCatched[0].ToString() == "@")
                {
                    System.Windows.Forms.MessageBox.Show(rawJsonCatched);
                }
                else
                {
                    var dataTicket = JsonConvert.DeserializeObject<Ticket>(rawJsonCatched);
                    PrinterModule printer = new PrinterModule();
                    printer.PrintTicket(dataTicket);
                    System.Windows.Forms.MessageBox.Show("TICKET: " + dataTicket.Identifiquer.ToString() + " IMPRESO");
                }
            }
        }
        private String ScanForValue()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, this.Configuration.PORT);
            listener.Start();
            string msg = "NULL";
            using (TcpClient c = listener.AcceptTcpClient())
            using (NetworkStream n = c.GetStream())
            {
                msg = new BinaryReader(n).ReadString();
            }
            listener.Stop();
            return msg;
        }
 
    }

}

