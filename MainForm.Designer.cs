namespace G_TicketPrinterService
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotifiBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuOptionsBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectPrinter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirDelServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTicketsImpresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aceraDeYeuDevelopLabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPantallaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarImpresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifiBarIcon
            // 
            this.NotifiBarIcon.BalloonTipText = "Sofware complementario iniciado";
            this.NotifiBarIcon.BalloonTipTitle = " YeuDevelop Labs(TM).";
            this.NotifiBarIcon.ContextMenuStrip = this.MenuOptionsBar;
            this.NotifiBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifiBarIcon.Icon")));
            this.NotifiBarIcon.Text = "Software de YeuDevelop Labs(TM)";
            this.NotifiBarIcon.Visible = true;
            // 
            // MenuOptionsBar
            // 
            this.MenuOptionsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelServidorToolStripMenuItem,
            this.verTicketsImpresosToolStripMenuItem,
            this.aceraDeYeuDevelopLabsToolStripMenuItem,
            this.verPantallaInicialToolStripMenuItem,
            this.cambiarImpresoraToolStripMenuItem,
            this.testModuleToolStripMenuItem});
            this.MenuOptionsBar.Name = "MenuOptionsBar";
            this.MenuOptionsBar.Size = new System.Drawing.Size(216, 158);
            this.MenuOptionsBar.Opening += new System.ComponentModel.CancelEventHandler(this.MenuOptionsBar_Opening);
            // 
            // SelectPrinter
            // 
            this.SelectPrinter.Name = "SelectPrinter";
            this.SelectPrinter.Size = new System.Drawing.Size(61, 4);
            this.SelectPrinter.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SelectPrinter_ItemClicked);
            // 
            // salirDelServidorToolStripMenuItem
            // 
            this.salirDelServidorToolStripMenuItem.Image = global::G_TicketPrinterService.Properties.Resources.rubber_duck_icon_icons_com_55299;
            this.salirDelServidorToolStripMenuItem.Name = "salirDelServidorToolStripMenuItem";
            this.salirDelServidorToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.salirDelServidorToolStripMenuItem.Text = "Salir del servidor";
            this.salirDelServidorToolStripMenuItem.Click += new System.EventHandler(this.salirDelServidorToolStripMenuItem_Click);
            // 
            // verTicketsImpresosToolStripMenuItem
            // 
            this.verTicketsImpresosToolStripMenuItem.Image = global::G_TicketPrinterService.Properties.Resources.Line_ui_icons_Svg_10_icon_icons_com_72171__1_;
            this.verTicketsImpresosToolStripMenuItem.Name = "verTicketsImpresosToolStripMenuItem";
            this.verTicketsImpresosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.verTicketsImpresosToolStripMenuItem.Text = "Ver Tickets Impresos";
            this.verTicketsImpresosToolStripMenuItem.Click += new System.EventHandler(this.verTicketsImpresosToolStripMenuItem_Click);
            // 
            // aceraDeYeuDevelopLabsToolStripMenuItem
            // 
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Image = global::G_TicketPrinterService.Properties.Resources.cashier_icon_icons_com_53629;
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Name = "aceraDeYeuDevelopLabsToolStripMenuItem";
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Text = "Acera de YeuDevelop Labs.";
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Click += new System.EventHandler(this.aceraDeYeuDevelopLabsToolStripMenuItem_Click);
            // 
            // verPantallaInicialToolStripMenuItem
            // 
            this.verPantallaInicialToolStripMenuItem.Image = global::G_TicketPrinterService.Properties.Resources.shoppaymentorderbuy_11_icon_icons_com_73850;
            this.verPantallaInicialToolStripMenuItem.Name = "verPantallaInicialToolStripMenuItem";
            this.verPantallaInicialToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.verPantallaInicialToolStripMenuItem.Text = "Ver pantalla inicial";
            this.verPantallaInicialToolStripMenuItem.Click += new System.EventHandler(this.verPantallaInicialToolStripMenuItem_Click);
            // 
            // cambiarImpresoraToolStripMenuItem
            // 
            this.cambiarImpresoraToolStripMenuItem.DropDown = this.SelectPrinter;
            this.cambiarImpresoraToolStripMenuItem.Image = global::G_TicketPrinterService.Properties.Resources.printer_6029;
            this.cambiarImpresoraToolStripMenuItem.Name = "cambiarImpresoraToolStripMenuItem";
            this.cambiarImpresoraToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cambiarImpresoraToolStripMenuItem.Text = "Cambiar Impresora";
            // 
            // testModuleToolStripMenuItem
            // 
            this.testModuleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testModuleToolStripMenuItem.Image")));
            this.testModuleToolStripMenuItem.Name = "testModuleToolStripMenuItem";
            this.testModuleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.testModuleToolStripMenuItem.Text = "TestModule";
            this.testModuleToolStripMenuItem.Click += new System.EventHandler(this.testModuleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 101);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "G PrintServer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuOptionsBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifiBarIcon;
        private System.Windows.Forms.ContextMenuStrip MenuOptionsBar;
        private System.Windows.Forms.ToolStripMenuItem salirDelServidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTicketsImpresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aceraDeYeuDevelopLabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPantallaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarImpresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip SelectPrinter;
    }
}

