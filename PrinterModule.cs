using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace G_TicketPrinterService
{
    class PrinterModule
    {
        PrinterConfiguration Configuration;
        public PrinterModule()
        {
            this.Configuration = PrinterConfiguration.GetConfiguration();
        }
       
        public void PrintTicket(Ticket tik)
        {
            if (this.Configuration.PrinterName == "UNSELECTED")
            {
                var printDialog = new PrintDialog();
                printDialog.AllowPrintToFile = true;
                printDialog.AllowSelection = true;
                printDialog.AllowSomePages = true;
                printDialog.ShowNetwork = true;
                printDialog.ShowDialog();
                this.Configuration.PrinterName = printDialog.PrinterSettings.PrinterName;
                System.IO.File.WriteAllText("print_config.txt", JsonConvert.SerializeObject(this.Configuration));
            }

            var ticket = new LibPrintTicket.Ticket();
            foreach (var r in tik.Encabezados)
            {
                ticket.AddHeaderLine(r);
            }

            ticket.AddSubHeaderLine("Ticket #" + tik.Identifiquer);
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            foreach (var r in tik.ItemsVendidos)
            {
                ticket.AddItem(r.Cantidad.ToString(), r.Producto + "-($" + r.Precio.ToString("N2") + ")", (r.Cantidad * r.Precio).ToString("N2"));
            }

            ticket.AddTotal("SUBTOTAL", tik.SubTotal.ToString("N2"));
            if (tik.IVA == 0)
            {
                ticket.AddTotal("IVA", "INCLUIDO");
            }
            else { ticket.AddTotal("IVA",tik.IVA.ToString()); }

            ticket.AddTotal("TOTAL", tik.Total.ToString("N2"));
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", tik.PagoCon.ToString("N2"));
            ticket.AddTotal("CAMBIO", tik.Cambio.ToString("N2"));
            ticket.AddTotal("", "");

            foreach (var r in tik.MensajeFinal)
            {
                ticket.AddFooterLine(r);
            }

            ticket.PrintTicket(this.Configuration.PrinterName);

        } 
        public static List<String> getPrinterInstalled()
        {
            List<String> printersInstalled = new List<string>();
            foreach(var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                printersInstalled.Add(printer.ToString());
            }
            return printersInstalled;
        }
        public void ChangePrinter(string printname)
        {
            this.Configuration.PrinterName = printname;
            PrinterConfiguration.SaveConfigurationChanges(this.Configuration);
        }
    }
}
