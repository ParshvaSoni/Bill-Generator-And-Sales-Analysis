using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace jweller_loyality
{
    public partial class modify : Form
    {
        public modify()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\acer\Documents\maininfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int validate()
        {
            if (!String.IsNullOrEmpty(v1.Text.ToString()) && !String.IsNullOrEmpty(v2.Text.ToString()))
            {
                return 10;
            }
            else
            {
                MessageBox.Show("Please Enter Both details to search the data for modification");
                return 0;
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            int temp = validate();
            if (temp != 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Custinfo WHERE (CardNo = '" + ocard.Text + "' AND MOb1 = '" + omob1.Text + "') ", con);
                //int UserExist = Convert.ToInt32(check_User_Name.ExecuteScalar());
                /**
                con.Close();
                if (UserExist > 0)
                {
                    //Username exist
                    MessageBox.Show("User Exist !");
                }
                else
                {
                    //Username doesn't exist.
                    MessageBox.Show("User Doen't exist !");
                }**/
            }
            
        }


    }
}
