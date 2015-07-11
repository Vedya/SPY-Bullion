using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace stock_and_sales
{
    public partial class LogIn : Form
    {
        public static string user, u;
        private string role;
        private MySqlCommand command;
        DbConn db = new DbConn();
        private MySqlConnection connection = new MySqlConnection();
        private MySqlDataReader dr;


        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection = db.getConnection();
            if (connection != null)
            {
                command = new MySqlCommand("select * from user_reg where userid='" + textBox1.Text + "'and password='" + textBox2.Text + "'", connection);
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    role = dr.GetString(3);
                    if (textBox1.Text == dr.GetString(0) && textBox2.Text == dr.GetString(2))
                    {
                        user = textBox1.Text;
                        home h = new home();
                        h.Show();
                        this.Hide();

                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MessageBox.Show("Invalid user name or password");
                    }
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Invalid user name or password");
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        
}
