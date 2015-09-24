using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ControlncidenciesIsidre
{
    public partial class FormAltaNouDocent : Form
    {
        public FormAltaNouDocent()
        {
            InitializeComponent();
        }

        private void buttonAltaNouDocent_Click(object sender, EventArgs e)
        {
            DbConnection d = new DbConnection();
            d.insertDocent(textBoxNom.Text,
                textBoxCognom.Text,
                textBoxMail.Text, 
                textBoxPass.Text);

            MessageBox.Show("El nou docent ha estat registrat correctament.\n Nom: "
                + textBoxNom.Text + "\nCognom: "
                + textBoxCognom.Text + "\nEmail: "
                + textBoxMail.Text + "\nContrasenya: " 
                + textBoxPass.Text, "Informació", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

        }

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
