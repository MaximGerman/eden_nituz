namespace Example_Project
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
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Name_label1 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Job_label2 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID_label.Location = new System.Drawing.Point(814, 95);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(97, 19);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = " תעודת זהות";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID_textBox.Location = new System.Drawing.Point(661, 136);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(213, 23);
            this.ID_textBox.TabIndex = 3;
            this.ID_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ID_textBox.TextChanged += new System.EventHandler(this.ID_textBox_TextChanged);
            // 
            // Name_label1
            // 
            this.Name_label1.AutoSize = true;
            this.Name_label1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name_label1.Location = new System.Drawing.Point(844, 194);
            this.Name_label1.Name = "Name_label1";
            this.Name_label1.Size = new System.Drawing.Size(67, 19);
            this.Name_label1.TabIndex = 4;
            this.Name_label1.Text = "שם מלא";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name_textBox.Location = new System.Drawing.Point(661, 239);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(213, 23);
            this.Name_textBox.TabIndex = 5;
            this.Name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Job_label2
            // 
            this.Job_label2.AutoSize = true;
            this.Job_label2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Job_label2.Location = new System.Drawing.Point(857, 304);
            this.Job_label2.Name = "Job_label2";
            this.Job_label2.Size = new System.Drawing.Size(54, 19);
            this.Job_label2.TabIndex = 6;
            this.Job_label2.Text = "תפקיד";
            // 
            // Add_button
            // 
            this.Add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Add_button.Location = new System.Drawing.Point(117, 200);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(211, 97);
            this.Add_button.TabIndex = 8;
            this.Add_button.Text = "הוסף למערכת";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(191, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 63);
            this.label3.TabIndex = 9;
            this.label3.Text = "הזן את הפרטים הבאים";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(661, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(407, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "חזרה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Job_label2);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name_label1);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.ID_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label Name_label1;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Job_label2;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}