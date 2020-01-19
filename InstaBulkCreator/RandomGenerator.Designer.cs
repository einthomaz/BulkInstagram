namespace InstaBulkCreator
{
    partial class RandomGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomGenerator));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSlider2 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuSlider3 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSlider4 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox3 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox4 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Number of Accounts : ";
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(12, 25);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(415, 28);
            this.bunifuSlider1.TabIndex = 1;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(9, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(97, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Username Length :";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuSlider2
            // 
            this.bunifuSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider2.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider2.BorderRadius = 0;
            this.bunifuSlider2.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider2.Location = new System.Drawing.Point(12, 72);
            this.bunifuSlider2.MaximumValue = 100;
            this.bunifuSlider2.Name = "bunifuSlider2";
            this.bunifuSlider2.Size = new System.Drawing.Size(415, 28);
            this.bunifuSlider2.TabIndex = 3;
            this.bunifuSlider2.Value = 0;
            this.bunifuSlider2.ValueChanged += new System.EventHandler(this.bunifuSlider2_ValueChanged);
            // 
            // bunifuSlider3
            // 
            this.bunifuSlider3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider3.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider3.BorderRadius = 0;
            this.bunifuSlider3.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider3.Location = new System.Drawing.Point(12, 122);
            this.bunifuSlider3.MaximumValue = 100;
            this.bunifuSlider3.Name = "bunifuSlider3";
            this.bunifuSlider3.Size = new System.Drawing.Size(415, 28);
            this.bunifuSlider3.TabIndex = 5;
            this.bunifuSlider3.Value = 0;
            this.bunifuSlider3.ValueChanged += new System.EventHandler(this.bunifuSlider3_ValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 106);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 13);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Password Length :";
            // 
            // bunifuSlider4
            // 
            this.bunifuSlider4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider4.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider4.BorderRadius = 0;
            this.bunifuSlider4.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider4.Location = new System.Drawing.Point(12, 178);
            this.bunifuSlider4.MaximumValue = 100;
            this.bunifuSlider4.Name = "bunifuSlider4";
            this.bunifuSlider4.Size = new System.Drawing.Size(415, 28);
            this.bunifuSlider4.TabIndex = 7;
            this.bunifuSlider4.Value = 0;
            this.bunifuSlider4.ValueChanged += new System.EventHandler(this.bunifuSlider4_ValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(9, 162);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(77, 13);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Email Length : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(433, 80);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 10;
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // bunifuCheckbox3
            // 
            this.bunifuCheckbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox3.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox3.Checked = true;
            this.bunifuCheckbox3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox3.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox3.Location = new System.Drawing.Point(433, 130);
            this.bunifuCheckbox3.Name = "bunifuCheckbox3";
            this.bunifuCheckbox3.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox3.TabIndex = 11;
            // 
            // bunifuCheckbox4
            // 
            this.bunifuCheckbox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox4.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox4.Checked = true;
            this.bunifuCheckbox4.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox4.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox4.Location = new System.Drawing.Point(433, 186);
            this.bunifuCheckbox4.Name = "bunifuCheckbox4";
            this.bunifuCheckbox4.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox4.TabIndex = 12;
            // 
            // RandomGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 273);
            this.Controls.Add(this.bunifuCheckbox4);
            this.Controls.Add(this.bunifuCheckbox3);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuSlider4);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuSlider3);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuSlider2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomGenerator";
            this.Text = "RandomGenerator";
            this.Load += new System.EventHandler(this.RandomGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider2;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox3;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}