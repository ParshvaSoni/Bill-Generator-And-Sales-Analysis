using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;
namespace jweller_loyality
{
    public partial class old : Form
    {
        double final = 0;
        public old()
        {
            InitializeComponent();
            oname1.Text = Program.name1;
            oemail.Text = Program.email;
            omob1.Text = Program.mob1;
            ocard.Text = Program.card();
      
        }
        int validate()
        {

            if (!String.IsNullOrEmpty(ocard.Text.ToString()) && !String.IsNullOrEmpty(omob1.Text.ToString()))
            {
                if (ocard.Text.Length != 16 || !(Regex.IsMatch(ocard.Text, "^[0-9]+$")))
                {
                    MessageBox.Show("Please Enter valid Card Number !");
                    return (0);
                }
                else
                {
                    if (omob1.Text.Length != 10 || !(Regex.IsMatch(omob1.Text, "^[0-9]+$")))
                    {
                        MessageBox.Show("Please Enter valid Mobile Number !");
                        return (0);
                    }
                    else
                    {
                        if (!sales.Checked && !purchase.Checked)
                        {
                            MessageBox.Show("Please Select The Sales or Purchase Or Both !");
                            return 0;
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(Total.Text) || !(Regex.IsMatch(Total.Text, "^[0-9]+$")))
                            {
                                MessageBox.Show("Please Enter valid Total Bussiness Amount");
                                return 0;
                            }
                            else
                            {
                                double temp = double.Parse(Total.Text);
                                float g = float.Parse(goldp.Text), s = float.Parse(silverp.Text), d = float.Parse(diamondp.Text), i = float.Parse(immmip.Text), o = float.Parse(otherp.Text), r = float.Parse(repairp.Text);
                                final = ((temp * g) + (temp * s) + (temp * d) + (temp * i) + (temp * o) + (temp * r));
                                final = Math.Ceiling(final);
                                pb.Text = (final.ToString());
                                if (double.Parse(pb.Text) - double.Parse(pc.Text) < 0)
                                {
                                    MessageBox.Show("This Customer Don't Have Enough Point to redeem !");
                                    return (0);
                                }
                                else
                                {
                                    return (1);
                                }
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter Mobile Number And Card Number !");
                return (0);
            }

        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\acer\Documents\maininfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void check_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ocard.Text.ToString()) && !String.IsNullOrEmpty(omob1.Text.ToString()))
            {
                if (ocard.Text.Length != 16 || !(Regex.IsMatch(ocard.Text, "^[0-9]+$")))
                {
                    MessageBox.Show("Please Enter valid Card Number !");
                }
                else
                {
                    if (omob1.Text.Length != 10 || !(Regex.IsMatch(omob1.Text, "^[0-9]+$")))
                    {
                        MessageBox.Show("Please Enter valid Mobile Number !");
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Custinfo1 WHERE (CardNo = '" + ocard.Text + "' AND MOb1 = '"+ omob1.Text+"') ", con);
                        int UserExist = Convert.ToInt32(check_User_Name.ExecuteScalar());
                      
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
                        }
                      
                    }
                }
            }
            
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int temp = validate();
            if (temp == 1)
            {
                Program.name1 = oname1.Text;
                Program.email = oemail.Text;
                Program.mob1 = omob1.Text;
                Program.cardno = ocard.Text;
                Program.sales = sales.Checked.ToString();
                Program.purchase = purchase.Checked.ToString();
                Program.product = product.Text;
                Program.Tbuss = Total.Text;
                Program.pts = pd.Text;
                Program.gold = goldp.Text;
                Program.silver = silverp.Text;
                Program.diammomd = diamondp.Text;
                Program.immitation = immmip.Text;
                Program.other = otherp.Text;
                Program.repairing = repairp.Text;
                String dtxt = "0-0-0";
                if (datetxt.Checked == true)
                {
                    dtxt = datetxt.Text.ToString();   
                }

                //MessageBox.Show("\t>>> Please Confirm The Following Details <<<\n\nName :" + oname1.Text + "\t\t Card No : " + ocard.Text + "\nEmail Id : " + oemail.Text + "\t Mobile No. : " + omob1.Text + "\n____________________________________________________________\nTotal Business : " + Total.Text + "\t\tSales :" + sales.Checked.ToString() + "\t\tPurchase : " + purchase.Checked.ToString()+"\t\t\tProduct : "+product.Text + "\n____________________________________________________________\nPrevious Points :" + pa.Text + "\t\tPoints Got : " + pb.Text + "\nPoints Redeem : " + pc.Text + "\t\tFinals Points : " + pd.Text);
                DialogResult dialogResult = MessageBox.Show("\n\nName :" + oname1.Text + "\t\t Card No : " + ocard.Text + "\nEmail Id : " + oemail.Text + "\t Mobile No. : " + omob1.Text + "\n____________________________________________________________\nTotal Business : " + Total.Text + "\t\tSales :" + sales.Checked.ToString() + "\t\tPurchase : " + purchase.Checked.ToString() + "\t\t\tProduct : " + product.Text + "\n____________________________________________________________\nPrevious Points :" + pa.Text + "\t\tPoints Got : " + pb.Text + "\nPoints Redeem : " + pc.Text + "\t\tFinals Points : " + pd.Text, "Jwellers Loyality", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "insert into Custinfo1 values('" + billno.Text.ToLower() + "','" + goldrate.Text.ToLower() + "','" + silverrate.Text.ToLower() + "','" + gst.Text.ToLower() + "','" + date.Text.ToLower() + "','" + cname.Text.ToLower() + "','" + caddress.Text.ToLower() + "','" + cuid.Text.ToLower() + "','" + cvalue.Text.ToLower() + "','" + cmob.Text.ToLower() + "','" + iname.Text.ToLower() + "','" + g_s.Text.ToLower() + "','" + labour.Text.ToLower() + "','" + dealername.Text.ToLower() + "','" + iweight.Text.ToLower() + "','" + hallmark.Text.ToLower() + "','" + grandtotal.ToString().ToLower() + "','" + stillpay.ToString().ToLower() + "','" + flag.ToString().ToLower() + "')";
                    cmd.CommandText = "insert into Custinfo1 values('" + Program.cardno.ToString() + "','" + Program.name1.ToString() + "','" + Program.name2.ToString() + "','" + Program.mob1.ToString() + "','" + Program.mob2.ToString() + "','" + Program.dob1 + "','" + Program.dob2+ "','" + Program.anid + "','" + Program.landl.ToString() + "','" + Program.address.ToString() + "','" + Program.area.ToString() + "','" + Program.pin.ToString() + "','" + Program.email.ToString() + "','" + Program.pts.ToString() + "','" + Program.Tbuss.ToString() + "','" + Program.sales.ToString() + "','" + Program.purchase.ToString() + "','" + Program.gold.ToString() + "','" + Program.silver.ToString() + "','" + Program.immitation.ToString() + "','" + Program.other.ToString() + "','" + Program.repairing.ToString() + "','" + Program.product.ToString() + "','"+dtxt+"','null','null')";
                    int a=cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        Program.counter++;
                        MessageBox.Show("User Data Entered Successfully !");
                        Program.name1="";
                        Program.name2 = "";
                        Program.dob1="0-0-0";
                        Program.dob2="0-0-0";
                        Program.mob1="";
                        Program.mob2="";
                        Program.landl="";
                        Program.anid="0-0-0";
                        Program.address="";
                        Program.area="";
                        Program.email="";
                        Program.pin="";

                        Program.cardno="";
                        Program.sales="";
                        Program.purchase="";
                        Program.Tbuss="";
                        Program.pts="";
                        Program.gold="";
                        Program.silver="";
                        Program.diammomd="";
                        Program.immitation="";
                        Program.other="";
                        Program.repairing="";
                        Program.product="";
                        main n = new main();
                        this.Hide();
                        n.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("There was a problem while inserting the data :(");
                    }

                    con.Close();
                }
                /*
                else if (dialogResult == DialogResult.No)
                {
                           
                }*/
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Total.Text) || !(Regex.IsMatch(Total.Text, "^[0-9]+$")))
            {
                MessageBox.Show("Please Enter valid Total Bussiness Amount");
            }
            else
            {
                goldtxt.Text = Convert.ToInt32(double.Parse(gt.Text) * (double.Parse(goldp.Text) / 100)).ToString();
                silvertxt.Text = Convert.ToInt32(double.Parse(st.Text) * (double.Parse(silverp.Text) / 100)).ToString();
                diamdtxt.Text = Convert.ToInt32(double.Parse(dt.Text) * (double.Parse(diamondp.Text) / 100)).ToString();
                immmitxt.Text = Convert.ToInt32(double.Parse(it.Text) * (double.Parse(immmip.Text) / 100)).ToString();
                othertxt.Text = Convert.ToInt32(double.Parse(ot.Text) * (double.Parse(otherp.Text) / 100)).ToString();
                repairtxt.Text = Convert.ToInt32(double.Parse(rt.Text) * (double.Parse(repairp.Text) / 100)).ToString();
                Total.Text = Convert.ToInt32(double.Parse(goldtxt.Text) + double.Parse(silvertxt.Text) + double.Parse(diamdtxt.Text) + double.Parse(immmitxt.Text) + double.Parse(othertxt.Text) + double.Parse(repairtxt.Text)).ToString();
                if (double.Parse(pb.Text) - double.Parse(pc.Text) < 0)
                {
                    MessageBox.Show("This Customer Don't Have Enough Point to redeem !");
                }
                else
                {
                    pd.Text = (double.Parse(pa.Text) + double.Parse(pb.Text) - (double.Parse(pc.Text))).ToString();
                }
                
            }
        }

        private void old_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure ?\nYou want to exit. All the changes you made will be erased ! ", "Jwellers Loyality", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                main n = new main();
                this.Hide();
                n.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void datetxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void old_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void gt_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
