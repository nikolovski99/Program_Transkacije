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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dugme_Click(object sender, EventArgs e)
        {
            DODAJ_TRANSAKCIJU.instance.cm1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DODAJ_TRANSAKCIJU.instance.cm1.Items.Add(reader[0].ToString());

                }

            }

            dodaJ_TRANSAKCIJU1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            novA_TABELA1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            STANJE.instance.cm1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    STANJE.instance.cm1.Items.Add(reader[0].ToString());

                }

            }

            stanje1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OBRISI_TABELU.instance.cm1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OBRISI_TABELU.instance.cm1.Items.Add(reader[0].ToString());

                }

            }

            obrisI_TABELU1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }
    }
}
