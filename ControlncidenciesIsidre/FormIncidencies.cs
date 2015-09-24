using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Add MySql Library
using MySql.Data.MySqlClient;


namespace ControlncidenciesIsidre
{
    public partial class FormIncidencies : Form
    {
        public FormIncidencies()
        {
            InitializeComponent();
        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIncidencies_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'u366900631_imiDataSet1.Incidencies' Puede moverse o quitarse según sea necesario.
            this.incidenciesTableAdapter.Fill(this.u366900631_imiDataSet1.Incidencies);

            incidenciesBindingSource.RemoveFilter();
            incidenciesBindingSource.Filter = string.Format("Mail LIKE '*{0}*'", FormularioPrincipal.getEmailUsuari());

        }
    }
}
