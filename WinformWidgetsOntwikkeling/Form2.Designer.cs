namespace WindowsFormsApp1
{
    partial class Form2
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.customArcArrowcs1 = new WindowsFormsApp1.CustomArcArrowcs();
            this.customArrow1 = new WindowsFormsApp1.CustomArrow();
            this.bigCheckBox2 = new WindowsFormsApp1.BigCheckBox();
            this.bigCheckBox1 = new WindowsFormsApp1.BigCheckBox();
            this.customControl12 = new WindowsFormsApp1.CustomControl1();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(443, 192);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.MinimumSize = new System.Drawing.Size(107, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 111);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.checkBox1_Paint);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(617, 360);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // customArcArrowcs1
            // 
            this.customArcArrowcs1.endAngle = 180;
            this.customArcArrowcs1.Location = new System.Drawing.Point(378, 297);
            this.customArcArrowcs1.Name = "customArcArrowcs1";
            this.customArcArrowcs1.Padding = new System.Windows.Forms.Padding(5);
            this.customArcArrowcs1.Size = new System.Drawing.Size(143, 133);
            this.customArcArrowcs1.startAngle = 0;
            this.customArcArrowcs1.swappen = 0;
            this.customArcArrowcs1.TabIndex = 6;
            this.customArcArrowcs1.Text = "customArcArrowcs1";
            this.customArcArrowcs1.UseVisualStyleBackColor = true;
            // 
            // customArrow1
            // 
            this.customArrow1.BackColor = System.Drawing.SystemColors.Control;
            this.customArrow1.Enabled = false;
            this.customArrow1.FlatAppearance.BorderSize = 0;
            this.customArrow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customArrow1.Location = new System.Drawing.Point(443, 51);
            this.customArrow1.Name = "customArrow1";
            this.customArrow1.Size = new System.Drawing.Size(590, 162);
            this.customArrow1.TabIndex = 5;
            this.customArrow1.Text = "customArrow1";
            this.customArrow1.UseVisualStyleBackColor = false;
            // 
            // bigCheckBox2
            // 
            this.bigCheckBox2.Checked = true;
            this.bigCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigCheckBox2.Location = new System.Drawing.Point(839, 253);
            this.bigCheckBox2.Name = "bigCheckBox2";
            this.bigCheckBox2.Size = new System.Drawing.Size(160, 127);
            this.bigCheckBox2.TabIndex = 3;
            this.bigCheckBox2.Text = "bigCheckBox2";
            this.bigCheckBox2.UseVisualStyleBackColor = true;
            // 
            // bigCheckBox1
            // 
            this.bigCheckBox1.AutoSize = true;
            this.bigCheckBox1.Location = new System.Drawing.Point(126, 283);
            this.bigCheckBox1.Name = "bigCheckBox1";
            this.bigCheckBox1.Size = new System.Drawing.Size(116, 20);
            this.bigCheckBox1.TabIndex = 2;
            this.bigCheckBox1.Text = "bigCheckBox1";
            this.bigCheckBox1.UseVisualStyleBackColor = true;
            // 
            // customControl12
            // 
            this.customControl12.Location = new System.Drawing.Point(187, 123);
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(249, 111);
            this.customControl12.TabIndex = 1;
            this.customControl12.Text = "customControl12";
            this.customControl12.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.customArcArrowcs1);
            this.Controls.Add(this.customArrow1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.bigCheckBox2);
            this.Controls.Add(this.bigCheckBox1);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.checkBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControl1 customControl11;
        private CustomControl1 customControl12;
        private BigCheckBox bigCheckBox1;
        private BigCheckBox bigCheckBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private CustomArrow customArrow1;
        private CustomArcArrowcs customArcArrowcs1;
    }
}