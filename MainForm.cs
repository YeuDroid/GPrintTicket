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
            SocketServer server = new SocketServer();
            server.Start();


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
        private void SelectPrinter_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var config = PrinterConfiguration.GetConfiguration();
            config.PrinterName = e.ClickedItem.Text;
            PrinterConfiguration.SaveConfigurationChanges(config);
        }

        private void MenuOptionsBar_Opening(object sender, CancelEventArgs e)
        {
            this.SelectPrinter.Items.Clear();
            Image img = global::G_TicketPrinterService.Properties.Resources.printer_6029;
            Image imgSelected = global::G_TicketPrinterService.Properties.Resources.Alarm_Tick_icon;

            var config = PrinterConfiguration.GetConfiguration();
            foreach (var printer in PrinterModule.getPrinterInstalled())
            {
                if (printer == config.PrinterName)
                {
                    this.SelectPrinter.Items.Add(printer, imgSelected);
                }
                else
                { this.SelectPrinter.Items.Add(printer, img); }

            }
            this.SelectPrinter.Items.Add("UNSELECTED", img);
        }
    }
}
