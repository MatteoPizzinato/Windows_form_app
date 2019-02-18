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
            MessageBox.Show("Le ore per la prima fase sono: " + result_1);
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

    }
}
