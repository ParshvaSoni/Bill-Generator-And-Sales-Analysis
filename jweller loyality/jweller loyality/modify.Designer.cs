namespace jweller_loyality
{
    partial class modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modify));
            this.panel1 = new System.Windows.Forms.Panel();
            this.modvalue = new System.Windows.Forms.TextBox();
            this.modtxt = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.TextBox();
            this.v1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.ComboBox();
            this.s1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.modvalue);
            this.panel1.Controls.Add(this.modtxt);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.v2);
            this.panel1.Controls.Add(this.v1);
            this.panel1.Controls.Add(this.s2);
            this.panel1.Controls.Add(this.s1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 314);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // modvalue
            // 
            this.modvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modvalue.Location = new System.Drawing.Point(308, 221);
            this.modvalue.Multiline = true;
            this.modvalue.Name = "modvalue";
            this.modvalue.Size = new System.Drawing.Size(261, 28);
            this.modvalue.TabIndex = 11;
            // 
            // modtxt
            // 
            this.modtxt.AutoCompleteCustomSource.AddRange(new string[] {
            "CardNo",
            "Name1",
            "Name2",
            "Mob1",
            "Mob2",
            "Landline",
            "Address",
            "Area",
            "PIN",
            "Email",
            "Points",
            "TotalB",
            "Product"});
            this.modtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modtxt.FormattingEnabled = true;
            this.modtxt.Items.AddRange(new object[] {
            "CardNo",
            "Name1",
            "Name2",
            "Mob1",
            "Mob2",
            "Landline",
            "Address",
            "Area",
            "PIN",
            "Email",
            "Points",
            "TotalB",
            "Product"});
            this.modtxt.Location = new System.Drawing.Point(88, 221);
            this.modtxt.Name = "modtxt";
            this.modtxt.Size = new System.Drawing.Size(186, 28);
            this.modtxt.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // search
            // 
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(379, 151);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(113, 29);
            this.search.TabIndex = 8;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(255, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = " : -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = " : -";
            // 
            // v2
            // 
            this.v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v2.Location = new System.Drawing.Point(308, 109);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(261, 26);
            this.v2.TabIndex = 4;
            // 
            // v1
            // 
            this.v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v1.Location = new System.Drawing.Point(308, 66);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(261, 26);
            this.v1.TabIndex = 3;
            // 
            // s2
            // 
            this.s2.AutoCompleteCustomSource.AddRange(new string[] {
            "CardNo",
            "Mob1",
            "Mob2"});
            this.s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2.FormattingEnabled = true;
            this.s2.Items.AddRange(new object[] {
            "CardNo",
            "Mob1",
            "Mob2"});
            this.s2.Location = new System.Drawing.Point(88, 108);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(186, 28);
            this.s2.TabIndex = 2;
            this.s2.Text = "Mob1";
            // 
            // s1
            // 
            this.s1.AutoCompleteCustomSource.AddRange(new string[] {
            "CardNo",
            "Mob1",
            "Mob2"});
            this.s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1.FormattingEnabled = true;
            this.s1.Items.AddRange(new object[] {
            "CardNo",
            "Mob1",
            "Mob2"});
            this.s1.Location = new System.Drawing.Point(88, 66);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(186, 28);
            this.s1.TabIndex = 1;
            this.s1.Text = "CardNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Enter The following  Detials To Modify The Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = " : -";
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "modify";
            this.Text = "Modify DATA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox s1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.ComboBox s2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox modvalue;
        private System.Windows.Forms.ComboBox modtxt;
        private System.Windows.Forms.Label label5;
    }
}