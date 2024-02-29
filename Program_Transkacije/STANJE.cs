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
    public partial class STANJE : UserControl
    {

        public static STANJE instance;
        public ComboBox cm1;
        public STANJE()
        {
            InitializeComponent();
            instance = this;
            cm1 = comboBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ukupno = 0;
            double zaduzio = 0;
            double platio = 0;

            String ime = comboBox1.Text;
            List<Transkacija> lista = new List<Transkacija>();

            try
            {

            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "RACUN";
            dataGridView1.Columns[2].Name = "DATUM";
            dataGridView1.Columns[3].Name = "IZNOS";
            dataGridView1.Columns[4].Name = "OPIS";
                using (SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from '" + ime + "';", con);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            String cena = reader[3].ToString();
                            if (Convert.ToDouble(cena) < 0)
                            {
                                zaduzio = zaduzio + Convert.ToDouble(cena);

                            } else
                            {
                                platio = platio + Convert.ToDouble(cena);
                            }
                            ukupno = zaduzio + platio;
                        }
                        catch (Exception eks)
                        {
                            Console.WriteLine("Cena nije broj" + eks);
                        }

                        String datum = reader[2].ToString();
                        String[] delovi = datum.Split('.');

                        Transkacija t = new Transkacija(reader[0].ToString(), reader[1].ToString(), new DateTime(Convert.ToInt32(delovi[2]), Convert.ToInt32(delovi[1]), Convert.ToInt32(delovi[0])), reader[3].ToString(), reader[4].ToString());
                        lista.Add(t);

                }

                    var persons = from p in lista
                                    orderby p.Datum
                                    select p;
                    persons.ToList().ForEach(p => dataGridView1.Rows.Add(new string[] { p.getID(), p.getNaziv(), p.getDatum().ToString("dd/MM/yyyy"), p.getIznos(), p.getOpis() }));
                

                    label2.Text = ukupno.ToString("0.##");
                    label3.Text = zaduzio.ToString();
                    label5.Text = platio.ToString();
                }

            } catch (Exception ek)
            {
                MessageBox.Show("Morate izabrati tabelu za prikaz");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String ime = comboBox1.Text;
            List<Transkacija> lista = new List<Transkacija>();

            if (id.Length == 0 || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Morate popuniti polja za ID i ime racuna! ");
            }
            else
            {
                if (dataGridView1.Rows[0].Cells[1].Value.ToString() != ime)
                {                   
                    MessageBox.Show("Niste kliknuli dugme prikazi. Trenutna tabela ne odgovara datom imenu racuna.");
                }
                else
                {

                    try
                    {
                        double broj = Convert.ToDouble(id);
                        double ukupno = 0;
                        double zaduzio = 0;
                        double platio = 0;

                        SQLiteConnection con = new SQLiteConnection(@"URI=file:baza_podataka.db");
                        con.Open();

                        SQLiteCommand cmd = new SQLiteCommand("delete from '" + ime + "' where ID ='" + id + "'", con);

                        cmd.ExecuteNonQuery();

                        dataGridView1.Rows.Clear();

                        dataGridView1.ColumnCount = 5;
                        dataGridView1.Columns[0].Name = "ID";
                        dataGridView1.Columns[1].Name = "RACUN";
                        dataGridView1.Columns[2].Name = "DATUM";
                        dataGridView1.Columns[3].Name = "IZNOS";
                        dataGridView1.Columns[4].Name = "OPIS";
                        using (con = new SQLiteConnection(@"URI=file:baza_podataka.db"))
                        {
                            con.Open();
                            cmd = new SQLiteCommand("select * from '" + ime + "';", con);
                            SQLiteDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                try
                                { 
                                    String cena = reader[3].ToString();

                                    if (Convert.ToDouble(cena) < 0)
                                    {
                                        zaduzio = zaduzio + Convert.ToDouble(cena);

                                    }
                                    else
                                    {
                                        platio = platio + Convert.ToDouble(cena);
                                    }
                                    ukupno = zaduzio + platio;
                                   
                                }
                                catch (Exception eks)
                                {
                                    Console.WriteLine("Cena nije broj" + eks);
                                }
                                String datum = reader[2].ToString();
                                String[] delovi = datum.Split('.');

                                Transkacija t = new Transkacija(reader[0].ToString(), reader[1].ToString(), new DateTime(Convert.ToInt32(delovi[2]), Convert.ToInt32(delovi[1]), Convert.ToInt32(delovi[0])), reader[3].ToString(), reader[4].ToString()); ;
                                lista.Add(t);
                                
                                

                            }

                            var persons = from p in lista
                                          orderby p.Datum
                                          select p;
                            persons.ToList().ForEach(p => dataGridView1.Rows.Add(new string[] { p.getID(), p.getNaziv(), p.getDatum().ToString("dd/MM/yyyy"), p.getIznos(), p.getOpis() }));


                            label2.Text = ukupno.ToString("0.##");
                            label3.Text = zaduzio.ToString();
                            label5.Text = platio.ToString();

                        }

                    }
                    catch (Exception eks)
                    {
                        MessageBox.Show("ID za brisanje mora biti broj! ");
                    }
                }

            }

            
        }

        private void STANJE_Load(object sender, EventArgs e)
        {

        }
    }
}
