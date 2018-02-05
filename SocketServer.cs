using System;
using System.Windows.Forms;
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
                //MessageBox.Show(rawJsonCatched);
                
                if (rawJsonCatched == "NULL")
                {
                    MessageBox.Show("NULL RECEIVER #123");
                    continue;
                }
                if (rawJsonCatched[0].ToString() == "@")
                {
                    MessageBox.Show(rawJsonCatched);
                }
                else
                {
                    var dataTicket = JsonConvert.DeserializeObject<Ticket>(rawJsonCatched);
                    PrinterModule printer = new PrinterModule();
                    printer.PrintTicket(dataTicket);
                    MessageBox.Show("TICKET: " + dataTicket.Identifiquer.ToString() + " IMPRESO");    
                }
                
            }
        }
        private String ScanForValue()
        {

            TcpListener listener = new TcpListener(IPAddress.Any, this.Configuration.PORT);
            listener.Start();
            string msg = "NULL";
            using (var c = listener.AcceptSocket())
            {
                byte[] buffer = new byte[1024];
                int iRx = c.Receive(buffer);
                char[] chars = new char[iRx];

                System.Text.Decoder d = System.Text.Encoding.ASCII.GetDecoder();
                int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
                msg = new System.String(chars);
                c.Send(System.Text.Encoding.ASCII.GetBytes("OK-R"));
                
            }
            listener.Stop();
            return msg;
        }
 
    }

}

