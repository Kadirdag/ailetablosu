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
    public partial class Form3 : Form
    {


        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        public Form3()
        {
            InitializeComponent();
        }

        void Kisilistele()
        { 
          con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ntpodev.accdb");
            con.Open();
            da = new OleDbDataAdapter("SELECT *FROM ntpodev", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Kisilistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1egeridon = new Form1();
            form1egeridon.Show();
            this.Hide();
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

        private void arkaPlanRengiDeğişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black ;
        }
    }
}
