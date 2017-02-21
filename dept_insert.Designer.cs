namespace DBSProject
{
    partial class dept_insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dept_insert));
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Depid = new System.Windows.Forms.TextBox();
            this.nameTesxtBox = new System.Windows.Forms.TextBox();
            this.Locationtextbox = new System.Windows.Forms.TextBox();
            this.ManID = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerTextBox
            // 
            this.headerTextBox.BackColor = System.Drawing.Color.White;
            this.headerTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerTextBox.Location = new System.Drawing.Point(135, 38);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(163, 24);
            this.headerTextBox.TabIndex = 0;
            this.headerTextBox.Text = "Department Insertion";
            this.headerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEPT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DEPT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOCATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MANAGER ID";
            // 
            // Depid
            // 
            this.Depid.Location = new System.Drawing.Point(241, 102);
            this.Depid.Name = "Depid";
            this.Depid.Size = new System.Drawing.Size(100, 20);
            this.Depid.TabIndex = 5;
            this.Depid.TextChanged += new System.EventHandler(this.Depid_TextChanged);
            // 
            // nameTesxtBox
            // 
            this.nameTesxtBox.Location = new System.Drawing.Point(241, 141);
            this.nameTesxtBox.Name = "nameTesxtBox";
            this.nameTesxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTesxtBox.TabIndex = 6;
            this.nameTesxtBox.TextChanged += new System.EventHandler(this.nameTesxtBox_TextChanged);
            // 
            // Locationtextbox
            // 
            this.Locationtextbox.Location = new System.Drawing.Point(241, 177);
            this.Locationtextbox.Name = "Locationtextbox";
            this.Locationtextbox.Size = new System.Drawing.Size(100, 20);
            this.Locationtextbox.TabIndex = 7;
            this.Locationtextbox.TextChanged += new System.EventHandler(this.Locationtextbox_TextChanged);
            // 
            // ManID
            // 
            this.ManID.Location = new System.Drawing.Point(241, 213);
            this.ManID.Name = "ManID";
            this.ManID.Size = new System.Drawing.Size(100, 20);
            this.ManID.TabIndex = 8;
            this.ManID.TextChanged += new System.EventHandler(this.ManID_TextChanged);
            // 
            // insert_button
            // 
            this.insert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.Location = new System.Drawing.Point(60, 280);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 9;
            this.insert_button.Text = "INSERT";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(184, 280);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(313, 280);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 11;
            this.close_button.Text = "CLOSE";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dept_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(448, 387);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.ManID);
            this.Controls.Add(this.Locationtextbox);
            this.Controls.Add(this.nameTesxtBox);
            this.Controls.Add(this.Depid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerTextBox);
            this.DoubleBuffered = true;
            this.Name = "dept_insert";
            this.ShowIcon = false;
            this.Text = "Dept_insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox headerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Depid;
        private System.Windows.Forms.TextBox nameTesxtBox;
        private System.Windows.Forms.TextBox Locationtextbox;
        private System.Windows.Forms.TextBox ManID;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button close_button;
    }
}