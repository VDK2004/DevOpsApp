
namespace WinformVoetbal
{
    partial class frmVoetbal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbthuisPloeg = new System.Windows.Forms.ComboBox();
            this.cbuitPloeg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doelpuntenThuis = new System.Windows.Forms.TextBox();
            this.doelpuntenUit = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Away Team";
            // 
            // cbthuisPloeg
            // 
            this.cbthuisPloeg.FormattingEnabled = true;
            this.cbthuisPloeg.Location = new System.Drawing.Point(195, 132);
            this.cbthuisPloeg.Margin = new System.Windows.Forms.Padding(4);
            this.cbthuisPloeg.Name = "cbthuisPloeg";
            this.cbthuisPloeg.Size = new System.Drawing.Size(160, 24);
            this.cbthuisPloeg.TabIndex = 2;
            // 
            // cbuitPloeg
            // 
            this.cbuitPloeg.FormattingEnabled = true;
            this.cbuitPloeg.Location = new System.Drawing.Point(728, 132);
            this.cbuitPloeg.Margin = new System.Windows.Forms.Padding(4);
            this.cbuitPloeg.Name = "cbuitPloeg";
            this.cbuitPloeg.Size = new System.Drawing.Size(160, 24);
            this.cbuitPloeg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Goals:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Goals:";
            // 
            // doelpuntenThuis
            // 
            this.doelpuntenThuis.Location = new System.Drawing.Point(195, 203);
            this.doelpuntenThuis.Margin = new System.Windows.Forms.Padding(4);
            this.doelpuntenThuis.Name = "doelpuntenThuis";
            this.doelpuntenThuis.Size = new System.Drawing.Size(132, 22);
            this.doelpuntenThuis.TabIndex = 6;
            // 
            // doelpuntenUit
            // 
            this.doelpuntenUit.Location = new System.Drawing.Point(728, 207);
            this.doelpuntenUit.Margin = new System.Windows.Forms.Padding(4);
            this.doelpuntenUit.Name = "doelpuntenUit";
            this.doelpuntenUit.Size = new System.Drawing.Size(132, 22);
            this.doelpuntenUit.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(405, 260);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(291, 378);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 164);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmVoetbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.doelpuntenUit);
            this.Controls.Add(this.doelpuntenThuis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbuitPloeg);
            this.Controls.Add(this.cbthuisPloeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVoetbal";
            this.Text = "Voetbal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbthuisPloeg;
        private System.Windows.Forms.ComboBox cbuitPloeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doelpuntenThuis;
        private System.Windows.Forms.TextBox doelpuntenUit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

