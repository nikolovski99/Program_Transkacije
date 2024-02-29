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
    public partial class NOVA_TABELA : UserControl
    {

        public static NOVA_TABELA instance;
        public NOVA_TABELA()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String ime = ime_nova.Text.ToUpper();

            if (ime == "UKUCAJTE IME NOVE TABELE")
            {
                MessageBox.Show("Morate popuniti polje. ");
            } else
            {



                try
                {
                    SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db");
                    con.Open();

                    string komanda = $"CREATE TABLE '{ime}' ('ID' INTEGER,'NAZIV' TEXT,'DATUM' TEXT,'IZNOS' TEXT,'OPIS' TEXT,PRIMARY KEY('ID' AUTOINCREMENT));";
                    SQLiteCommand cmd = new SQLiteCommand(komanda, con);
                    cmd.ExecuteNonQuery();

                    string add = $"insert into COMBO (IME) VALUES ('{ime}');";
                    SQLiteCommand cmd2 = new SQLiteCommand(add, con);
                    cmd2.ExecuteNonQuery();


                    con.Close();

                    MessageBox.Show("Dodata nova tabela " + ime + " !");

                } catch (Exception eks)
                {
                    MessageBox.Show("Tabela sa ovim imenom vec postoji. ");
                }
            }

            ime_nova.Text = "Ukucajte ime nove tabele";
            ime_nova.ForeColor = Color.DimGray;


        }

        private void ime_nova_Enter(object sender, EventArgs e)
        {
            if (ime_nova.Text == "Ukucajte ime nove tabele")
            {
                ime_nova.Text = null;
                ime_nova.ForeColor = Color.Black;
            }
            
        }

        private void ime_nova_Leave(object sender, EventArgs e)
        {
            if (ime_nova.Text == "")
            {
                ime_nova.Text = "Ukucajte ime nove tabele";
                ime_nova.ForeColor = Color.DimGray;
            }
        }
    }
}
