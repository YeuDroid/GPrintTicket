using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_TicketPrinterService
{
    public partial class MainForm : Form
    {
        public static LiteDB.LiteDatabase db = new LiteDB.LiteDatabase("configuration.txt");
        public MainForm()
        {
            InitializeComponent();
            //start splash intrid
            new initialSplash().Show();

            //Start Server
         //   SocketServer server = new SocketServer();
           // server.Start();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            NotifiBarIcon.ShowBalloonTip(0);
        }
        private void salirDelServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void verPantallaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new initialSplash().ShowDialog();
        }
        private void aceraDeYeuDevelopLabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new acerca_de().ShowDialog();
        }
        private void verTicketsImpresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ver_impresion_t().ShowDialog();
        }
        private void testModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Test().ShowDialog();
        }
    }
}
