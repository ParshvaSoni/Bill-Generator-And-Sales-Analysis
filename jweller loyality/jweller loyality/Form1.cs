using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace jweller_loyality
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void passwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uname.Text))
            {
                MessageBox.Show("Enter Username !");
            }
            else
            {
                if (uname.Text != "admin")
                {
                    MessageBox.Show("Enter Valid Username !");
                }
                else
                {
                    if (string.IsNullOrEmpty(passwd.Text))
                    {
                        MessageBox.Show("Enter Password !");
                    }
                    else
                    {
                        if (passwd.Text != "admin")
                        {
                            MessageBox.Show("Enter Valid password !");
                        }
                        else
                        {
                            main n = new main();
                            this.Hide();
                            n.ShowDialog();
                         
                        }
                    }   
                }
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            String path = "C:\\Users\\acer\\documents\\visual studio 2010\\Projects\\jweller loyality\\jweller loyality\\details.txt";
            if (File.Exists(path))
            {
                FileStream fs1 = new FileStream(path, FileMode.Create , FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs1);
                writer.Write(Program.counter.ToString()+",");
                writer.Close();
            }
            else
            {
                File.Create(path);
                FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs1);
                writer.Write(Program.counter.ToString(),",");
                writer.Close();

            }
            
            DialogResult dialogResult = MessageBox.Show("Are you sure, you want to exit ? ", "Jwellers Loyality", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
