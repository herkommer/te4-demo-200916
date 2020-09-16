using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo200916A
{
    public partial class Form1 : Form
    {
        //Deklarera här om ni vill ha en variabel för HELA livslängden av Formuläret
        List<string> names = new List<string>();

        //Constructor, dvs denna metod körs vid new()
        public Form1()
        {
            //Metod, var ligger koden för metoden?
            //Jo, Microsoft har gömt den så vi inte ska bli förvirrade
            //hmm... gulligt...not!
            InitializeComponent();

            //NU är formuläret laddad och uppritat, redo att användas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Här hamnar vi när man klickar på knappen
            //MessageBox.Show("Test");

            //Läs in vad som står i textboxen
            //skriv ut det i labeln

            string s;
            s = textBox1.Text;

            label1.Text = $"Tjena {s}!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exempel på att använda en lista
            //List<string> names = new List<string>();
            names.Add("Arne");
            names.Add("Kalle");
            names.Add("Mimmi");

            label1.Text = names.Count.ToString();

            foreach (string item in names)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
