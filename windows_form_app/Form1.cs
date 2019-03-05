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
            FillCombo();                       
        }

        float[] percents_lavorations_LL = { 12, 9, 25, 36, 3, 5, 10 }; // qui tengo in memoria le percentuali relative alle lavorazioni per ogni fase delle levaorazioni lenti
        float[] percents_lavorations_LF = { 14, 19, 2, 27, 9, 15, 14 }; // qui tengo in memoria le percentuali relative alle lavorazioni per ogni fase delle levaorazioni ferro
        float[] percents_lavorations_LP = { 17, 13, 7, 17, 19, 4, 23 }; // qui tengo in memoria le percentuali relative alle lavorazioni per ogni fase delle levaorazioni plastica

        public void CalculateHours_LL()
        {
            float value = 0;
            float.TryParse(oreMacchina.Text, out value); // parso la stringa in un float, lo  faccio per poter fare i calcoli 
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
        //  Funzione Timer che pensavo fosse utile per refreshare i risulatati all'interno del DB 
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=ScatterpH8.41");
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
        public void refreshConnection() {

        Timer myTimer;
        myTimer = new Timer();
        myTimer.Tick += new EventHandler(refreshEveryXSecond);
        myTimer.Interval = 5000;
        myTimer.Start();

            void refreshEveryXSecond(object sender, EventArgs e)
            {
                openConnection();
                closeConnection();
            }
        }

        /* adesso creo delle funzioni per gestire l'apertura e la chiusura della connessione in base alle esigenze */
        void FillCombo() /* Ho creato due modi differenti per effettuare una connessione perchè così vedo i pro ed i contro dell'effettuare le connessioni in un determinato modo piuttosto che un altro, 
                            che alla fine non sono poi così molto diverse le due connesisoni usate */
        {
            // string connection_string = "datasource=localhost;port=3306;username=root;password=ScatterpH8.41";
            string query = "USE lavorazioni_meccaniche; SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA='lavorazioni_meccaniche';";
            // MySqlConnection connect_to_DB = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader myReader;

            try // provo ad eseguire il comando che dovrebbe ritornarmi il nome delle tabelle sul menù dropdown
            {
                openConnection();
                refreshConnection();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    string nameTable = myReader.GetString("TABLE_NAME");
                    ShowCustomLavorations.Items.Remove(nameTable);
                    ShowCustomLavorations.Items.Add(nameTable);

                }
            }
            catch (Exception ex) // e se c'è un eccezione la prendo e la mostro
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();              
            }
        }
        public void ShowCustomLavorations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // serve per far funzionare il dropdwon menu                                    
        }
        
        public void refreshingConnection_Click(object sender, EventArgs e)
        {            
           // FillCombo();            
        }
    }
}

