namespace jweller_loyality
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oldet = new System.Windows.Forms.Button();
            this.newet = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.al = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.al);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.modify);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(34, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Toogles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.oldet);
            this.panel1.Controls.Add(this.newet);
            this.panel1.Location = new System.Drawing.Point(82, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 73);
            this.panel1.TabIndex = 3;
            // 
            // oldet
            // 
            this.oldet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.oldet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oldet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldet.ForeColor = System.Drawing.Color.Silver;
            this.oldet.Location = new System.Drawing.Point(3, 33);
            this.oldet.Name = "oldet";
            this.oldet.Size = new System.Drawing.Size(115, 31);
            this.oldet.TabIndex = 5;
            this.oldet.Text = "Old Entry";
            this.oldet.UseVisualStyleBackColor = true;
            this.oldet.Click += new System.EventHandler(this.oldet_Click);
            // 
            // newet
            // 
            this.newet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newet.ForeColor = System.Drawing.Color.Silver;
            this.newet.Location = new System.Drawing.Point(3, 3);
            this.newet.Name = "newet";
            this.newet.Size = new System.Drawing.Size(115, 31);
            this.newet.TabIndex = 4;
            this.newet.Text = "New Entry";
            this.newet.UseVisualStyleBackColor = true;
            this.newet.Click += new System.EventHandler(this.newet_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Silver;
            this.search.Location = new System.Drawing.Point(82, 223);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(123, 77);
            this.search.TabIndex = 2;
            this.search.Text = "Search Record";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.MouseEnter += new System.EventHandler(this.search_MouseEnter);
            // 
            // al
            // 
            this.al.Cursor = System.Windows.Forms.Cursors.Hand;
            this.al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.al.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.al.ForeColor = System.Drawing.Color.Silver;
            this.al.Location = new System.Drawing.Point(278, 223);
            this.al.Name = "al";
            this.al.Size = new System.Drawing.Size(131, 77);
            this.al.TabIndex = 2;
            this.al.Text = "Analyze";
            this.al.UseVisualStyleBackColor = true;
            this.al.Click += new System.EventHandler(this.al_Click);
            this.al.MouseEnter += new System.EventHandler(this.reward_MouseEnter);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Silver;
            this.exit.Location = new System.Drawing.Point(478, 223);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(122, 77);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Silver;
            this.delete.Location = new System.Drawing.Point(478, 82);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 75);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete Record";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseEnter += new System.EventHandler(this.delete_MouseEnter);
            // 
            // modify
            // 
            this.modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.ForeColor = System.Drawing.Color.Silver;
            this.modify.Location = new System.Drawing.Point(278, 82);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(131, 75);
            this.modify.TabIndex = 2;
            this.modify.Text = "Modify Record";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            this.modify.MouseEnter += new System.EventHandler(this.modify_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(509, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date :";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Gray;
            this.date.Location = new System.Drawing.Point(568, 36);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(170, 18);
            this.date.TabIndex = 2;
            this.date.Text = "__________________";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 485);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button al;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button oldet;
        private System.Windows.Forms.Button newet;
    }
}