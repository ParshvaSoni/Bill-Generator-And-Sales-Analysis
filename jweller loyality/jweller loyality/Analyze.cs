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
    public partial class Analyze : Form
    {
        public Analyze()
        {
            InitializeComponent();
        }

        private void plot1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\acer\Documents\maininfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand chartdata = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            chartdata = new SqlCommand("SELECT DISTINCT PIN FROM Custinfo1", con);
            SqlDataReader myreader;
            try
            {
                myreader = chartdata.ExecuteReader();
                int i=0,t=0;
                int[] value=new int[5];
                string[] data=new string[5];
                string temp="";
                while (myreader.Read())
                {

                    data[i]=myreader.GetValue(0).ToString();
                    //MessageBox.Show(data[0] + "=" + "\n" + value[0] + data[1] + "=" + value[1]);
                    i++;
                }
                int j=0;
                while(j<i-1)
                {
                    temp = temp + "'" + data[j] + "',";
                    j++;
                }
                temp = temp +"'" +data[i-1]+"')";
                
                //MessageBox.Show(i.ToString());
                myreader.Close();

                SqlCommand q1 = con.CreateCommand();
                //MessageBox.Show(temp);
                q1 = new SqlCommand("SELECT COUNT(*) FROM Custinfo1 WHERE PIN IN (" + temp+" GROUP BY PIN ", con);
                SqlDataReader myr;
                myr = q1.ExecuteReader();
                i = 0;
                while (myr.Read())
                {
                    value[i] = Convert.ToInt32(myr.GetValue(0).ToString());
                    i++;
                }
                myr.Close();
                /*SqlCommand q1 = con.CreateCommand();
                    q1 = new SqlCommand("SELECT COUNT(*) FROM Custinfo1 WHERE PIN=" + data[i],con);
                    SqlDataReader mr1;
                    mr1 = q1.ExecuteReader();
                    if (mr1.Read())
                    {
                        value[i] = Convert.ToInt32(mr1.GetValue(i).ToString());
                    }*/
    
                //MessageBox.Show(data[0]+"="+value[0].ToString()+"\n"+data[1]+"="+value[1].ToString()+"\n"+data[2]+"="+value[2].ToString()+"\n"+data[3]+"="+value[3].ToString());

                /*
                if(myreader.Read())
                {
                    int size = Convert.ToInt32(myreader.GetValue(0).ToString());  
                    
                }*/

                chart1.Titles.Add(" Area Analysis");
                j = 0;
                for (j = 0; j < i; j++)
                {
                    chart1.Series["PIN"].Points.AddXY(data[j], value[j]);
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
