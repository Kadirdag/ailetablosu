using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace uygulamaiste
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ntpodev.accdb");
        DataTable tablo = new DataTable();


        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from ntpodev where Dogum_Tarihi between tr11 and tr22", baglanti);
            adtr.SelectCommand.Parameters.AddWithValue("tr11", dateTimePicker1.Value.ToShortDateString());
            adtr.SelectCommand.Parameters.AddWithValue("tr22", dateTimePicker2.Value.ToShortDateString());
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1egeridon = new Form1();
            form1egeridon.Show();
            this.Hide();
        }

        private void arkaPlanRenginiDeğişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void öncekiSayfayaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1egeridon = new Form1();
            form1egeridon.Show();
            this.Hide();
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
