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

    public partial class initialSplash : Form
    {
        Boolean semaforo = false;
        public initialSplash()
        {
            InitializeComponent();
        }

        private void TimerDesvanecedor_Tick(object sender, EventArgs e)
        {
            this.label1.Text= this.Opacity.ToString();
            if(!semaforo)this.Opacity += 0.004;
            if ((this.Opacity >= 0.99) || semaforo)
            {
                semaforo = true;
                this.Opacity -= 0.0025;
                if (this.Opacity == 0) this.Dispose();
            }
        
        }

        private void initialSplash_Load(object sender, EventArgs e)
        {
            TimerDesvanecedor.Start();
        }

        private void initialSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
