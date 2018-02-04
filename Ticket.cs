using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_TicketPrinterService
{
    class Ticket
    {
        public int Identifiquer { get; set; }
        public List<String> Encabezados { get; set; }
        public List<String> MensajeFinal { get; set; }
        public List<ItemVendido> ItemsVendidos { get; set; } 
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public double IVA { get; set; }
        public double PagoCon { get; set; }
        public double Cambio { get; set; }
        public Ticket()
        {

        }
        public Ticket(List<String> encabezados, List<String> MmsgFinal,List<ItemVendido> itemsVendidos)
        {
            this.Encabezados = encabezados;
            this.MensajeFinal = MmsgFinal;
            this.ItemsVendidos = itemsVendidos;
        }
        public static Ticket CreateTicketFromJSON(string jsonRaw)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Ticket>(jsonRaw);   
        }
        public String GetStringRawFromThis()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        public class ItemVendido
        {
            public ItemVendido()
            {

            }
            public ItemVendido(String producto, double cantidad, double precio)
            {
                this.Cantidad = cantidad;
                this.Precio = precio;
                this.Producto = producto;
            }
            public String Producto { get; set; }
            public double Cantidad { get; set; }
            public double Precio { get; set; }
        }

    }
}
