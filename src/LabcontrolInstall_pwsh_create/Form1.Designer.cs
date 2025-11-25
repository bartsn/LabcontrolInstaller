namespace LabcontrolInstall
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
            this.tekstLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richOutBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tekstLabel1
            // 
            this.tekstLabel1.AutoSize = true;
            this.tekstLabel1.Location = new System.Drawing.Point(12, 9);
            this.tekstLabel1.Name = "tekstLabel1";
            this.tekstLabel1.Size = new System.Drawing.Size(129, 16);
            this.tekstLabel1.TabIndex = 1;
            this.tekstLabel1.Text = "Installatiemeldingen:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richOutBox
            // 
            this.richOutBox.Location = new System.Drawing.Point(1, 58);
            this.richOutBox.Name = "richOutBox";
            this.richOutBox.Size = new System.Drawing.Size(800, 323);
            this.richOutBox.TabIndex = 3;
            this.richOutBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richOutBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tekstLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tekstLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richOutBox;
    }
}

