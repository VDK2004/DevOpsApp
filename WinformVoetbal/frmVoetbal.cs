using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryVoetbal;
using System.Data.SQLite;
using System.Configuration;
using Dapper;

namespace WinformVoetbal
{
    public partial class frmVoetbal : Form
    {
        string connectionString = "Data Source=VoetbalDB.db;Version=3;";
        List<Uitslag> uitslagen = new List<Uitslag>();

        public frmVoetbal()
        {
            InitializeComponent();
            loadTeams();
            listBox1.Items.Clear();
            loadUitslagList();
        }
        private void loadTeams()
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString))
            {
                cnn.Open();
                var options = cnn.Query<string>("SELECT Naam FROM Teams");
                cbthuisPloeg.Items.AddRange(options.ToArray());
                cbuitPloeg.Items.AddRange(options.ToArray());

            }
           
        }
        private void loadUitslagList()
        {
            uitslagen = SqliteDataAccess.LoadUitslagen();
            using (IDbConnection cnn = new SQLiteConnection(connectionString))
            {
                cnn.Open();
                var options = cnn.Query<string>("SELECT * FROM Uitslagen");
                foreach (var uitslag in uitslagen)
                {
                    // Voeg de attributen van elke rij toe aan de ListBox
                    listBox1.Items.Add($"{uitslag.thuisPloeg} vs {uitslag.uitPloeg}:   {uitslag.doelpuntenThuis} - {uitslag.doelpuntenUit}");
                }

            }
        }
        private void WireUpPeopleList()
        {
            listBox1.DataSource = null;
           
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

                // Definieer parameters als een anoniem object


                string thuisPloeg = cbthuisPloeg.Text;
                int doelpuntThuis = Convert.ToInt32(doelpuntenThuis.Text);
                string uitPloeg = cbuitPloeg.Text;
                int doelpuntUit = Convert.ToInt32(doelpuntenUit.Text);

             if(thuisPloeg != uitPloeg)
            {
                using (IDbConnection cnn = new SQLiteConnection(connectionString))
                {
                    cnn.Open();
                    cnn.Query<string>("INSERT INTO Uitslagen (thuisPloeg, doelpuntenThuis, uitPloeg, doelpuntenUit) " +
                "VALUES ('" + thuisPloeg + "', " + doelpuntThuis + ", '" + uitPloeg + "', " + doelpuntUit + ")");
                    cnn.Close();

                    MessageBox.Show("De uitslag is toegevoegd aan de databank!");
                }
                listBox1.Items.Clear();
                loadUitslagList();
            }
            else
            {
                MessageBox.Show("Het thuis en uit team kan niet hetzelfde zijn.");
                cbthuisPloeg.Focus();
            }
               

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            loadUitslagList();
                     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString))
            {
                cnn.Open();

                // Laat de Uitslagen-tabel vallen (let op: dit zal alle gegevens in de tabel verwijderen)
                cnn.Execute("DROP TABLE IF EXISTS Uitslagen");

                // Maak de Uitslagen-tabel opnieuw aan
                cnn.Execute(@"CREATE TABLE IF NOT EXISTS Uitslagen (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    thuisPloeg TEXT,
                    doelpuntenThuis INTEGER,
                    uitPloeg TEXT,
                    doelpuntenUit INTEGER
                 )");
            }
            listBox1.Items.Clear();
            loadUitslagList();

        }
    }
}
