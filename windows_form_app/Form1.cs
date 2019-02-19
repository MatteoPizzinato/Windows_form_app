using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace windows_form_app
{
    public partial class Form1 : Form
    {
        float[] percents_lavorations = {12, 9, 25, 36, 3, 5, 10}; // qui tengo in memoria le percentuali relative alle lavorazioni per ogni fase
        public void CalculateHours()
        {
            float value = 0;
            float.TryParse(oreMacchina.Text, out value); // parso la stringa in un float, lo faccio per poter fare i calcoli 
            var result_1 = (value * percents_lavorations[0]) / 100; // risultato per le ore relative alla prima lavorazione
            // MessageBox.Show("Le ore per la prima fase sono: " + result_1);
            Result1Fase.Text = Result1Fase.Text + result_1;
            // adesso faccio i calcoli per seconda fase
            var result_2 = (value * percents_lavorations[1]) / 100;
            Result2Fase.Text = Result2Fase.Text + result_2;
            // adesso faccio i calcoli per terza fase
            var result_3 = (value * percents_lavorations[2]) / 100;
            Result3Fase.Text = Result3Fase.Text + result_3;
            // adesso faccio i calcoli per quarta fase
            var result_4 = (value * percents_lavorations[3]) / 100;
            Result4Fase.Text = Result4Fase.Text + result_4;
            // adesso faccio i calcoli per quinta fase
            var result_5 = (value * percents_lavorations[4]) / 100;
            Result5Fase.Text = Result5Fase.Text + result_5;
            // adesso faccio i calcoli per sesta fase
            var result_6 = (value * percents_lavorations[5]) / 100;
            Result6Fase.Text = Result6Fase.Text + result_6;
            // adesso faccio i calcoli per sesta fase
            var result_7 = (value * percents_lavorations[6]) / 100;
            Result7Fase.Text = Result7Fase.Text + result_7;
        }
        public void Clear()
        {
            // voglio creare un metodo clear per eliminare i risultati in coda al label 
            Result1Fase.Text = "Le ore per la prima fase sono: ";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void oreMacchina_TextChanged(object sender, EventArgs e)
        {
            oreMacchina.SelectionStart = 0; // dovrebbe prendere in input una stringa
            oreMacchina.SelectionLength = 0; // calcola la lunghezza dell'imput
          
        }

        private void calcolaOre_Click(object sender, EventArgs e)
        {
            /* per stampare un valore preso in input bisogna rischiamare direttamente la text box tramite
            il suo nome così verrà stampato il suo valore */

            CalculateHours();


        }
        private void ShowValues_Click(object sender, EventArgs e)
        {
               
        }

        private void Result1Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result2Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result3Fase_Click(object sender, EventArgs e)
        {
              /* in questo label printo attraverso la funzione CalculateHours il valore delle ore
              secondo le percentuali per ogni lavorazione */
        }

        private void Result4Fase_Click(object sender, EventArgs e)
        {
             /* in questo label printo attraverso la funzione CalculateHours il valore delle ore
             secondo le percentuali per ogni lavorazione */
        }

        private void Result5Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours il valore delle ore
             secondo le percentuali per ogni lavorazione */
        }

        private void Result6Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result7Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void ResetHours_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

