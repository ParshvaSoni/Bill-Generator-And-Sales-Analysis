using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace jweller_loyality 
{


    static class Program
    {
        
            public static string name1="";
            public static string name2="";
            public static string dob1 = "";
            //public static DateTime dob1=Convert.ToDateTime(null);
            public static string dob2 = "";
            //public static DateTime dob2=Convert.ToDateTime(null);
            public static string mob1="";
            public static string mob2="";
            public static string landl="";
            public static string anid = "";
            //public static DateTime anid=Convert.ToDateTime(null);
            public static string address="";
            public static string area="";
            public static string email="";
            public static string pin="";

            public static string cardno="";
            public static string sales="";
            public static string purchase="";
            public static string Tbuss="";
            public static string pts="";
            public static string gold="";
            public static string silver="";
            public static string diammomd="";
            public static string immitation="";
            public static string other="";
            public static string repairing="";
            public static string product="";
            
        public static float counter = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string card()
        {
            string count = counter.ToString().PadLeft(4,'0');
            string mm = DateTime.Now.Month.ToString().PadLeft(4, '0');
            string dd = DateTime.Now.Day.ToString().PadLeft(4, '0');
            string yr = DateTime.Now.Year.ToString().PadLeft(4, '0');
            return (count+dd+mm+yr);
        }
        [STAThread]
        static void Main()
        {
            int count = 1;
            String path = "C:\\Users\\acer\\documents\\visual studio 2010\\Projects\\jweller loyality\\jweller loyality\\details.txt";
            if (File.Exists(path))
            {
                FileStream fs2 = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs2);
                String str = reader.ReadToEnd();
                String[] spearator = { ",", " " };
                String[] strlist = str.Split(spearator, System.StringSplitOptions.RemoveEmptyEntries);
                counter = float.Parse(strlist[0]);
                reader.Close();
            }
            else
            {
                MessageBox.Show("The Details.txt does not found......!");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
