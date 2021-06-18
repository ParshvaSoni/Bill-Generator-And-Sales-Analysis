using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jweller_loyality
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            date.Text = now.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {
            
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.ShowDialog();
            
        }


        private void newet_Click(object sender, EventArgs e)
        {
            newet.UseVisualStyleBackColor = false;
            newet.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
            create obj = new create();
            this.Hide();
            obj.ShowDialog();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            modify.UseVisualStyleBackColor = false;
            modify.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            delete.UseVisualStyleBackColor = false;
            delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.UseVisualStyleBackColor = false;
            search.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.ShowDialog();
        }

        private void modify_MouseEnter(object sender, EventArgs e)
        {
            modify.UseVisualStyleBackColor = false;
            modify.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void delete_MouseEnter(object sender, EventArgs e)
        {
            delete.UseVisualStyleBackColor = false;
            delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void search_MouseEnter(object sender, EventArgs e)
        {
            search.UseVisualStyleBackColor = false;
            search.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void reward_MouseEnter(object sender, EventArgs e)
        {
            al.UseVisualStyleBackColor = false;
            al.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.UseVisualStyleBackColor = false;
            exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void oldet_Click(object sender, EventArgs e)
        {
            oldet.UseVisualStyleBackColor = false;
            oldet.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
            old obj = new old();
            this.Hide();
            obj.ShowDialog();
        }

        private void al_Click(object sender, EventArgs e)
        {
            Analyze obj = new Analyze();
            this.Hide();
            obj.ShowDialog();
        }


       
    }
}
