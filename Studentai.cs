using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class Studentai : Form
    {
        public Studentai()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jonas-PC\Documents\TamoDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder= new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StVardasTB.Text == ""|| StPavardeTb.Text == "" || StgrupeCb.SelectedIndex == -1 || StDalykasCb.SelectedIndex == -1)
            {
                MessageBox.Show("Nera informacijos");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(StVardas,StPavarde,StGrupe,StDalykas) values (@SVardas,@SPavarde,@Sgrupe,@SDalykas)", Con);
                    cmd.Parameters.AddWithValue("@SVardas", StVardasTB.Text);
                    cmd.Parameters.AddWithValue("@SPavarde", StPavardeTb.Text);
                    cmd.Parameters.AddWithValue("@Sgrupe", StgrupeCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDalykas", StDalykasCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Studentas pridetas");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            key = 0;
            StVardasTB.Text = "";
            StPavardeTb.Text = "";
            StgrupeCb.SelectedIndex = 0;
            StDalykasCb.SelectedIndex= 0;
        }
        int key = 0;
        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StVardasTB.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            StPavardeTb.Text = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            StgrupeCb.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            StDalykasCb.Text = StudentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if(StVardasTB.Text == "")
            {
                key = 0;
            }else
            {
                key = Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Pasirinkite Studenta");
             
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from studentTbl where StId= @Stkey",Con);
                    cmd.Parameters.AddWithValue("@StKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Studentas istrintas");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StVardasTB.Text == "" || StPavardeTb.Text == "" || StgrupeCb.SelectedIndex == -1 || StDalykasCb.SelectedIndex == -1)
            {
                MessageBox.Show("Nera informacijos");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTbl set StVardas=@SVardas,StPavarde=@SPavarde,StGrupe=@SGrupe,StDalykas=@SDalykas where Stid=@StudentoId", Con);
                    cmd.Parameters.AddWithValue("@SVardas", StVardasTB.Text);
                    cmd.Parameters.AddWithValue("@SPavarde", StPavardeTb.Text);
                    cmd.Parameters.AddWithValue("@Sgrupe", StgrupeCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDalykas", StDalykasCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@StudentoId", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Studentas pakeistas");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            PagrindinisMeniu Obj = new PagrindinisMeniu();
            Obj.Show();
            this.Hide();
        }
    }
}
