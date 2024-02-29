using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Program_Transkacije
{
    public partial class DODAJ_TRANSAKCIJU : UserControl
    {
        public static DODAJ_TRANSAKCIJU instance;
        public ComboBox cm1;


        public DODAJ_TRANSAKCIJU()
        {
            InitializeComponent();
            instance = this;
            cm1 = comboBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                String ime_racuna = comboBox1.Text;
                String datum = pravi_datum.Value.ToString("dd/MM/yyyy");
                String iznos = novac.Text;
                String opis1 = opis.Text;

                if (ime_racuna.Length == 0 || datum.Length == 0 || iznos.Length == 0)
                {
                    MessageBox.Show("Nisu popunjena sva polja! ");
                }
                else
                {
                    try
                    {
                        iznos = iznos.Replace('.', ',');
                        double novi_iznos = Convert.ToDouble(iznos);

                        Console.WriteLine(iznos);


                        string add = $"insert into '{ime_racuna}' (ID,NAZIV,DATUM,IZNOS,OPIS) VALUES (NULL,'{ime_racuna}','{datum}','{novi_iznos}','{opis1}');";

                        SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db");
                        con.Open();

                        SQLiteCommand cmd = new SQLiteCommand(add, con);

                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Transakcija " + ime_racuna + " u iznosu od " + iznos + " dinara ubačena. ");

                    }
                    catch (Exception eks)
                    {
                        MessageBox.Show("Iznos mora biti broj! ");
                    }


                }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pravi_datum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void novac_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
