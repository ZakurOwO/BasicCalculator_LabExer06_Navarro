namespace BasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxInput1 = new System.Windows.Forms.RichTextBox();
            this.ComboBoxData = new System.Windows.Forms.ComboBox();
            this.TextBoxInput2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultTotal = new System.Windows.Forms.Label();
            this.ComputeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // TextBoxInput1
            // 
            this.TextBoxInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.TextBoxInput1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInput1.Location = new System.Drawing.Point(22, 59);
            this.TextBoxInput1.Name = "TextBoxInput1";
            this.TextBoxInput1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxInput1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextBoxInput1.Size = new System.Drawing.Size(349, 51);
            this.TextBoxInput1.TabIndex = 1;
            this.TextBoxInput1.Text = "";
            this.TextBoxInput1.TextChanged += new System.EventHandler(this.TextBoxInput1_TextChanged);
            // 
            // ComboBoxData
            // 
            this.ComboBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.ComboBoxData.FormattingEnabled = true;
            this.ComboBoxData.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.ComboBoxData.Location = new System.Drawing.Point(132, 116);
            this.ComboBoxData.Name = "ComboBoxData";
            this.ComboBoxData.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxData.TabIndex = 2;
            this.ComboBoxData.SelectedIndexChanged += new System.EventHandler(this.ComboBoxData_SelectedIndexChanged);
            // 
            // TextBoxInput2
            // 
            this.TextBoxInput2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.TextBoxInput2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.TextBoxInput2.Location = new System.Drawing.Point(22, 143);
            this.TextBoxInput2.Name = "TextBoxInput2";
            this.TextBoxInput2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxInput2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextBoxInput2.Size = new System.Drawing.Size(349, 51);
            this.TextBoxInput2.TabIndex = 3;
            this.TextBoxInput2.Text = "";
            this.TextBoxInput2.TextChanged += new System.EventHandler(this.TextBoxInput2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(22, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 93);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(28, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // ResultTotal
            // 
            this.ResultTotal.AutoSize = true;
            this.ResultTotal.BackColor = System.Drawing.Color.Black;
            this.ResultTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.ResultTotal.ForeColor = System.Drawing.Color.Lime;
            this.ResultTotal.Location = new System.Drawing.Point(28, 251);
            this.ResultTotal.Name = "ResultTotal";
            this.ResultTotal.Size = new System.Drawing.Size(98, 31);
            this.ResultTotal.TabIndex = 6;
            this.ResultTotal.Text = "000000";
            this.ResultTotal.Click += new System.EventHandler(this.ResultTotal_Click);
            // 
            // ComputeBTN
            // 
            this.ComputeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.ComputeBTN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ComputeBTN.Location = new System.Drawing.Point(135, 314);
            this.ComputeBTN.Name = "ComputeBTN";
            this.ComputeBTN.Size = new System.Drawing.Size(110, 31);
            this.ComputeBTN.TabIndex = 7;
            this.ComputeBTN.Text = "Compute";
            this.ComputeBTN.UseVisualStyleBackColor = false;
            this.ComputeBTN.Click += new System.EventHandler(this.ComputeBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(381, 357);
            this.Controls.Add(this.ComputeBTN);
            this.Controls.Add(this.ResultTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxInput2);
            this.Controls.Add(this.ComboBoxData);
            this.Controls.Add(this.TextBoxInput1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextBoxInput1;
        private System.Windows.Forms.ComboBox ComboBoxData;
        private System.Windows.Forms.RichTextBox TextBoxInput2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultTotal;
        private System.Windows.Forms.Button ComputeBTN;
    }
}

