using System.Drawing;
using System.Net.NetworkInformation;

namespace WindowsFormsApp3
{
    partial class Form4b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4b));
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customArrow4 = new WindowsFormsApp1.CustomArrow();
            this.customArrow3 = new WindowsFormsApp1.CustomArrow();
            this.customArrow2 = new WindowsFormsApp1.CustomArrow();
            this.customArrow1 = new WindowsFormsApp1.CustomArrow();
            this.customArcArrowcs2 = new WindowsFormsApp1.CustomArcArrowcs();
            this.customArcArrowcs1 = new WindowsFormsApp1.CustomArcArrowcs();
            this.customArrow5 = new WindowsFormsApp1.CustomArrow();
            this.customArrow6 = new WindowsFormsApp1.CustomArrow();
            this.customArrow7 = new WindowsFormsApp1.CustomArrow();
            this.customArrow9 = new WindowsFormsApp1.CustomArrow();
            this.customArrow10 = new WindowsFormsApp1.CustomArrow();
            this.bigCheckBox1 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox2 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox3 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox4 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox5 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox6 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox7 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox8 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox9 = new WindowsFormsApp1.BigCheckBox();
            this.customArrow8 = new WindowsFormsApp1.CustomArrow();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(449, 286);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(119, 77);
            this.textBox7.TabIndex = 19;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Installeren\r\nnoodzakelijke\r\nPython packages\r\n\r\n";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(285, 286);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 52);
            this.textBox6.TabIndex = 18;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Installeren\r\nVISA omgeving\r\nR&S\r\n";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(133, 286);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 72);
            this.textBox5.TabIndex = 17;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Downloaden en\r\ninstalleren\r\nLabcontrol\r\nPython Scripts\r\n";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(449, 45);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(107, 60);
            this.textBox4.TabIndex = 16;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Controle\r\nAanwezigheid\r\n7-zip omgeving\r\n\r\n";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(294, 45);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 60);
            this.textBox3.TabIndex = 15;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Controle\r\nAanwezigheid\r\ngit omgeving\r\n\r\n";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(449, 170);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 47);
            this.textBox2.TabIndex = 14;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Aanmaken \r\nTijdelijke\r\ndownload map\r\n";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(133, 170);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 47);
            this.textBox1.TabIndex = 13;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Installeren\r\nPython omgeving\r\nvoor labcontrol \r\n";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(140, 45);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 60);
            this.textBox8.TabIndex = 20;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Controle\r\nVoldoende\r\nschijfruimte";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(285, 167);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(107, 47);
            this.textBox9.TabIndex = 21;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Downloaden\r\nBenodigde\r\nInstallers\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 70);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(625, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // customArrow4
            // 
            this.customArrow4.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow4.Location = new System.Drawing.Point(522, 117);
            this.customArrow4.Margin = new System.Windows.Forms.Padding(0);
            this.customArrow4.Name = "customArrow4";
            this.customArrow4.Size = new System.Drawing.Size(42, 18);
            this.customArrow4.swappen = 0;
            this.customArrow4.TabIndex = 29;
            this.customArrow4.UseVisualStyleBackColor = false;
            // 
            // customArrow3
            // 
            this.customArrow3.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow3.Location = new System.Drawing.Point(370, 120);
            this.customArrow3.Name = "customArrow3";
            this.customArrow3.Size = new System.Drawing.Size(75, 23);
            this.customArrow3.swappen = 0;
            this.customArrow3.TabIndex = 28;
            this.customArrow3.UseVisualStyleBackColor = false;
            // 
            // customArrow2
            // 
            this.customArrow2.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow2.Location = new System.Drawing.Point(222, 120);
            this.customArrow2.Name = "customArrow2";
            this.customArrow2.Size = new System.Drawing.Size(75, 23);
            this.customArrow2.swappen = 0;
            this.customArrow2.TabIndex = 27;
            this.customArrow2.UseVisualStyleBackColor = false;
            // 
            // customArrow1
            // 
            this.customArrow1.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow1.Location = new System.Drawing.Point(73, 120);
            this.customArrow1.Name = "customArrow1";
            this.customArrow1.Size = new System.Drawing.Size(61, 23);
            this.customArrow1.swappen = 0;
            this.customArrow1.TabIndex = 26;
            this.customArrow1.UseVisualStyleBackColor = false;
            // 
            // customArcArrowcs2
            // 
            this.customArcArrowcs2.endAngle = 180;
            this.customArcArrowcs2.Location = new System.Drawing.Point(50, 236);
            this.customArcArrowcs2.Name = "customArcArrowcs2";
            this.customArcArrowcs2.Padding = new System.Windows.Forms.Padding(5);
            this.customArcArrowcs2.Size = new System.Drawing.Size(79, 149);
            this.customArcArrowcs2.startAngle = 0;
            this.customArcArrowcs2.swappen = 1;
            this.customArcArrowcs2.TabIndex = 25;
            this.customArcArrowcs2.Text = "customArcArrowcs2";
            this.customArcArrowcs2.UseVisualStyleBackColor = true;
            // 
            // customArcArrowcs1
            // 
            this.customArcArrowcs1.endAngle = 180;
            this.customArcArrowcs1.Location = new System.Drawing.Point(568, 120);
            this.customArcArrowcs1.Name = "customArcArrowcs1";
            this.customArcArrowcs1.Padding = new System.Windows.Forms.Padding(5);
            this.customArcArrowcs1.Size = new System.Drawing.Size(93, 135);
            this.customArcArrowcs1.startAngle = 0;
            this.customArcArrowcs1.swappen = 0;
            this.customArcArrowcs1.TabIndex = 24;
            this.customArcArrowcs1.Text = "customArcArrowcs1";
            this.customArcArrowcs1.UseVisualStyleBackColor = true;
            // 
            // customArrow5
            // 
            this.customArrow5.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow5.Location = new System.Drawing.Point(519, 238);
            this.customArrow5.Name = "customArrow5";
            this.customArrow5.Size = new System.Drawing.Size(47, 23);
            this.customArrow5.swappen = 1;
            this.customArrow5.TabIndex = 30;
            this.customArrow5.UseVisualStyleBackColor = false;
            // 
            // customArrow6
            // 
            this.customArrow6.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow6.Location = new System.Drawing.Point(370, 238);
            this.customArrow6.Name = "customArrow6";
            this.customArrow6.Size = new System.Drawing.Size(75, 23);
            this.customArrow6.swappen = 1;
            this.customArrow6.TabIndex = 31;
            this.customArrow6.UseVisualStyleBackColor = false;
            // 
            // customArrow7
            // 
            this.customArrow7.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow7.Location = new System.Drawing.Point(213, 232);
            this.customArrow7.Name = "customArrow7";
            this.customArrow7.Size = new System.Drawing.Size(75, 23);
            this.customArrow7.swappen = 1;
            this.customArrow7.TabIndex = 32;
            this.customArrow7.UseVisualStyleBackColor = false;
            // 
            // customArrow9
            // 
            this.customArrow9.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow9.Location = new System.Drawing.Point(213, 374);
            this.customArrow9.Name = "customArrow9";
            this.customArrow9.Size = new System.Drawing.Size(75, 23);
            this.customArrow9.swappen = 0;
            this.customArrow9.TabIndex = 34;
            this.customArrow9.UseVisualStyleBackColor = false;
            // 
            // customArrow10
            // 
            this.customArrow10.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow10.Location = new System.Drawing.Point(547, 374);
            this.customArrow10.Name = "customArrow10";
            this.customArrow10.Size = new System.Drawing.Size(72, 23);
            this.customArrow10.swappen = 0;
            this.customArrow10.TabIndex = 35;
            this.customArrow10.UseVisualStyleBackColor = false;
            // 
            // bigCheckBox1
            // 
            this.bigCheckBox1.Checked = true;
            this.bigCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox1.Location = new System.Drawing.Point(135, 356);
            this.bigCheckBox1.Name = "bigCheckBox1";
            this.bigCheckBox1.Size = new System.Drawing.Size(76, 60);
            this.bigCheckBox1.TabIndex = 36;
            this.bigCheckBox1.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox2
            // 
            this.bigCheckBox2.Checked = true;
            this.bigCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox2.Location = new System.Drawing.Point(140, 104);
            this.bigCheckBox2.Name = "bigCheckBox2";
            this.bigCheckBox2.Size = new System.Drawing.Size(64, 60);
            this.bigCheckBox2.TabIndex = 37;
            this.bigCheckBox2.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox3
            // 
            this.bigCheckBox3.Checked = true;
            this.bigCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox3.Location = new System.Drawing.Point(285, 102);
            this.bigCheckBox3.Name = "bigCheckBox3";
            this.bigCheckBox3.Size = new System.Drawing.Size(75, 60);
            this.bigCheckBox3.TabIndex = 38;
            this.bigCheckBox3.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox4
            // 
            this.bigCheckBox4.Checked = true;
            this.bigCheckBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox4.Location = new System.Drawing.Point(455, 97);
            this.bigCheckBox4.Name = "bigCheckBox4";
            this.bigCheckBox4.Size = new System.Drawing.Size(64, 60);
            this.bigCheckBox4.TabIndex = 39;
            this.bigCheckBox4.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox5
            // 
            this.bigCheckBox5.Checked = true;
            this.bigCheckBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox5.Location = new System.Drawing.Point(455, 220);
            this.bigCheckBox5.Name = "bigCheckBox5";
            this.bigCheckBox5.Size = new System.Drawing.Size(65, 60);
            this.bigCheckBox5.TabIndex = 40;
            this.bigCheckBox5.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox6
            // 
            this.bigCheckBox6.Checked = true;
            this.bigCheckBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox6.Location = new System.Drawing.Point(294, 220);
            this.bigCheckBox6.Name = "bigCheckBox6";
            this.bigCheckBox6.Size = new System.Drawing.Size(66, 60);
            this.bigCheckBox6.TabIndex = 41;
            this.bigCheckBox6.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox7
            // 
            this.bigCheckBox7.Checked = true;
            this.bigCheckBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox7.Location = new System.Drawing.Point(140, 220);
            this.bigCheckBox7.Name = "bigCheckBox7";
            this.bigCheckBox7.Size = new System.Drawing.Size(60, 60);
            this.bigCheckBox7.TabIndex = 42;
            this.bigCheckBox7.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox8
            // 
            this.bigCheckBox8.Checked = true;
            this.bigCheckBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox8.Location = new System.Drawing.Point(455, 356);
            this.bigCheckBox8.Name = "bigCheckBox8";
            this.bigCheckBox8.Size = new System.Drawing.Size(70, 60);
            this.bigCheckBox8.TabIndex = 43;
            this.bigCheckBox8.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox9
            // 
            this.bigCheckBox9.Checked = true;
            this.bigCheckBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox9.Location = new System.Drawing.Point(294, 356);
            this.bigCheckBox9.Name = "bigCheckBox9";
            this.bigCheckBox9.Size = new System.Drawing.Size(66, 60);
            this.bigCheckBox9.TabIndex = 44;
            this.bigCheckBox9.UseVisualStyleBackColor = true;
            // 
            // customArrow8
            // 
            this.customArrow8.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow8.Location = new System.Drawing.Point(374, 374);
            this.customArrow8.Name = "customArrow8";
            this.customArrow8.Size = new System.Drawing.Size(75, 23);
            this.customArrow8.swappen = 0;
            this.customArrow8.TabIndex = 45;
            this.customArrow8.UseVisualStyleBackColor = false;
            // 
            // Form4b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customArrow8);
            this.Controls.Add(this.bigCheckBox9);
            this.Controls.Add(this.bigCheckBox8);
            this.Controls.Add(this.bigCheckBox6);
            this.Controls.Add(this.customArrow10);
            this.Controls.Add(this.customArrow9);
            this.Controls.Add(this.customArrow7);
            this.Controls.Add(this.customArrow6);
            this.Controls.Add(this.customArrow5);
            this.Controls.Add(this.customArrow4);
            this.Controls.Add(this.customArrow3);
            this.Controls.Add(this.customArrow2);
            this.Controls.Add(this.customArrow1);
            this.Controls.Add(this.customArcArrowcs2);
            this.Controls.Add(this.customArcArrowcs1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bigCheckBox1);
            this.Controls.Add(this.bigCheckBox2);
            this.Controls.Add(this.bigCheckBox3);
            this.Controls.Add(this.bigCheckBox4);
            this.Controls.Add(this.bigCheckBox5);
            this.Controls.Add(this.bigCheckBox7);
            this.Name = "Form4b";
            this.Text = "Form4b";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private WindowsFormsApp1.CustomArcArrowcs customArcArrowcs1;
        private WindowsFormsApp1.CustomArcArrowcs customArcArrowcs2;
        private WindowsFormsApp1.CustomArrow customArrow1;
        private WindowsFormsApp1.CustomArrow customArrow2;
        private WindowsFormsApp1.CustomArrow customArrow3;
        private WindowsFormsApp1.CustomArrow customArrow4;
        private WindowsFormsApp1.CustomArrow customArrow5;
        private WindowsFormsApp1.CustomArrow customArrow6;
        private WindowsFormsApp1.CustomArrow customArrow7;
        private WindowsFormsApp1.CustomArrow customArrow9;
        private WindowsFormsApp1.CustomArrow customArrow10;
        private WindowsFormsApp1.BigCheckBox bigCheckBox1;
        private WindowsFormsApp1.BigCheckBox bigCheckBox2;
        private WindowsFormsApp1.BigCheckBox bigCheckBox3;
        private WindowsFormsApp1.BigCheckBox bigCheckBox4;
        private WindowsFormsApp1.BigCheckBox bigCheckBox5;
        private WindowsFormsApp1.BigCheckBox bigCheckBox6;
        private WindowsFormsApp1.BigCheckBox bigCheckBox7;
        private WindowsFormsApp1.BigCheckBox bigCheckBox8;
        private WindowsFormsApp1.BigCheckBox bigCheckBox9;
        private WindowsFormsApp1.CustomArrow customArrow8;
    }
}