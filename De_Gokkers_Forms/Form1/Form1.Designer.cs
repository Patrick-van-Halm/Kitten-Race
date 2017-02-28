namespace Form1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WedtPanel = new System.Windows.Forms.Panel();
            this.ColorChoose = new System.Windows.Forms.NumericUpDown();
            this.BedMoney = new System.Windows.Forms.NumericUpDown();
            this.go = new System.Windows.Forms.Button();
            this.wedt = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.MoneyBedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playerlabel3 = new System.Windows.Forms.Label();
            this.playerlabel2 = new System.Windows.Forms.Label();
            this.playerlabel1 = new System.Windows.Forms.Label();
            this.playerRadio2 = new System.Windows.Forms.RadioButton();
            this.playerRadio3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.playerRadio1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.WedtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // WedtPanel
            // 
            this.WedtPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WedtPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.WedtPanel.Controls.Add(this.ColorChoose);
            this.WedtPanel.Controls.Add(this.BedMoney);
            this.WedtPanel.Controls.Add(this.go);
            this.WedtPanel.Controls.Add(this.wedt);
            this.WedtPanel.Controls.Add(this.ColorBox);
            this.WedtPanel.Controls.Add(this.MoneyBedLabel);
            this.WedtPanel.Controls.Add(this.label5);
            this.WedtPanel.Controls.Add(this.playerlabel3);
            this.WedtPanel.Controls.Add(this.playerlabel2);
            this.WedtPanel.Controls.Add(this.playerlabel1);
            this.WedtPanel.Controls.Add(this.playerRadio2);
            this.WedtPanel.Controls.Add(this.playerRadio3);
            this.WedtPanel.Controls.Add(this.label1);
            this.WedtPanel.Controls.Add(this.playerRadio1);
            this.WedtPanel.Location = new System.Drawing.Point(0, 0);
            this.WedtPanel.Name = "WedtPanel";
            this.WedtPanel.Size = new System.Drawing.Size(251, 800);
            this.WedtPanel.TabIndex = 0;
            // 
            // ColorChoose
            // 
            this.ColorChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ColorChoose.Location = new System.Drawing.Point(12, 180);
            this.ColorChoose.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.ColorChoose.Name = "ColorChoose";
            this.ColorChoose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorChoose.Size = new System.Drawing.Size(18, 47);
            this.ColorChoose.TabIndex = 16;
            this.ColorChoose.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ColorChoose.ValueChanged += new System.EventHandler(this.ColorChoose_ValueChanged);
            // 
            // BedMoney
            // 
            this.BedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.BedMoney.Location = new System.Drawing.Point(12, 335);
            this.BedMoney.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BedMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.BedMoney.Name = "BedMoney";
            this.BedMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BedMoney.Size = new System.Drawing.Size(18, 47);
            this.BedMoney.TabIndex = 15;
            this.BedMoney.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(83, 497);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 14;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // wedt
            // 
            this.wedt.Location = new System.Drawing.Point(83, 454);
            this.wedt.Name = "wedt";
            this.wedt.Size = new System.Drawing.Size(75, 23);
            this.wedt.TabIndex = 13;
            this.wedt.Text = "WEDT";
            this.wedt.UseVisualStyleBackColor = true;
            this.wedt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.ColorBox.Location = new System.Drawing.Point(36, 180);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(191, 47);
            this.ColorBox.TabIndex = 12;
            this.ColorBox.TabStop = false;
            // 
            // MoneyBedLabel
            // 
            this.MoneyBedLabel.AutoSize = true;
            this.MoneyBedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyBedLabel.Location = new System.Drawing.Point(89, 335);
            this.MoneyBedLabel.Name = "MoneyBedLabel";
            this.MoneyBedLabel.Size = new System.Drawing.Size(60, 42);
            this.MoneyBedLabel.TabIndex = 11;
            this.MoneyBedLabel.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Minimal 5. Maximal 15";
            // 
            // playerlabel3
            // 
            this.playerlabel3.AutoSize = true;
            this.playerlabel3.Location = new System.Drawing.Point(33, 132);
            this.playerlabel3.Name = "playerlabel3";
            this.playerlabel3.Size = new System.Drawing.Size(35, 13);
            this.playerlabel3.TabIndex = 6;
            this.playerlabel3.Text = "label4";
            // 
            // playerlabel2
            // 
            this.playerlabel2.AutoSize = true;
            this.playerlabel2.Location = new System.Drawing.Point(33, 100);
            this.playerlabel2.Name = "playerlabel2";
            this.playerlabel2.Size = new System.Drawing.Size(35, 13);
            this.playerlabel2.TabIndex = 5;
            this.playerlabel2.Text = "label3";
            // 
            // playerlabel1
            // 
            this.playerlabel1.AutoSize = true;
            this.playerlabel1.Location = new System.Drawing.Point(33, 68);
            this.playerlabel1.Name = "playerlabel1";
            this.playerlabel1.Size = new System.Drawing.Size(35, 13);
            this.playerlabel1.TabIndex = 4;
            this.playerlabel1.Text = "label2";
            // 
            // playerRadio2
            // 
            this.playerRadio2.AutoSize = true;
            this.playerRadio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadio2.Location = new System.Drawing.Point(12, 100);
            this.playerRadio2.Name = "playerRadio2";
            this.playerRadio2.Size = new System.Drawing.Size(14, 13);
            this.playerRadio2.TabIndex = 3;
            this.playerRadio2.TabStop = true;
            this.playerRadio2.UseVisualStyleBackColor = true;
            // 
            // playerRadio3
            // 
            this.playerRadio3.AutoSize = true;
            this.playerRadio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playerRadio3.Location = new System.Drawing.Point(12, 131);
            this.playerRadio3.Name = "playerRadio3";
            this.playerRadio3.Size = new System.Drawing.Size(14, 13);
            this.playerRadio3.TabIndex = 2;
            this.playerRadio3.TabStop = true;
            this.playerRadio3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RONDE WIN:";
            // 
            // playerRadio1
            // 
            this.playerRadio1.AutoSize = true;
            this.playerRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadio1.Location = new System.Drawing.Point(12, 68);
            this.playerRadio1.Name = "playerRadio1";
            this.playerRadio1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerRadio1.Size = new System.Drawing.Size(14, 13);
            this.playerRadio1.TabIndex = 0;
            this.playerRadio1.TabStop = true;
            this.playerRadio1.UseVisualStyleBackColor = true;
            this.playerRadio1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(257, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(257, 256);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(257, 362);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(257, 468);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(257, 574);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(200, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WedtPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CAT-RACE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WedtPanel.ResumeLayout(false);
            this.WedtPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WedtPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton playerRadio1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label playerlabel3;
        private System.Windows.Forms.Label playerlabel2;
        private System.Windows.Forms.Label playerlabel1;
        private System.Windows.Forms.RadioButton playerRadio2;
        private System.Windows.Forms.RadioButton playerRadio3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.Label MoneyBedLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button wedt;
        private System.Windows.Forms.NumericUpDown BedMoney;
        private System.Windows.Forms.NumericUpDown ColorChoose;
    }
}

