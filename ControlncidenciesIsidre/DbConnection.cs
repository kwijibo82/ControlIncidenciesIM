using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add MySql Library
using MySql.Data.MySqlClient;
using MySql.Data.Entity;
using System.Windows.Forms;

namespace ControlncidenciesIsidre
{
    class DbConnection : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DbConnection()
        {
            Initialize();

        }


        //Initialize values
        private void Initialize()
        {
            server = "31.220.20.82";
            database = "u366900631_imi";
            uid = "u366900631_imi";
            password = "Excel$ior82!";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Database=" +
            database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            bool resul = false;
            try
            {
                connection.Open();
                resul = true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number) //TODO: Crear clase de control de excepciones
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        resul = false;
                        break;
                        
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        resul = false;
                        break;

                    case 1042:
                        MessageBox.Show("No se puede conectar al host especificado");
                        resul = false;
                        break;

                }
            }
            
            return resul;
        }

        //Close connection
        public bool CloseConnection()
        {
            bool resul = false;
            try
            {
                connection.Close();
                resul = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                resul = false;
            }

            return resul;
        }

       
        public void Insert(String dataAlta, String dataResolucio,
                           String nomProfe, String mail, String grup,
                            String descripcio, String equip)
        {

            bool resul = this.OpenConnection();
            //open connection
            if (resul)
            {
                //create command and assign the query and connection from the constructor
               // MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =  "INSERT INTO `Incidencies` (`data_alta`, `Equips_idEquip`," + 
              "`NomProfe`, `Mail`, `Grup`, `Classe`, `Descripcio`)" +
            "VALUES (@data_alta, @Equip_idEquip, @NomProfe, @Mail, @Grup, @Descripcio);";

                char splitValue = '/';
                string[] dataAltaToDate = dataAlta.Split(splitValue);

                StringBuilder sb = new StringBuilder();
                sb.Append(dataAltaToDate[2] + "/");
                sb.Append(dataAltaToDate[1] + "/");
                sb.Append(dataAltaToDate[0]);

                cmd.Parameters.AddWithValue("@data_alta", sb.ToString());
                cmd.Parameters.AddWithValue("@Equip_idEquip", equip);
                cmd.Parameters.AddWithValue("@nomProfe", nomProfe);
                cmd.Parameters.AddWithValue("@Mail", mail);
                cmd.Parameters.AddWithValue("@Grup", grup);
                cmd.Parameters.AddWithValue("@Descripcio", descripcio);

                try
                {
                     //Execute command
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }

                cmd.CommandText = "INSERT INTO `Equips`(`idEquip`, `Aula`)"
                + "VALUES (@idEquip, @Aula);";

                cmd.Parameters.AddWithValue("@idEquip", equip);
                cmd.Parameters.AddWithValue("@Aula", grup);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    //cierra conexión
                    this.CloseConnection();
                }
                MessageBox.Show("La incidència ha estat reportada correctament.\nRevisa el teu correu.", "Informació", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        public bool existeUsuario(String mail, String pass)
        {
             bool resulMethod = false;
             bool resul;

             //open connection
             if (resul = this.OpenConnection())
             {
                 MySqlCommand cmd = new MySqlCommand();

                 cmd.Connection = connection;

                 cmd.CommandText = "SELECT * FROM `Docents` WHERE `Mail` = @mail and `Password` = @pass";

                 //controla los problemas que da la query con la '@' del mail
                 String mailQuery = String.Format("{0}", mail);
                 String passQuery = String.Format("{0}", pass);

                 cmd.Parameters.AddWithValue("@mail", mailQuery);
                 cmd.Parameters.AddWithValue("@pass", pass);

                 String res = "";

                 try
                 {
                     MySqlDataReader reader = cmd.ExecuteReader();

                     while (reader.Read())
                     {
                         res = reader.GetString(0);
                         MessageBox.Show("Benvingut " + res);

                     }

                     if (res == "") //controla que la query devuelva algo o no
                     {
                         MessageBox.Show("Usuari o contrasenya erronis", "Atenció");
                         resulMethod = false;
                     }
                     else 
                     {
                         resulMethod = true;
                     }
                 }
                 catch (MySqlException ex)
                 {
                     MessageBox.Show(ex.StackTrace);
                 }
                 finally
                 {
                     this.CloseConnection();
                 }

             }

            return resulMethod;
        }

        public void insertDocent(String nom, String Cognom, String mail, String pass)
        {

            bool resul;
            if (resul = this.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = connection;

                    cmd.CommandText = "INSERT INTO `Docents`(`Nom`, `Cognom`, `Mail`, `Password`)" +
                        "VALUES (@Nom, @Cognom, @Mail, @Password)";

                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Cognom", Cognom);
                    cmd.Parameters.AddWithValue("@Mail", mail);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("El teu registre ha estat processat correctament",
                        "Informació",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (MySqlException ex)
                    {
                        switch (ex.Number)
                        {
                            case 1062:
                                MessageBox.Show("Aquest correu ja es troba registrat.",
                        "Atenció!",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    this.CloseConnection();
                }

            }
        
        }

        //Update statement
        /*public void Update()
        {
        }*/

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
       /* public List<string>[] Select()
        {
        } */

        //Count statement
      /*  public int Count()
        {
        }  */

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
