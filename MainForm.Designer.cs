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
            this.salirDelServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTicketsImpresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aceraDeYeuDevelopLabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPantallaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.testModuleToolStripMenuItem});
            this.MenuOptionsBar.Name = "MenuOptionsBar";
            this.MenuOptionsBar.Size = new System.Drawing.Size(216, 114);
            // 
            // salirDelServidorToolStripMenuItem
            // 
            this.salirDelServidorToolStripMenuItem.Name = "salirDelServidorToolStripMenuItem";
            this.salirDelServidorToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.salirDelServidorToolStripMenuItem.Text = "Salir del servidor";
            this.salirDelServidorToolStripMenuItem.Click += new System.EventHandler(this.salirDelServidorToolStripMenuItem_Click);
            // 
            // verTicketsImpresosToolStripMenuItem
            // 
            this.verTicketsImpresosToolStripMenuItem.Name = "verTicketsImpresosToolStripMenuItem";
            this.verTicketsImpresosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.verTicketsImpresosToolStripMenuItem.Text = "Ver Tickets Impresos";
            this.verTicketsImpresosToolStripMenuItem.Click += new System.EventHandler(this.verTicketsImpresosToolStripMenuItem_Click);
            // 
            // aceraDeYeuDevelopLabsToolStripMenuItem
            // 
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Name = "aceraDeYeuDevelopLabsToolStripMenuItem";
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Text = "Acera de YeuDevelop Labs.";
            this.aceraDeYeuDevelopLabsToolStripMenuItem.Click += new System.EventHandler(this.aceraDeYeuDevelopLabsToolStripMenuItem_Click);
            // 
            // verPantallaInicialToolStripMenuItem
            // 
            this.verPantallaInicialToolStripMenuItem.Name = "verPantallaInicialToolStripMenuItem";
            this.verPantallaInicialToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.verPantallaInicialToolStripMenuItem.Text = "Ver pantalla inicial";
            this.verPantallaInicialToolStripMenuItem.Click += new System.EventHandler(this.verPantallaInicialToolStripMenuItem_Click);
            // 
            // testModuleToolStripMenuItem
            // 
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
    }
}

