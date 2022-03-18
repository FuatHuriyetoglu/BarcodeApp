using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace marketBarkod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }

        }

        private void onTextCanged(object sender, EventArgs e)
        {
            /**
             * TODO:
             * +
             * guncelleme ve ekleme fonskiyonlarini ayir
             * silme metodu ekle
             */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*datalari text boxlardan okuyup tabloya insert et
             * nasil listeleme yapacağız tasarla
             */
            String productStr = "'" + txtProduct.Text + "'";
            String sql = "insert into market.product(price, barcod_no, product_name, stock) values("+txtPrice.Text+", "+txtBarkod.Text+","+ productStr + ","+txtStock.Text+")";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=41234;database=market;");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            int effectedRowCount = cmd.ExecuteNonQuery();

            txtBarkod.Text = effectedRowCount.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String productStr = "'" + txtProduct.Text + "'";
            String sql = "update market.product  set price=6 where price=3";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=41234;database=market;");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            int effectedRowCount = cmd.ExecuteNonQuery();

            txtBarkod.Text = effectedRowCount.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string sql = "select * from market.product ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=41234;database=market;");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int stock =(int)reader["stock"];
                int price=(int) reader["price"];
                String barcod_no = (String)reader["barcod_no"];
                String Product_name = (String)reader["Product_name"];
                
                listBox1.Items.Add(stock.ToString() + " " + price.ToString() + " " + Product_name.ToString() + " " + barcod_no.ToString());

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBarkod.Clear();
            txtPrice.Clear();
            txtProduct.Clear();
            txtStock.Clear();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
