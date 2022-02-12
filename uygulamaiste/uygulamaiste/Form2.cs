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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        void Kisilistelee()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ntpodev.accdb");
            con.Open();
            da = new OleDbDataAdapter("SELECT *FROM ntpodev", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Kisilistelee();

            comboBox1.Items.Add("Erkek");

            comboBox1.Items.Add("Kadın");

            comboBox1.Items.Add("Belirtmek İstemiyorum");

            comboBox1.Text = comboBox1.Items[0].ToString();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1egeridon = new Form1();
            form1egeridon.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            ErrorProvider provider = new ErrorProvider();
           





            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ntpodev (Tc,Ad,Soyad,Cinsiyet,Dogum_Tarihi,Telefon,Meslek,Dogum_Yeri,Adres) values (@tc , @ad , @soyad , @cinsiyet ,@dogumtarihi ,@telefon ,@meslek  ,@dogumyeri ,@adres)";
            
            cmd.Parameters.AddWithValue("@tc", tc.Text);
            cmd.Parameters.AddWithValue("@ad", ad.Text);
            cmd.Parameters.AddWithValue("@soyad", soyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@telefon", telefon.Text);
            cmd.Parameters.AddWithValue("@meslek", meslek.Text);
            cmd.Parameters.AddWithValue("@dogumyeri", dogumyeri.Text);
            cmd.Parameters.AddWithValue("@adres", adres.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            Kisilistelee(); 


        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ntpodev WHERE Kimlik=@kimlik";
            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@kimlik", dataGridView1.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Kisilistelee();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ntpodev Set Tc=@tc,Ad=@ad,Soyad=@soyad,Cinsiyet=@cinsiyet,Dogum_Tarihi=@dogumtarihi,Telefon=@telefon,Meslek=@meslek,Dogum_Yeri=@dogumyeri,Adres=@adres WHERE Kimlik=@kimlik";
            cmd = new OleDbCommand(sorgu, con);
           
            cmd.Parameters.AddWithValue("@tc", tc.Text);
            cmd.Parameters.AddWithValue("@ad", ad.Text);
            cmd.Parameters.AddWithValue("@soyad", soyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@telefon", telefon.Text);
            cmd.Parameters.AddWithValue("@meslek", meslek.Text);
            cmd.Parameters.AddWithValue("@dogumyeri", dogumyeri.Text);
            cmd.Parameters.AddWithValue("@adres", adres.Text);
            cmd.Parameters.AddWithValue("@kimlik", Convert.ToInt32(Kimlik.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Kisilistelee();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Kimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            telefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            meslek.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dogumyeri.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            adres.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

















































        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void cinsiyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void meslek_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void dogumyeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tc_Validated(object sender, EventArgs e)
        {
            if (tc.Text.Trim() == "") 
                errorProvider1.SetError(tc, "Tc değerini girmelisiniz");
           
            else
                errorProvider1.SetError(tc, "");
           
        }

        private void ad_Validated(object sender, EventArgs e)
        {
            if (ad.Text.Trim() == "") 
                errorProvider1.SetError(ad, "Ad girmelisiniz");

            else
                errorProvider1.SetError(ad, "");

        }

        private void soyad_Validated(object sender, EventArgs e)
        {
            if (soyad.Text.Trim() == "")
                errorProvider1.SetError(soyad, "Soyad girmelisiniz");

            else
                errorProvider1.SetError(soyad, "");

        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "")
                errorProvider1.SetError(comboBox1, "Cinsiyet seçmelisiniz");

            else
                errorProvider1.SetError(comboBox1, "");
        }

        private void telefon_Validated(object sender, EventArgs e)
        {
            if (telefon.Text.Trim() == "")
                errorProvider1.SetError(telefon, "Telefon girmelisiniz");

            else
                errorProvider1.SetError(telefon, "");
        }

      

        private void meslek_Validated(object sender, EventArgs e)
        {
            if (meslek.Text.Trim() == "")
                errorProvider1.SetError(meslek, "Meslek girmelisiniz");

            else
                errorProvider1.SetError(meslek, "");
        }

        private void dogumyeri_Validated(object sender, EventArgs e)
        {
            if (dogumyeri.Text.Trim() == "")
                errorProvider1.SetError(dogumyeri, "Doğum yerini girmelisiniz");

            else
                errorProvider1.SetError(dogumyeri, "");
        }

        private void adres_Validated(object sender, EventArgs e)
        {
            if (adres.Text.Trim() == "")
                errorProvider1.SetError(adres, "Adres girmelisiniz");

            else
                errorProvider1.SetError(adres, "");
        }

        private void anasayfayaGeriDönToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void arkaPlanRenginiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}







