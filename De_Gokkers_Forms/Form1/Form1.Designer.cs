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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioName1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.RadioName4 = new System.Windows.Forms.RadioButton();
            this.RadioName3 = new System.Windows.Forms.RadioButton();
            this.RadioName2 = new System.Windows.Forms.RadioButton();
            this.Minimum = new System.Windows.Forms.Label();
            this.WedBureau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RadioName1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RadioName4);
            this.panel1.Controls.Add(this.RadioName3);
            this.panel1.Controls.Add(this.RadioName2);
            this.panel1.Controls.Add(this.Minimum);
            this.panel1.Controls.Add(this.WedBureau);
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 156);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(457, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weddenschappen";
            // 
            // RadioName1
            // 
            this.RadioName1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioName1.AutoSize = true;
            this.RadioName1.Location = new System.Drawing.Point(7, 40);
            this.RadioName1.Name = "RadioName1";
            this.RadioName1.Size = new System.Drawing.Size(85, 17);
            this.RadioName1.TabIndex = 7;
            this.RadioName1.TabStop = true;
            this.RadioName1.Text = "radioButton4";
            this.RadioName1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Euro op Lane";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(74, 131);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(7, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "WEDT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RadioName4
            // 
            this.RadioName4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioName4.AutoSize = true;
            this.RadioName4.Location = new System.Drawing.Point(7, 109);
            this.RadioName4.Name = "RadioName4";
            this.RadioName4.Size = new System.Drawing.Size(85, 17);
            this.RadioName4.TabIndex = 4;
            this.RadioName4.TabStop = true;
            this.RadioName4.Text = "radioButton3";
            this.RadioName4.UseVisualStyleBackColor = true;
            // 
            // RadioName3
            // 
            this.RadioName3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioName3.AutoSize = true;
            this.RadioName3.Location = new System.Drawing.Point(7, 86);
            this.RadioName3.Name = "RadioName3";
            this.RadioName3.Size = new System.Drawing.Size(85, 17);
            this.RadioName3.TabIndex = 3;
            this.RadioName3.TabStop = true;
            this.RadioName3.Text = "radioButton2";
            this.RadioName3.UseVisualStyleBackColor = true;
            // 
            // RadioName2
            // 
            this.RadioName2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioName2.AutoSize = true;
            this.RadioName2.Location = new System.Drawing.Point(7, 63);
            this.RadioName2.Name = "RadioName2";
            this.RadioName2.Size = new System.Drawing.Size(85, 17);
            this.RadioName2.TabIndex = 2;
            this.RadioName2.TabStop = true;
            this.RadioName2.Text = "radioButton1";
            this.RadioName2.UseVisualStyleBackColor = true;
            // 
            // Minimum
            // 
            this.Minimum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Minimum.AutoSize = true;
            this.Minimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Minimum.Location = new System.Drawing.Point(4, 21);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(146, 17);
            this.Minimum.TabIndex = 1;
            this.Minimum.Text = "Minimum inzet: 5 euro";
            // 
            // WedBureau
            // 
            this.WedBureau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WedBureau.AutoSize = true;
            this.WedBureau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WedBureau.Location = new System.Drawing.Point(4, 4);
            this.WedBureau.Name = "WedBureau";
            this.WedBureau.Size = new System.Drawing.Size(82, 17);
            this.WedBureau.TabIndex = 0;
            this.WedBureau.Text = "Wedbureau";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name wedt {0} op {1}";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name wedt {0} op {1}";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name wedt {0} op {1}";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name wedt {0} op {1}";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(530, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "GO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown2.Location = new System.Drawing.Point(196, 131);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 255);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(555, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "There is a maximum of 15 Euro and a Minimum of 5 Euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 409);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "NAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RadioName4;
        private System.Windows.Forms.RadioButton RadioName3;
        private System.Windows.Forms.RadioButton RadioName2;
        private System.Windows.Forms.Label Minimum;
        private System.Windows.Forms.Label WedBureau;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}

