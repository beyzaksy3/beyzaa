using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        DataTable tablo = new DataTable();
        public static double FEE = 0.002;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HESAPLA_Click(object sender, EventArgs e)
        {
            double FEE = 0.002;

            double alis = 0;
            double satis = 0;
            if (!String.IsNullOrEmpty(textBoxB.Text))
            {
                alis = ((Convert.ToDouble(textBoxAA.Text) / 100000000)) * Convert.ToDouble(textBoxB.Text) * Convert.ToDouble(textBoxA.Text);
                satis = ((Convert.ToDouble(textBoxSS.Text) / 100000000)) * Convert.ToDouble(textBoxB.Text) * Convert.ToDouble(textBoxA.Text);
                var alisfee = alis * FEE;
                var satisfee = satis * FEE;
                double fee = 0;
                fee = (alisfee + satisfee);
                double karbtc = 0;
                karbtc = ((Convert.ToDouble(textBoxSS.Text)) * (Convert.ToDouble(textBoxA.Text)) - (Convert.ToDouble(textBoxSS.Text)) * (Convert.ToDouble(textBoxA.Text)) * FEE - (Convert.ToDouble(textBoxAA.Text)) * (Convert.ToDouble(textBoxA.Text)) * FEE) / 100000000;
                double karusd = 0;
                karusd = karbtc * (Convert.ToDouble(textBoxB.Text));
                label14.Text = fee.ToString();
                label12.Text = karbtc.ToString();
                label13.Text = karusd.ToString();
                tablo.Rows.Add(textBoxA.Text, textBoxB.Text, textBoxAA.Text, textBoxSS.Text, label14.Text, label13.Text, label12.Text);
                dataGridView1.DataSource = tablo;
            }

            else if (textBoxBTC.Text != null)
            {

                alis = ((Convert.ToDouble(textBoxAA.Text) / 100000000)) * Convert.ToDouble(textBoxBTC.Text) * Convert.ToDouble(textBoxA.Text);
                satis = ((Convert.ToDouble(textBoxSS.Text) / 100000000)) * Convert.ToDouble(textBoxSS.Text)* Convert.ToDouble(textBoxA.Text);
                var alisfee = alis * FEE;

                var satisfee = satis * FEE;
                double fee = 0;

                fee = (alisfee + satisfee);
                double karbtc = 0;
                karbtc = (Convert.ToDouble(textBoxSS.Text) * Convert.ToDouble(textBoxA.Text) - Convert.ToDouble(textBoxSS.Text) * Convert.ToDouble(textBoxA.Text) * FEE - Convert.ToDouble(textBoxAA.Text) * Convert.ToDouble(textBoxA.Text) - Convert.ToDouble(textBoxAA.Text) * Convert.ToDouble(textBoxA.Text) * FEE) / 100000000;
                double karusd = 0;
                karusd = ((Convert.ToDouble(textBoxBTC.Text)) * (Convert.ToDouble(BSS.Text)));
                double karusd2;
                karusd2 = (((Convert.ToDouble(textBoxSS.Text)) * (Convert.ToDouble(textBoxA.Text)) * (Convert.ToDouble(BSS.Text))) - ((Convert.ToDouble(textBoxAA.Text)) * (Convert.ToDouble(textBoxA.Text)) * (Convert.ToDouble(textBoxBTC.Text)) * 0.098)) / 100000000;
                label14.Text = fee.ToString();
                label12.Text = karbtc.ToString();
                label13.Text = karusd.ToString();
                label15.Text = karusd2.ToString();

                tablo.Rows.Add(textBoxA.Text, textBoxB.Text, textBoxAA.Text, textBoxSS.Text, label14.Text, label13.Text, label12.Text);
                dataGridView1.DataSource = tablo;



            }










        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label14.Text = "";
            label12.Text = "";
            label13.Text = "";
            label15.Text = "";
            textBoxA.Text = "";
            textBoxAA.Text = "";
            textBoxB.Text = "";
            textBoxBTC.Text = "";
            textBoxSS.Text = "";
            textBoxSS.Text = "";
            




        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("BTC", typeof(double));
            tablo.Columns.Add("ADET", typeof(double));
            tablo.Columns.Add("ALIŞ", typeof(double));
            tablo.Columns.Add("SATIŞ", typeof(double));
            tablo.Columns.Add("FEE", typeof(double));
            tablo.Columns.Add("KAR(BTC)", typeof(double));
            tablo.Columns.Add("KAR(S)", typeof(double));
            


            dataGridView1.DataSource = tablo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("lütfen silinecek satırı seçin");
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
