using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlncidenciesIsidre
{
    public partial class FormularioPrincipal : Form
    {
        bool conectado;
        public static String emailUsuari;

        public FormularioPrincipal()
        {
            InitializeComponent();
            conectado = false;
        }


        private void groupBoxIncidencia_Enter(object sender, EventArgs e)
        {

        }

        private void incidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormIncidencies fi = new FormIncidencies();
            fi.Show();
        }

        private void buttonEnvia_Click(object sender, EventArgs e)
        {


        }

        private void novaIncidènciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaIncidencia fni = new FormNovaIncidencia();
            fni.ShowDialog();
        }

        private void altaNouDocentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaNouDocent fand = new FormAltaNouDocent();
            fand.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DbConnection d = new DbConnection();
            if (!conectado)
            {
                if (d.existeUsuario(textBoxUsuari.Text, textBoxPassword.Text))
                {
                    labelStatus.Text = "Online";
                    pictureBox1.Image = imageListStatus.Images[1];

                    //enable menu items
                    toolStripMenuItemControlncidencies.Enabled = true;
                    novaIncidènciaToolStripMenuItem.Enabled = true;
                    emailUsuari = textBoxUsuari.Text;
                    buttonConnectaDesconecta.Text = "Desconnecta";
                    conectado = true;
                }                
                
            }
            else if (conectado)
            {
                labelStatus.Text = "Offline";
                
                pictureBox1.Image = imageListStatus.Images[0];
                conectado = false;
                buttonConnectaDesconecta.Text = "Ingresa";                
            }
        }

        public static string getEmailUsuari()
        {
            return emailUsuari;
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void surtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Realment dessitjes sortir?", "Atenció!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                this.Close(); 
            }
            
            
        }

        private void recuperarContrasenyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecuperarPass frp = new FormRecuperarPass();
            frp.ShowDialog();
        }
    }
}
