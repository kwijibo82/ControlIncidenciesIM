using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.Net;

using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

namespace ControlncidenciesIsidre
{
    public partial class FormNovaIncidencia : Form
    {
        public FormNovaIncidencia()
        {
            InitializeComponent();
        }

        private void buttonEnvia_Click(object sender, EventArgs e)
        {

            String mail = FormularioPrincipal.getEmailUsuari();

            DbConnection d = new DbConnection();

            d.Insert(maskedTextBoxDadaIncidencia.Text, "", //TODO: Set or modify date baja incidencia
                textBoxNomProfessor.Text,
                mail,
                textBoxGrup.Text,
                richTextBoxDescripcio.Text,
                textBoxEquip.Text);

            enviaMail();



        }

        public void enviaMail()
        {
            string mailTo = FormularioPrincipal.getEmailUsuari();

            MailMessage mail = new MailMessage();
            mail.To.Add(mailTo);
            mail.To.Add("xamorach@gmail.com");
            mail.From = new MailAddress("incidencies.informatiques.im@gmail.com");
            mail.Subject = "Incidencia informàtica equip: " + textBoxEquip.Text;

            string Body = "La teva incidència ha estat rebuda i aviat serà atessa.\n" +
                          "Equip: " + textBoxEquip.Text + "\n" +
                          "Professor: " + textBoxNomProfessor.Text + "\n" +
                          "Motiu: " + richTextBoxDescripcio.Text;
                          
            mail.Body = Body;

            SmtpClient sc = new SmtpClient("smtp.gmail.com");
            NetworkCredential nc = new NetworkCredential("incidencies.informatiques.im", "Genesis1982!");
            sc.UseDefaultCredentials = false;
            sc.Credentials = nc;
            sc.EnableSsl = true;
            sc.Port = 587;
            try
            {
                sc.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSurt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBoxEquip.Text = "";
            this.textBoxGrup.Text = "";
            this.textBoxNomProfessor.Text = "";
            this.richTextBoxDescripcio.Text = "";
            this.maskedTextBoxDadaIncidencia.Text = "";
            
        }

    }
}
