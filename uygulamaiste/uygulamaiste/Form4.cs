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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ntpodev.accdb");
        OleDbDataAdapter da;
        DataTable dt;
        string sql = "SELECT * FROM ntpodev";
     

      
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1egeridon = new Form1();
            form1egeridon.Show();
            this.Hide();
        }

        void Listele(string aranan)
        {
            da = new OleDbDataAdapter(sql, con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }





        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                sql = "SELECT *FROM ntpodev WHERE Tc='" + textBox1.Text + "'";
            }
            else if (radioButton2.Checked)
            {
                sql = "SELECT *FROM ntpodev WHERE Ad='" + textBox1.Text + "'";
            }
            else if (radioButton3.Checked)
            {
                sql = "SELECT *FROM ntpodev WHERE Soyad='" + textBox1.Text + "'";
            }
            else if (radioButton4.Checked)
            {
                sql = "SELECT *FROM ntpodev WHERE Cinsiyet='" + comboBox1.Text + "'";
            }
            else if (radioButton5.Checked)
            {
                sql = "SELECT *FROM ntpodev WHERE Meslek='" + textBox1.Text + "'";
            }

            else
            {
                sql = "SELECT *FROM ntpodev";
            }

            Listele(sql);


        }




        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Erkek");

            comboBox1.Items.Add("Kadın");

            comboBox1.Items.Add("Belirtmek İstemiyorum");

            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void araButonRengiDeğişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
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
