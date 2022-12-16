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
    public partial class Vertinti : Form
    {
        public Vertinti()
        {
            InitializeComponent();
            DisplayVertinti();
            FillStudid();
        }
        private void FillStudid()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Stid from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Stid", typeof(int));
            dt.Load(rdr);
            Stidcb.ValueMember = "Stid";
            Stidcb.DataSource = dt;
            Con.Close();
        }
        private void GetStudVardas()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from StudentTbl where Stid=@Sid",Con);
            Cmd.Parameters.AddWithValue("@Sid", Stidcb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                StVardastb.Text = dr["StVardas"].ToString();
            }
            Con.Close();
        }
        private void GetStudPavarde()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from StudentTbl where Stid=@Sid", Con);
            Cmd.Parameters.AddWithValue("@Sid", Stidcb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StPavardetb.Text = dr["StPavarde"].ToString();
            }
            Con.Close();
        }
        private void GetStudGrupe()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from StudentTbl where Stid=@Sid", Con);
            Cmd.Parameters.AddWithValue("@Sid", Stidcb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StGrupetbl.Text = dr["StGrupe"].ToString();
            }
            Con.Close();
        }
        private void GetStudDalykas()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from StudentTbl where Stid=@Sid", Con);
            Cmd.Parameters.AddWithValue("@Sid", Stidcb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StDalykastb.Text = dr["StDalykas"].ToString();
            }
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jonas-PC\Documents\TamoDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayVertinti()
        {
            Con.Open();
            string Query = "Select * from StudentoPazymiai";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VertinimasDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Vertinimascb.SelectedIndex = -1;
            StVardastb.Text = "";
            StPavardetb.Text = "";
            StGrupetbl.Text = "";
            StDalykastb.Text = "";
            Stidcb.SelectedIndex = -1;
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (StVardastb.Text == "" || StPavardetb.Text == "" || StGrupetbl.Text == "" || StDalykastb.Text == "" || Vertinimascb.SelectedIndex == -1)
            {
                MessageBox.Show("Nera informacijos");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentoPazymiai(Stid,StVardas,StPavarde,StGrupe,StDalykas,StPazymys) values (@Stid,@StVardas,@StPavarde,@StGrupe,@StDalykas,@StPazymys)", Con);
                    cmd.Parameters.AddWithValue("@Stid", Stidcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StVardas", StVardastb.Text);
                    cmd.Parameters.AddWithValue("@StPavarde", StPavardetb.Text);
                    cmd.Parameters.AddWithValue("@StGrupe", StGrupetbl.Text);
                    cmd.Parameters.AddWithValue("@StDalykas", StDalykastb.Text);
                    cmd.Parameters.AddWithValue("@StPazymys", Vertinimascb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Studentui pazymys irasytas");
                    Con.Close();
                    DisplayVertinti();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudVardas();
            GetStudPavarde();
            GetStudGrupe();
            GetStudDalykas();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Pasirinkite Studenta");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from StudentTbl where Stid= @Stkey", Con);
                    cmd.Parameters.AddWithValue("@StKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ivertinimas istrintas");
                    Con.Close();
                    DisplayVertinti();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void VertinimasDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Stidcb.SelectedValue = VertinimasDGV.SelectedRows[0].Cells[1].Value.ToString();
            StVardastb.Text = VertinimasDGV.SelectedRows[0].Cells[2].Value.ToString();
            StPavardetb.Text = VertinimasDGV.SelectedRows[0].Cells[3].Value.ToString();
            StGrupetbl.Text = VertinimasDGV.SelectedRows[0].Cells[4].Value.ToString();
            StDalykastb.Text = VertinimasDGV.SelectedRows[0].Cells[5].Value.ToString();
            Vertinimascb.SelectedItem = VertinimasDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (StVardastb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(VertinimasDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (StVardastb.Text == "" || StPavardetb.Text == "" || StGrupetbl.Text == "" || StDalykastb.Text == "" || Vertinimascb.SelectedIndex == -1)
            {
                MessageBox.Show("Nera informacijos");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTbl set Stid=@Stid,StVardas=@StVardas,StPavarde=@StPavarde,StGrupe=@StGrupe,StDalykas=@StDalykas,StPazymys=@StPazymys where StPaid=@Pazymysid", Con);
                    cmd.Parameters.AddWithValue("@Stid", Stidcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StVardas", StVardastb.Text);
                    cmd.Parameters.AddWithValue("@StPavarde", StPavardetb.Text);
                    cmd.Parameters.AddWithValue("@StGrupe", StGrupetbl.Text);
                    cmd.Parameters.AddWithValue("@StDalykas", StDalykastb.Text);
                    cmd.Parameters.AddWithValue("@StPazymys", Vertinimascb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Pazymysid", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Destytojas pakeistas");
                    Con.Close();
                    DisplayVertinti();
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
    }
}
