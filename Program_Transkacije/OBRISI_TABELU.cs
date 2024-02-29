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
    public partial class OBRISI_TABELU : UserControl
    {

        public static OBRISI_TABELU instance;
        public ComboBox cm1;
        public OBRISI_TABELU()
        {
            InitializeComponent();
            instance = this;
            cm1 = comboBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ime = comboBox1.Text;

            try
            {
                SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db");
                con.Open();

                string komanda = $"DROP TABLE '{ime}';";
                SQLiteCommand cmd = new SQLiteCommand(komanda, con);
                cmd.ExecuteNonQuery();   

                string komanda2 = $"DELETE FROM COMBO WHERE IME = '{ime}';";
                SQLiteCommand cmd2 = new SQLiteCommand(komanda2, con);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Tabela " + ime + " obrisana!");

            }
            catch (Exception eks)
            {
                MessageBox.Show("Morate izabrati tabelu za brisanje. ");
            }

            comboBox1.Text = "Izaberite tabelu";

            comboBox1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());

                }

            }
        }
    }
}
