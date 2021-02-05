namespace SendFax
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
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_faxnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtd_log = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gvwexcel = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.Microsoft = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwexcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(235, 250);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(112, 40);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "SEND FAX";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "From Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "FROM COMPANY";
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(158, 138);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(189, 22);
            this.txt_file.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "FILE";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "SUBJECT";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 22);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "03-5604-9181";
            this.textBox5.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "DOCUMENT NAME";
            // 
            // txt_faxnum
            // 
            this.txt_faxnum.Location = new System.Drawing.Point(158, 222);
            this.txt_faxnum.Name = "txt_faxnum";
            this.txt_faxnum.Size = new System.Drawing.Size(189, 22);
            this.txt_faxnum.TabIndex = 14;
            this.txt_faxnum.Text = "0524859018";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "FAX NUMBER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtd_log
            // 
            this.rtd_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtd_log.Location = new System.Drawing.Point(0, 387);
            this.rtd_log.Name = "rtd_log";
            this.rtd_log.Size = new System.Drawing.Size(1036, 249);
            this.rtd_log.TabIndex = 16;
            this.rtd_log.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_faxnum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_file);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Location = new System.Drawing.Point(634, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 303);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEND FAX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "LOG";
            // 
            // gvwexcel
            // 
            this.gvwexcel.AllowUserToDeleteRows = false;
            this.gvwexcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwexcel.Location = new System.Drawing.Point(16, 40);
            this.gvwexcel.Name = "gvwexcel";
            this.gvwexcel.RowTemplate.Height = 24;
            this.gvwexcel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gvwexcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwexcel.Size = new System.Drawing.Size(473, 303);
            this.gvwexcel.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "Excel file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(495, 76);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(118, 30);
            this.btn_remove.TabIndex = 21;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Microsoft
            // 
            this.Microsoft.Location = new System.Drawing.Point(495, 112);
            this.Microsoft.Name = "Microsoft";
            this.Microsoft.Size = new System.Drawing.Size(112, 40);
            this.Microsoft.TabIndex = 22;
            this.Microsoft.Text = "Microsoft";
            this.Microsoft.UseVisualStyleBackColor = true;
            this.Microsoft.Click += new System.EventHandler(this.Microsoft_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(495, 169);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(112, 40);
            this.btn_info.TabIndex = 23;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 636);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.Microsoft);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gvwexcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtd_log);
            this.Name = "Form1";
            this.Text = "Send Fax";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwexcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_faxnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtd_log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gvwexcel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button Microsoft;
        private System.Windows.Forms.Button btn_info;
    }
}

