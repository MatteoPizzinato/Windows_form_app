﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace windows_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float[] percents_lavorations_LL = { 12, 9, 25, 36, 3, 5, 10}; // qui tengo in memoria le percentuali relative alle lavorazioni per ogni fase delle levaorazioni lenti
        float[] percents_lavorations_LF = { 14, 19, 2, 27, 9, 15, 14 }; // qui tengo in memoria le percentuali relative alle lavorazioni per ogni fase delle levaorazioni ferro
        float[] percents_lavorations_LP = { 17, 13, 7, 17, 19, 4, 23 }; // qui tengo in memoria le percentuali relative alle lavorazioni per ogni fase delle levaorazioni plastica

        public void CalculateHours_LL()
        {
            float value = 0;
            float.TryParse(oreMacchina.Text, out value); // parso la stringa in un float, lo faccio per poter fare i calcoli 
            var result_1 = (value * percents_lavorations_LL[0]) / 100; // risultato per le ore relative alla prima lavorazione
            Result1Fase.Text = Result1Fase.Text + result_1; // stampo il risultato nel label
            // adesso faccio i calcoli per seconda fase
            var result_2 = (value * percents_lavorations_LL[1]) / 100;
            Result2Fase.Text = Result2Fase.Text + result_2;
            // adesso faccio i calcoli per terza fase
            var result_3 = (value * percents_lavorations_LL[2]) / 100;
            Result3Fase.Text = Result3Fase.Text + result_3;
            // adesso faccio i calcoli per quarta fase
            var result_4 = (value * percents_lavorations_LL[3]) / 100;
            Result4Fase.Text = Result4Fase.Text + result_4;
            // adesso faccio i calcoli per quinta fase
            var result_5 = (value * percents_lavorations_LL[4]) / 100;
            Result5Fase.Text = Result5Fase.Text + result_5;
            // adesso faccio i calcoli per sesta fase
            var result_6 = (value * percents_lavorations_LL[5]) / 100;
            Result6Fase.Text = Result6Fase.Text + result_6;
            // adesso faccio i calcoli per sesta fase
            var result_7 = (value * percents_lavorations_LL[6]) / 100;
            Result7Fase.Text = Result7Fase.Text + result_7;
        }
        public void CalculateHours_LF()
        {
            float value = 0;
            float.TryParse(oreMacchina.Text, out value); // parso la stringa in un float, lo faccio per poter fare i calcoli 
            var result_1 = (value * percents_lavorations_LF[0]) / 100; // risultato per le ore relative alla prima lavorazione
            // MessageBox.Show("Le ore per la prima fase sono: " + result_1);
            Result1Fase.Text = Result1Fase.Text + result_1;
            // adesso faccio i calcoli per seconda fase
            var result_2 = (value * percents_lavorations_LF[1]) / 100;
            Result2Fase.Text = Result2Fase.Text + result_2;
            // adesso faccio i calcoli per terza fase
            var result_3 = (value * percents_lavorations_LF[2]) / 100;
            Result3Fase.Text = Result3Fase.Text + result_3;
            // adesso faccio i calcoli per quarta fase
            var result_4 = (value * percents_lavorations_LF[3]) / 100;
            Result4Fase.Text = Result4Fase.Text + result_4;
            // adesso faccio i calcoli per quinta fase
            var result_5 = (value * percents_lavorations_LF[4]) / 100;
            Result5Fase.Text = Result5Fase.Text + result_5;
            // adesso faccio i calcoli per sesta fase
            var result_6 = (value * percents_lavorations_LF[5]) / 100;
            Result6Fase.Text = Result6Fase.Text + result_6;
            // adesso faccio i calcoli per sesta fase
            var result_7 = (value * percents_lavorations_LF[6]) / 100;
            Result7Fase.Text = Result7Fase.Text + result_7;
        }
        public void CalculateHours_LP()
        {
            float value = 0;
            float.TryParse(oreMacchina.Text, out value); // parso la stringa in un float, lo faccio per poter fare i calcoli 
            var result_1 = (value * percents_lavorations_LP[0]) / 100; // risultato per le ore relative alla prima lavorazione
            // MessageBox.Show("Le ore per la prima fase sono: " + result_1);
            Result1Fase.Text = Result1Fase.Text + result_1;
            // adesso faccio i calcoli per seconda fase
            var result_2 = (value * percents_lavorations_LP[1]) / 100;
            Result2Fase.Text = Result2Fase.Text + result_2;
            // adesso faccio i calcoli per terza fase
            var result_3 = (value * percents_lavorations_LP[2]) / 100;
            Result3Fase.Text = Result3Fase.Text + result_3;
            // adesso faccio i calcoli per quarta fase
            var result_4 = (value * percents_lavorations_LP[3]) / 100;
            Result4Fase.Text = Result4Fase.Text + result_4;
            // adesso faccio i calcoli per quinta fase
            var result_5 = (value * percents_lavorations_LP[4]) / 100;
            Result5Fase.Text = Result5Fase.Text + result_5;
            // adesso faccio i calcoli per sesta fase
            var result_6 = (value * percents_lavorations_LP[5]) / 100;
            Result6Fase.Text = Result6Fase.Text + result_6;
            // adesso faccio i calcoli per sesta fase
            var result_7 = (value * percents_lavorations_LP[6]) / 100;
            Result7Fase.Text = Result7Fase.Text + result_7;
            // adesso faccio i calcoli per settima fase
        }
        public void Clear()
        {
            // voglio creare un metodo clear per eliminare i risultati in coda al label 
            Result1Fase.Text = "Le ore per la prima fase sono: ";
            Result2Fase.Text = "Le ore per la seconda fase sono: ";
            Result3Fase.Text = "Le ore per la terza fase sono: ";
            Result4Fase.Text = "Le ore per la quarta fase sono: ";
            Result5Fase.Text = "Le ore per la quinta fase sono: ";
            Result6Fase.Text = "Le ore per la sesta fase sono: ";
            Result7Fase.Text = "Le ore per la settima fase sono: ";
        }

        

        private void oreMacchina_TextChanged(object sender, EventArgs e)
        {
          // questo private void mi serve per 
        }

        private void calcolaOre_Click(object sender, EventArgs e)
        {
            /* per stampare un valore preso in input bisogna rischiamare direttamente la text box tramite
            il suo nome così verrà stampato il suo valore */
            if (LavorazioneLentiRadioButton.Checked == true)
            {
                CalculateHours_LL();
            }
            else if (LavorazioneFerroRadioButton.Checked == true)
            {
                CalculateHours_LF();
            }
            else if (LavorazionePlasticaRadioButton.Checked == true)
            {
                CalculateHours_LP();
            }
            else
            {
                MessageBox.Show("Prego selezionare la lavorazione");
            }

        }
        private void ShowValues_Click(object sender, EventArgs e)
        {
              // label con la scritta "Riusutati in ore" 
        }

        private void Result1Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result2Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result3Fase_Click(object sender, EventArgs e)
        {
              /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
              secondo le percentuali per ogni lavorazione */
        }

        private void Result4Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result5Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
             secondo le percentuali per ogni lavorazione */
        }

        private void Result6Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result7Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void ResetHours_Click(object sender, EventArgs e)
        {
            Clear();
            oreMacchina.Text = " "; // cancello automaticamente le ore inserite in precedenza
        }

        private void LavorazioneLentiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton che mi serve per selezionare la lavorazione lenti
            if (LavorazioneLentiRadioButton.Checked == true) 
            {
                Clear(); /* funzione che mi pulisce i risultati 
                            quando cambio lavorazione con il radio button */
            }
        }

        private void LavorazioneFerroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton che mi serve per selezionare la lavorazione ferro
            if (LavorazioneFerroRadioButton.Checked == true) 
            {
                Clear(); /* funzione che mi pulisce i risultati 
                            quando cambio lavorazione con il radio button */
            }
        }

        private void LavorazionePlasticaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton che mi serve per selezionare la lavorazione ferro
            if (LavorazionePlasticaRadioButton.Checked == true)
            {
                Clear(); /* funzione che mi pulisce i risultati 
                            quando cambio lavorazione con il radio button */
            }
        }

        private void CreateCustomLavorations_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            CustomLavorations createNewLavorations = new CustomLavorations();

            // Show the settings form
            createNewLavorations.Show();
        }

        // riapro la connessione al database, mi serve per vedere le lavorazioni customizzate disponibili 

        /* apro la connessione al DB */
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=ScatterpH8.41");
        MySqlCommand command;
        MySqlDataReader myReader; // proprietà o meglio funzione che permette di leggere un flusso di dati in sequenza
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
                }
                else
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
        void FillCombo()
        {
            
            string query_show_tables = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA='lavorazioni_meccaniche'";
            executeQuery(query_show_tables);

            while(myReader.Read())
            {
                string table_name = myReader.GetString("TABLE_NAME");
                ShowCustomLavorations.Items.Add(table_name);
            }
        }

       
        public void ShowCustomLavorations_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }
    }
}

