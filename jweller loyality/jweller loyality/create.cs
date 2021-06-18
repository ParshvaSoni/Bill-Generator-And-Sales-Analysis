using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
namespace jweller_loyality
{
    
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
            landline.Text = "1111-9999999";
        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void create_FormClosing(object sender, FormClosingEventArgs e)
        {
            main obj = new main();
            this.Hide();
            obj.ShowDialog();
        }

        int validate(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show(tb.Name + " must be filled");
                return (1);
            }
            else
            {
                return (0);
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int check = validate(name1)+validate(mob1)+validate(mail)+validate(area)+validate(pin);
            if (String.IsNullOrEmpty(address.Text.ToString()))
                check++;


            if (check == 0)
            {
                if (!(Regex.Match(mob1.Text, @"^[0-9]{10}$").Success))
                {
                    MessageBox.Show("Please Enter valid Mobile number of Main Customer");
                    check = 0;
                }   
                else
                {

                    if (!String.IsNullOrEmpty(mob2.Text))
                    {
                        if (!(Regex.Match(mob2.Text, @"^[0-9]{10}$").Success))
                        {
                            MessageBox.Show("Please Enter valid Mobile number of Spouse");
                            check = 0;
                        }
                    }
                    else if(true)
                    {
                        if (!(Regex.Match(mail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success))
                        {
                            MessageBox.Show("Please Enter valid email-ID !");
                            check = 0;
                        }
                        else
                        {
                            if (!(Regex.Match(pin.Text, @"^[1-9][0-9]{5}$").Success))
                            {
                                MessageBox.Show("Please Enter valid PIN Number !");
                                check = 0;
                            }
                            else
                            {
                                if (!(Regex.Match(landline.Text, @"^[0-9]\d{3,6}-\d{5,8}$").Success))
                                {
                                    MessageBox.Show("Please Enter valid landline Number !"); check = 0;
                                }
                                else
                                {
                                    string db1="0-0-0";
                                    string db2="0-0-0";
                                    string ad = "0-0-0";
                                    if (dob1.Checked == true)
                                    {
                                        db1 = dob1.Text.ToString();
                                    }
                                    if(dob2.Checked==true)
                                    {
                                        db2=dob2.Text.ToString();
                                    }
                                    if (annid.Checked == true)
                                    {
                                        ad = annid.Text.ToString();
                                    }
                                    
                                    Program.name1 = name1.Text; Program.name2 = spname.Text; Program.dob1 = db1;
                                    Program.dob2 = db2; Program.mob1 = mob1.Text; Program.mob2 = mob2.Text;
                                    Program.landl = landline.Text; Program.anid = ad; Program.address = address.Text;
                                    Program.email = mail.Text; Program.area = area.Text; Program.pin = pin.Text;
                                    check = 10;

                                }
                            }

                        }
                    }

                    
                            
                    }
                    

            }
            if(check!=0)
            {
                string message = "Have you check all the details ?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    old obj1 = new old();
                    this.Hide();
                    obj1.ShowDialog();
                }
            }
        }

        private void landline_TextChanged(object sender, EventArgs e)
        {

        }

        private void mob1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob1_ValueChanged(object sender, EventArgs e)
        {

        }






    }
}
