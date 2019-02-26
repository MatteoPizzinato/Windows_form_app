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

namespace windows_form_app
{
    public partial class CustomLavorations : Form
    {
        public CustomLavorations()
        {
            InitializeComponent();
        }
        private void InsertNameCustomLavoration_TextChanged(object sender, EventArgs e)
        {
            
        }

        /* apro la connessione al DB */
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=ScatterpH8.41");
        MySqlCommand command;
        /* adesso creo delle funzioni per gestire l'apertura e la chiusura della connessione in base alle esigenze */
        public void openConnection() // con questa funzione apro la connessione se questa è chiusa 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection() // con questa funzione chiudo la connessione se questa è aperta
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeQuery(String query) // funzione che mi permette di creare una stringa per fare cose del database
        {
            try // provo ad aprire la connessione e generare un nuovo comando di query e di connessione 
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Query Executed");
                }else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch(Exception ex) // prendo l'eccezione e la mostro
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void SavingDataInMySQLDB_Click(object sender, EventArgs e)  
        {
            string query_saving_custom_lavoration = "USE lavorazioni_meccaniche; CREATE TABLE " + InsertNameCustomLavoration.Text + "(percent_1_phase int, percent_2_phase int, percent_3_phase int, percent_4_phase int, percent_5_phase int, percent_6_phase int, percent_7_phase int); INSERT INTO" + InsertNameCustomLavoration.Text + "VALUES ('" + CustPercFase1.Text +"','" + CustPercFase2.Text + "','" + CustPercFase3.Text + "','" + CustPercFase4.Text + "','" + CustPercFase5.Text + "','" + CustPercFase6.Text + "','" + CustPercFase7.Text + "')" ;
            executeQuery(query_saving_custom_lavoration);
        }   

        private void CustomLavorations_Load(object sender, EventArgs e)
        {

        }
    }
}
