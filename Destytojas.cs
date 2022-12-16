using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Destytojas : Form
    {
        public Destytojas()
        {
            InitializeComponent();
            DisplayDestytojus();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jonas-PC\Documents\TamoDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDestytojus()
        {
            Con.Open();
            string Query = "Select * from DestytojoTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DestytojaiDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            TVardastbl.Text = "";
            TPavardetbl.Text = "";
            TDalykascb.SelectedIndex = 0;
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (TVardastbl.Text == "" || TPavardetbl.Text == "" || TDalykascb.SelectedIndex == -1)
            {
                MessageBox.Show("Nera informacijos");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DestytojoTbl(TVardastbl,TPavardetbl,TDalykascb) values (@DVardas,@DPavarde,@DDalykas)", Con);
                    cmd.Parameters.AddWithValue("@DVardas", TVardastbl.Text);
                    cmd.Parameters.AddWithValue("@DPavarde", TPavardetbl.Text);
                    cmd.Parameters.AddWithValue("@DDalykas", TDalykascb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Destytojas pridetas");
                    Con.Close();
                    DisplayDestytojus();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            PagrindinisMeniu Obj = new PagrindinisMeniu();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void DestytojaiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TVardastbl.Text = DestytojaiDGV.SelectedRows[0].Cells[1].Value.ToString();
            TPavardetbl.Text = DestytojaiDGV.SelectedRows[0].Cells[2].Value.ToString();
            TDalykascb.Text = DestytojaiDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (TVardastbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DestytojaiDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Pasirinkite destytoja");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DestytojoTbl where TId= @Tkey", Con);
                    cmd.Parameters.AddWithValue("@TKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Destytojas istrintas");
                    Con.Close();
                    DisplayDestytojus();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TVardastbl.Text == "" || TPavardetbl.Text == "" || TDalykascb.SelectedIndex == -1)
            {
                MessageBox.Show("Nera informacijos");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DestytojoTbl set TVardastbl=@DVardas,TPavardetbl=@DPavarde,TDalykascb=@DDalykas where TId=@DestytojoID", Con);
                    cmd.Parameters.AddWithValue("@DVardas", TVardastbl.Text);
                    cmd.Parameters.AddWithValue("@DPavarde", TPavardetbl.Text);
                    cmd.Parameters.AddWithValue("@DDalykas", TDalykascb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DestytojoID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Destytojas pakeistas");
                    Con.Close();
                    DisplayDestytojus();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}