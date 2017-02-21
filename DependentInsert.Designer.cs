namespace DBSProject
{
    partial class DependentInsert
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_text = new System.Windows.Forms.TextBox();
            this.dep_text = new System.Windows.Forms.TextBox();
            this.Dob = new System.Windows.Forms.TextBox();
            this.Rel_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_butt = new System.Windows.Forms.Button();
            this.close_butt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DependentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeeID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DependentDOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Relation";
            // 
            // emp_text
            // 
            this.emp_text.Location = new System.Drawing.Point(333, 104);
            this.emp_text.Name = "emp_text";
            this.emp_text.Size = new System.Drawing.Size(100, 20);
            this.emp_text.TabIndex = 4;
            this.emp_text.TextChanged += new System.EventHandler(this.emp_text_TextChanged);
            // 
            // dep_text
            // 
            this.dep_text.Location = new System.Drawing.Point(333, 148);
            this.dep_text.Name = "dep_text";
            this.dep_text.Size = new System.Drawing.Size(100, 20);
            this.dep_text.TabIndex = 5;
            this.dep_text.TextChanged += new System.EventHandler(this.dep_text_TextChanged);
            // 
            // Dob
            // 
            this.Dob.Location = new System.Drawing.Point(333, 186);
            this.Dob.Name = "Dob";
            this.Dob.Size = new System.Drawing.Size(100, 20);
            this.Dob.TabIndex = 6;
            this.Dob.TextChanged += new System.EventHandler(this.Dob_TextChanged);
            // 
            // Rel_text
            // 
            this.Rel_text.Location = new System.Drawing.Point(333, 224);
            this.Rel_text.Name = "Rel_text";
            this.Rel_text.Size = new System.Drawing.Size(100, 20);
            this.Rel_text.TabIndex = 7;
            this.Rel_text.TextChanged += new System.EventHandler(this.Rel_text_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "DEPENDENT INSERTION";
            // 
            // insert_butt
            // 
            this.insert_butt.Location = new System.Drawing.Point(160, 311);
            this.insert_butt.Name = "insert_butt";
            this.insert_butt.Size = new System.Drawing.Size(75, 23);
            this.insert_butt.TabIndex = 9;
            this.insert_butt.Text = "Insert";
            this.insert_butt.UseVisualStyleBackColor = true;
            this.insert_butt.Click += new System.EventHandler(this.insert_butt_Click);
            // 
            // close_butt
            // 
            this.close_butt.Location = new System.Drawing.Point(333, 311);
            this.close_butt.Name = "close_butt";
            this.close_butt.Size = new System.Drawing.Size(75, 23);
            this.close_butt.TabIndex = 10;
            this.close_butt.Text = "Close";
            this.close_butt.UseVisualStyleBackColor = true;
            this.close_butt.Click += new System.EventHandler(this.close_butt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "yyyy-mm-dd";
            // 
            // DependentInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSProject.Properties.Resources.dependent1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.close_butt);
            this.Controls.Add(this.insert_butt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rel_text);
            this.Controls.Add(this.Dob);
            this.Controls.Add(this.dep_text);
            this.Controls.Add(this.emp_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DependentInsert";
            this.Text = "DependentInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emp_text;
        private System.Windows.Forms.TextBox dep_text;
        private System.Windows.Forms.TextBox Dob;
        private System.Windows.Forms.TextBox Rel_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert_butt;
        private System.Windows.Forms.Button close_butt;
        private System.Windows.Forms.Label label6;
    }
}