namespace ControlncidenciesIsidre
{
    partial class FormRecuperarPass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRecuperarPass = new System.Windows.Forms.Button();
            this.labelMailRecuperacio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMailRecuperacio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonRecuperarPass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recuperar contrasenya";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introdueix el correu electrónic amb el cual\n et vas registrar. En breu rebras una" +
    "\nnova contrasenya provisional.";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(164, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonRecuperarPass
            // 
            this.buttonRecuperarPass.Location = new System.Drawing.Point(104, 173);
            this.buttonRecuperarPass.Name = "buttonRecuperarPass";
            this.buttonRecuperarPass.Size = new System.Drawing.Size(149, 31);
            this.buttonRecuperarPass.TabIndex = 0;
            this.buttonRecuperarPass.Text = "Envia nova contrasenya";
            this.buttonRecuperarPass.UseVisualStyleBackColor = true;
            // 
            // labelMailRecuperacio
            // 
            this.labelMailRecuperacio.AutoSize = true;
            this.labelMailRecuperacio.Location = new System.Drawing.Point(43, 123);
            this.labelMailRecuperacio.Name = "labelMailRecuperacio";
            this.labelMailRecuperacio.Size = new System.Drawing.Size(115, 13);
            this.labelMailRecuperacio.TabIndex = 3;
            this.labelMailRecuperacio.Text = "Correu de recuperació:";
            // 
            // FormRecuperarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRecuperarPass";
            this.Text = "Recuperar contrasenya";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRecuperarPass;
        private System.Windows.Forms.Label labelMailRecuperacio;
    }
}