namespace ControlncidenciesIsidre
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaIncidènciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemControlncidencies = new System.Windows.Forms.ToolStripMenuItem();
            this.docentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNouDocentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.recuperarContrasenyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonConnectaDesconecta = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuari = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageListStatus = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.incidenciasToolStripMenuItem,
            this.docentsToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIncidènciaToolStripMenuItem,
            this.surtToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // novaIncidènciaToolStripMenuItem
            // 
            this.novaIncidènciaToolStripMenuItem.Enabled = false;
            this.novaIncidènciaToolStripMenuItem.Name = "novaIncidènciaToolStripMenuItem";
            this.novaIncidènciaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.novaIncidènciaToolStripMenuItem.Text = "Nova incidència";
            this.novaIncidènciaToolStripMenuItem.Click += new System.EventHandler(this.novaIncidènciaToolStripMenuItem_Click);
            // 
            // surtToolStripMenuItem
            // 
            this.surtToolStripMenuItem.Name = "surtToolStripMenuItem";
            this.surtToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.surtToolStripMenuItem.Text = "Surt";
            this.surtToolStripMenuItem.Click += new System.EventHandler(this.surtToolStripMenuItem_Click);
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemControlncidencies});
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.incidenciasToolStripMenuItem.Text = "&Incidències";
            this.incidenciasToolStripMenuItem.Click += new System.EventHandler(this.incidenciasToolStripMenuItem_Click);
            // 
            // toolStripMenuItemControlncidencies
            // 
            this.toolStripMenuItemControlncidencies.Enabled = false;
            this.toolStripMenuItemControlncidencies.Name = "toolStripMenuItemControlncidencies";
            this.toolStripMenuItemControlncidencies.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemControlncidencies.Text = "Control incidències";
            this.toolStripMenuItemControlncidencies.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // docentsToolStripMenuItem
            // 
            this.docentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaNouDocentToolStripMenuItem,
            this.toolStripMenuItem2,
            this.recuperarContrasenyaToolStripMenuItem});
            this.docentsToolStripMenuItem.Name = "docentsToolStripMenuItem";
            this.docentsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.docentsToolStripMenuItem.Text = "Docents";
            // 
            // altaNouDocentToolStripMenuItem
            // 
            this.altaNouDocentToolStripMenuItem.Name = "altaNouDocentToolStripMenuItem";
            this.altaNouDocentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.altaNouDocentToolStripMenuItem.Text = "Alta nou docent";
            this.altaNouDocentToolStripMenuItem.Click += new System.EventHandler(this.altaNouDocentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // recuperarContrasenyaToolStripMenuItem
            // 
            this.recuperarContrasenyaToolStripMenuItem.Name = "recuperarContrasenyaToolStripMenuItem";
            this.recuperarContrasenyaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recuperarContrasenyaToolStripMenuItem.Text = "Recuperar contrasenya";
            this.recuperarContrasenyaToolStripMenuItem.Click += new System.EventHandler(this.recuperarContrasenyaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ayudaToolStripMenuItem.Text = "Ajuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(132, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // buttonConnectaDesconecta
            // 
            this.buttonConnectaDesconecta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonConnectaDesconecta.ForeColor = System.Drawing.Color.Red;
            this.buttonConnectaDesconecta.Location = new System.Drawing.Point(476, 27);
            this.buttonConnectaDesconecta.Name = "buttonConnectaDesconecta";
            this.buttonConnectaDesconecta.Size = new System.Drawing.Size(92, 26);
            this.buttonConnectaDesconecta.TabIndex = 3;
            this.buttonConnectaDesconecta.Text = "Ingresa";
            this.buttonConnectaDesconecta.UseVisualStyleBackColor = false;
            this.buttonConnectaDesconecta.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(365, 31);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contrasenya:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuari:";
            // 
            // textBoxUsuari
            // 
            this.textBoxUsuari.Location = new System.Drawing.Point(188, 31);
            this.textBoxUsuari.Name = "textBoxUsuari";
            this.textBoxUsuari.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuari.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(27, 34);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Offline";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // imageListStatus
            // 
            this.imageListStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatus.ImageStream")));
            this.imageListStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatus.Images.SetKeyName(0, "offline.png");
            this.imageListStatus.Images.SetKeyName(1, "online.png");
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsuari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonConnectaDesconecta);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Control Incidencies Informàtiques Isidre Marti  v1.1.0";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemControlncidencies;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaIncidènciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNouDocentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarContrasenyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Button buttonConnectaDesconecta;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageListStatus;
        public System.Windows.Forms.TextBox textBoxUsuari;
    }
}

