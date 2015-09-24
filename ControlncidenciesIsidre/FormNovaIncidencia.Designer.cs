namespace ControlncidenciesIsidre
{
    partial class FormNovaIncidencia
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
            this.buttonSurt = new System.Windows.Forms.Button();
            this.buttonEnvia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxIncidencia = new System.Windows.Forms.GroupBox();
            this.textBoxEquip = new System.Windows.Forms.TextBox();
            this.labelEquip = new System.Windows.Forms.Label();
            this.labelObservacions = new System.Windows.Forms.Label();
            this.richTextBoxDescripcio = new System.Windows.Forms.RichTextBox();
            this.maskedTextBoxDadaIncidencia = new System.Windows.Forms.MaskedTextBox();
            this.textBoxGrup = new System.Windows.Forms.TextBox();
            this.labelNomProfessor = new System.Windows.Forms.Label();
            this.textBoxNomProfessor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelGrup = new System.Windows.Forms.Label();
            this.groupBoxIncidencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSurt
            // 
            this.buttonSurt.Location = new System.Drawing.Point(488, 368);
            this.buttonSurt.Name = "buttonSurt";
            this.buttonSurt.Size = new System.Drawing.Size(75, 23);
            this.buttonSurt.TabIndex = 13;
            this.buttonSurt.Text = "Surt";
            this.buttonSurt.UseVisualStyleBackColor = true;
            this.buttonSurt.Click += new System.EventHandler(this.buttonSurt_Click);
            // 
            // buttonEnvia
            // 
            this.buttonEnvia.Location = new System.Drawing.Point(375, 368);
            this.buttonEnvia.Name = "buttonEnvia";
            this.buttonEnvia.Size = new System.Drawing.Size(97, 23);
            this.buttonEnvia.TabIndex = 12;
            this.buttonEnvia.Text = "Envia Incidència";
            this.buttonEnvia.UseVisualStyleBackColor = true;
            this.buttonEnvia.Click += new System.EventHandler(this.buttonEnvia_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(13, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Neteja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxIncidencia
            // 
            this.groupBoxIncidencia.Controls.Add(this.textBoxEquip);
            this.groupBoxIncidencia.Controls.Add(this.labelEquip);
            this.groupBoxIncidencia.Controls.Add(this.labelObservacions);
            this.groupBoxIncidencia.Controls.Add(this.richTextBoxDescripcio);
            this.groupBoxIncidencia.Controls.Add(this.maskedTextBoxDadaIncidencia);
            this.groupBoxIncidencia.Controls.Add(this.textBoxGrup);
            this.groupBoxIncidencia.Controls.Add(this.labelNomProfessor);
            this.groupBoxIncidencia.Controls.Add(this.textBoxNomProfessor);
            this.groupBoxIncidencia.Controls.Add(this.label);
            this.groupBoxIncidencia.Controls.Add(this.labelGrup);
            this.groupBoxIncidencia.Location = new System.Drawing.Point(13, 8);
            this.groupBoxIncidencia.Name = "groupBoxIncidencia";
            this.groupBoxIncidencia.Size = new System.Drawing.Size(550, 349);
            this.groupBoxIncidencia.TabIndex = 10;
            this.groupBoxIncidencia.TabStop = false;
            this.groupBoxIncidencia.Text = "Dades Incidència";
            // 
            // textBoxEquip
            // 
            this.textBoxEquip.Location = new System.Drawing.Point(136, 115);
            this.textBoxEquip.Name = "textBoxEquip";
            this.textBoxEquip.Size = new System.Drawing.Size(79, 20);
            this.textBoxEquip.TabIndex = 12;
            // 
            // labelEquip
            // 
            this.labelEquip.AutoSize = true;
            this.labelEquip.Location = new System.Drawing.Point(20, 118);
            this.labelEquip.Name = "labelEquip";
            this.labelEquip.Size = new System.Drawing.Size(37, 13);
            this.labelEquip.TabIndex = 11;
            this.labelEquip.Text = "Equip:";
            // 
            // labelObservacions
            // 
            this.labelObservacions.AutoSize = true;
            this.labelObservacions.Location = new System.Drawing.Point(20, 155);
            this.labelObservacions.Name = "labelObservacions";
            this.labelObservacions.Size = new System.Drawing.Size(75, 13);
            this.labelObservacions.TabIndex = 10;
            this.labelObservacions.Text = "Observacions:";
            // 
            // richTextBoxDescripcio
            // 
            this.richTextBoxDescripcio.Location = new System.Drawing.Point(21, 181);
            this.richTextBoxDescripcio.Name = "richTextBoxDescripcio";
            this.richTextBoxDescripcio.Size = new System.Drawing.Size(377, 147);
            this.richTextBoxDescripcio.TabIndex = 9;
            this.richTextBoxDescripcio.Text = "";
            // 
            // maskedTextBoxDadaIncidencia
            // 
            this.maskedTextBoxDadaIncidencia.Location = new System.Drawing.Point(136, 52);
            this.maskedTextBoxDadaIncidencia.Mask = "00/00/0000";
            this.maskedTextBoxDadaIncidencia.Name = "maskedTextBoxDadaIncidencia";
            this.maskedTextBoxDadaIncidencia.Size = new System.Drawing.Size(79, 20);
            this.maskedTextBoxDadaIncidencia.TabIndex = 8;
            this.maskedTextBoxDadaIncidencia.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxGrup
            // 
            this.textBoxGrup.Location = new System.Drawing.Point(136, 83);
            this.textBoxGrup.Name = "textBoxGrup";
            this.textBoxGrup.Size = new System.Drawing.Size(79, 20);
            this.textBoxGrup.TabIndex = 6;
            // 
            // labelNomProfessor
            // 
            this.labelNomProfessor.AutoSize = true;
            this.labelNomProfessor.Location = new System.Drawing.Point(18, 26);
            this.labelNomProfessor.Name = "labelNomProfessor";
            this.labelNomProfessor.Size = new System.Drawing.Size(78, 13);
            this.labelNomProfessor.TabIndex = 1;
            this.labelNomProfessor.Text = "Nom professor:";
            // 
            // textBoxNomProfessor
            // 
            this.textBoxNomProfessor.Location = new System.Drawing.Point(137, 23);
            this.textBoxNomProfessor.Name = "textBoxNomProfessor";
            this.textBoxNomProfessor.Size = new System.Drawing.Size(133, 20);
            this.textBoxNomProfessor.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Dada incidència:";
            // 
            // labelGrup
            // 
            this.labelGrup.AutoSize = true;
            this.labelGrup.Location = new System.Drawing.Point(20, 85);
            this.labelGrup.Name = "labelGrup";
            this.labelGrup.Size = new System.Drawing.Size(33, 13);
            this.labelGrup.TabIndex = 3;
            this.labelGrup.Text = "Grup:";
            // 
            // FormNovaIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 401);
            this.Controls.Add(this.buttonSurt);
            this.Controls.Add(this.buttonEnvia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxIncidencia);
            this.Name = "FormNovaIncidencia";
            this.Text = "Nova incidència";
            this.groupBoxIncidencia.ResumeLayout(false);
            this.groupBoxIncidencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSurt;
        private System.Windows.Forms.Button buttonEnvia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxIncidencia;
        private System.Windows.Forms.TextBox textBoxEquip;
        private System.Windows.Forms.Label labelEquip;
        private System.Windows.Forms.Label labelObservacions;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDadaIncidencia;
        private System.Windows.Forms.TextBox textBoxGrup;
        private System.Windows.Forms.Label labelNomProfessor;
        private System.Windows.Forms.TextBox textBoxNomProfessor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelGrup;
    }
}