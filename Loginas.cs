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

namespace 
    Praktika
{
    public partial class Loginas : Form
    {
        public Loginas()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jonas-PC\Documents\TamoDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Irasykite prisijungimo varda ir slaptazodi");
            }
            else if (Username.Text == "Admin" && Password.Text == "Password")
            {
                PagrindinisMeniu Obj = new PagrindinisMeniu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jonas-PC\Documents\TamoDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Select count(*) from destytojoTbl where TVardastbl=@username and TPavardetbl=@password", Con);
                    cmd.Parameters.AddWithValue("@username", Username.Text);
                    cmd.Parameters.AddWithValue("@password", Password.Text);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 1)
                    {
                        this.Hide();
                        Vertinti mm = new Vertinti();
                        mm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Neteisingas prisijungimo vardas arba slaptazodis");
                    }
                }
            }
        }


        private void Loginas_Load(object sender, EventArgs e)
        {

        }
    }
}