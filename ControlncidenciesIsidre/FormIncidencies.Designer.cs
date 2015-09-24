namespace ControlncidenciesIsidre
{
    partial class FormIncidencies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncidencies));
            this.groupBoxDarreresIncidencies = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSortir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novaIncidencia = new System.Windows.Forms.ToolStripButton();
            this.Editar = new System.Windows.Forms.ToolStripButton();
            this.EsborrarIncidencia = new System.Windows.Forms.ToolStripButton();
            this.u366900631_imiDataSet1 = new ControlncidenciesIsidre.u366900631_imiDataSet1();
            this.incidenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciesTableAdapter = new ControlncidenciesIsidre.u366900631_imiDataSet1TableAdapters.IncidenciesTableAdapter();
            this.nomProfeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDarreresIncidencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u366900631_imiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDarreresIncidencies
            // 
            this.groupBoxDarreresIncidencies.Controls.Add(this.dataGridView1);
            this.groupBoxDarreresIncidencies.Location = new System.Drawing.Point(12, 37);
            this.groupBoxDarreresIncidencies.Name = "groupBoxDarreresIncidencies";
            this.groupBoxDarreresIncidencies.Size = new System.Drawing.Size(478, 258);
            this.groupBoxDarreresIncidencies.TabIndex = 0;
            this.groupBoxDarreresIncidencies.TabStop = false;
            this.groupBoxDarreresIncidencies.Text = "Darreres incidencies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomProfeDataGridViewTextBoxColumn,
            this.dataaltaDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.grupDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.descripcioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidenciesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSortir
            // 
            this.buttonSortir.Location = new System.Drawing.Point(397, 320);
            this.buttonSortir.Name = "buttonSortir";
            this.buttonSortir.Size = new System.Drawing.Size(75, 23);
            this.buttonSortir.TabIndex = 1;
            this.buttonSortir.Text = "Sortir";
            this.buttonSortir.UseVisualStyleBackColor = true;
            this.buttonSortir.Click += new System.EventHandler(this.buttonSortir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIncidencia,
            this.Editar,
            this.EsborrarIncidencia});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novaIncidencia
            // 
            this.novaIncidencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novaIncidencia.Image = ((System.Drawing.Image)(resources.GetObject("novaIncidencia.Image")));
            this.novaIncidencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novaIncidencia.Name = "novaIncidencia";
            this.novaIncidencia.Size = new System.Drawing.Size(23, 22);
            this.novaIncidencia.Text = "toolStripButton1";
            this.novaIncidencia.ToolTipText = "Nova incidencia";
            // 
            // Editar
            // 
            this.Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(23, 22);
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Editar incidència";
            // 
            // EsborrarIncidencia
            // 
            this.EsborrarIncidencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EsborrarIncidencia.Image = ((System.Drawing.Image)(resources.GetObject("EsborrarIncidencia.Image")));
            this.EsborrarIncidencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EsborrarIncidencia.Name = "EsborrarIncidencia";
            this.EsborrarIncidencia.Size = new System.Drawing.Size(23, 22);
            this.EsborrarIncidencia.Text = "EsborrarIncidencia";
            this.EsborrarIncidencia.ToolTipText = "Esborrar incidencia";
            // 
            // u366900631_imiDataSet1
            // 
            this.u366900631_imiDataSet1.DataSetName = "u366900631_imiDataSet1";
            this.u366900631_imiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenciesBindingSource
            // 
            this.incidenciesBindingSource.DataMember = "Incidencies";
            this.incidenciesBindingSource.DataSource = this.u366900631_imiDataSet1;
            // 
            // incidenciesTableAdapter
            // 
            this.incidenciesTableAdapter.ClearBeforeFill = true;
            // 
            // nomProfeDataGridViewTextBoxColumn
            // 
            this.nomProfeDataGridViewTextBoxColumn.DataPropertyName = "NomProfe";
            this.nomProfeDataGridViewTextBoxColumn.HeaderText = "NomProfe";
            this.nomProfeDataGridViewTextBoxColumn.Name = "nomProfeDataGridViewTextBoxColumn";
            // 
            // dataaltaDataGridViewTextBoxColumn
            // 
            this.dataaltaDataGridViewTextBoxColumn.DataPropertyName = "data_alta";
            this.dataaltaDataGridViewTextBoxColumn.HeaderText = "data_alta";
            this.dataaltaDataGridViewTextBoxColumn.Name = "dataaltaDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // grupDataGridViewTextBoxColumn
            // 
            this.grupDataGridViewTextBoxColumn.DataPropertyName = "Grup";
            this.grupDataGridViewTextBoxColumn.HeaderText = "Grup";
            this.grupDataGridViewTextBoxColumn.Name = "grupDataGridViewTextBoxColumn";
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            // 
            // descripcioDataGridViewTextBoxColumn
            // 
            this.descripcioDataGridViewTextBoxColumn.DataPropertyName = "Descripcio";
            this.descripcioDataGridViewTextBoxColumn.HeaderText = "Descripcio";
            this.descripcioDataGridViewTextBoxColumn.Name = "descripcioDataGridViewTextBoxColumn";
            // 
            // FormIncidencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 366);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonSortir);
            this.Controls.Add(this.groupBoxDarreresIncidencies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormIncidencies";
            this.Text = "Form Incidencies";
            this.Load += new System.EventHandler(this.FormIncidencies_Load);
            this.groupBoxDarreresIncidencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u366900631_imiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDarreresIncidencies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSortir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novaIncidencia;
        private System.Windows.Forms.ToolStripButton Editar;
        private System.Windows.Forms.ToolStripButton EsborrarIncidencia;
        private u366900631_imiDataSet1 u366900631_imiDataSet1;
        private System.Windows.Forms.BindingSource incidenciesBindingSource;
        private u366900631_imiDataSet1TableAdapters.IncidenciesTableAdapter incidenciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProfeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioDataGridViewTextBoxColumn;
    }
}