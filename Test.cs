using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            print.PrintTicket(tik);

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double t = 2.1566567;
            MessageBox.Show(t.ToString("N2"));
        }
    }
}
