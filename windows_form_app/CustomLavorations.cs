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
            Application.EnableVisualStyles();
        }

        /*
            inizio private void per far funzionare le textBox
        */

        private void InsertNameCustomLavoration_TextChanged(object sender, EventArgs e)
        {

        }
        private void CustPercFase1_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase2_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase3_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase4_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase5_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase6_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase7_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }

        /*
            fine private void per far funzionare le textBox
        */

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
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                } else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex) // prendo l'eccezione e la mostro
            {   
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }  
            
        }

        public void SavingDataInMySQLDB_Click(object sender, EventArgs e)
        {

            string query_saving_custom_lavoration = "USE lavorazioni_meccaniche; CREATE TABLE " + InsertNameCustomLavoration.Text + "(percentPhase1 INT, percentPhase2 INT, percentPhase3 INT, percentPhase4 INT, percentPhase5 INT, percentPhase6 INT, percentPhase7 INT); INSERT INTO lavorazioni_meccaniche." + InsertNameCustomLavoration.Text + " VALUES('" + CustPercFase1.Text + "','" + CustPercFase2.Text + "','" + CustPercFase3.Text + "','" + CustPercFase4.Text + "','" + CustPercFase5.Text + "','" + CustPercFase6.Text + "','" + CustPercFase7.Text + "')";
            executeQuery(query_saving_custom_lavoration);
            InsertNameCustomLavoration.Text = " ";            
        }

        private void CustomLavorations_Load(object sender, EventArgs e)
        {
            // serve per far funzionare il custom load
        }
        /* cerco di creare un refresh ogni volta che viene premuto il pulsante save nella schermata di inserimento dati nel db */
        public void SumPercCustLav() // sum of the percent of every phase of a custom lavoration
        {
            int x = 100;
            int result = int.Parse(CustPercFase1.Text) + int.Parse(CustPercFase2.Text) + int.Parse(CustPercFase3.Text) + int.Parse(CustPercFase4.Text) + int.Parse(CustPercFase5.Text) + int.Parse(CustPercFase6.Text) + int.Parse(CustPercFase7.Text);
            DisplaySumPercent.Text = result.ToString();

            if (x != result)
            {
                SavingDataInMySQLDB.Enabled = false; // if the sum of my phases of the lavoration isn't 100 I block the save button       
                Color TextColor = Color.Red; /* DA FINIRE LA VISUALIZZAZIONE DI UN RISULTATO DIVERSO DA 100 IN ROSSO, TROVA IL MODO DI FARLO DINAMICO SENZA UN BUTTON IN CHECK */           
                TextColor.ToString(result);
                
            }
            else if(x == result)
            {
                SavingDataInMySQLDB.Enabled = true; // else the user have the permission of clicking the saving button
            }
        }       
        private void CheckSumPercent_Click(object sender, EventArgs e)
        {
            SumPercCustLav();
        }

        private void DisplaySumPercent_Click(object sender, EventArgs e)
        {
            // show the result of the sum of the all phases in a custom lavoration
        }
    }
}
