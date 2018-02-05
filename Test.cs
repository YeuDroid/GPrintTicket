using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_TicketPrinterService
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tik = new Ticket();
            tik.ItemsVendidos = new List<Ticket.ItemVendido>();
            tik.ItemsVendidos.Add(new Ticket.ItemVendido("PESCADO",1,12));
            tik.ItemsVendidos.Add(new Ticket.ItemVendido("POLLO", 2, 5));

            MessageBox.Show(tik.GetStringRawFromThis());
            temprawJson = tik.GetStringRawFromThis();
        }
        String temprawJson;
        private void button2_Click(object sender, EventArgs e)
        {
            var tik = Newtonsoft.Json.JsonConvert.DeserializeObject<Ticket>(temprawJson);
            
        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrinterModule p = new PrinterModule();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SocketServer server = new SocketServer();
            server.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            var print = new PrinterModule();

            List<String> enc = new List<string>();
            List<String> encFinal = new List<string>();
            List<Ticket.ItemVendido> items = new List<Ticket.ItemVendido>();

            enc.Add("HOLA ENCABEZADO");
            enc.Add("CAJERO PRINCIPAL");
            enc.Add("SUC HIDALGO TAMPS");

            encFinal.Add("TIKET NUMOR 2344");
            encFinal.Add("VUELVA PRONTO");

            items.Add(new Ticket.ItemVendido("Pescado",1,12));
            items.Add(new Ticket.ItemVendido("Pollo", 5, 14));
            Ticket tik = new Ticket(enc,encFinal,items);
            tik.PagoCon = 100;
            tik.Cambio = 23;
            tik.IVA = 1;
            tik.Identifiquer = 266355353;
            tik.SubTotal = 99;

            Clipboard.SetText(Newtonsoft.Json.JsonConvert.SerializeObject(tik));
            print.PrintTicket(tik);

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double t = 2.1566567;
            MessageBox.Show(t.ToString("N2"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (TcpClient client = new TcpClient("192.168.1.85", 5555))
            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter w = new BinaryWriter(n);
                w.Write(System.Text.ASCIIEncoding.ASCII.GetBytes("HOLLO"));
                w.Flush();
                //Console.WriteLine(new BinaryReader(n).ReadString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var sendSock = new System.Net.Sockets.Socket(SocketType.Stream,ProtocolType.Tcp);
            using (TcpClient client = new TcpClient("192.168.1.75", 5555))
            {
                //client.Client.Send(System.Text.ASCIIEncoding.ASCII.GetBytes("HOLA MUNDO"));
                using (NetworkStream n = client.GetStream())
                {

                    BinaryWriter w = new BinaryWriter(n);
                    w.Write("C#");
                    w.Flush();
                    //Console.WriteLine(new BinaryReader(n).ReadString());
                }
            }
        }
    }
}
