namespace PTRFS_Implementation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prev_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prev_button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.prev_button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.prev_button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 280);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button5.Location = new System.Drawing.Point(134, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 30);
            this.button5.TabIndex = 19;
            this.button5.Text = "The nearest stops to my location";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button4.Location = new System.Drawing.Point(134, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 30);
            this.button4.TabIndex = 18;
            this.button4.Text = "Bus stops";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button3.Location = new System.Drawing.Point(134, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Voyage times";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button2.Location = new System.Drawing.Point(134, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save your favorite addresses";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(134, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Get me somewhere";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(83, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(83, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(81, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(81, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "T";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "P";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prev_button);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(24, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 280);
            this.panel2.TabIndex = 20;
            // 
            // prev_button
            // 
            this.prev_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.prev_button.Location = new System.Drawing.Point(43, 224);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(90, 23);
            this.prev_button.TabIndex = 2;
            this.prev_button.Text = "Previous";
            this.prev_button.UseVisualStyleBackColor = true;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select here...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(40, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Please select the mean of public transport you want to view its voyage times.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.prev_button2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(24, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 280);
            this.panel3.TabIndex = 3;
            // 
            // prev_button2
            // 
            this.prev_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.prev_button2.Location = new System.Drawing.Point(17, 252);
            this.prev_button2.Name = "prev_button2";
            this.prev_button2.Size = new System.Drawing.Size(90, 23);
            this.prev_button2.TabIndex = 1;
            this.prev_button2.Text = "Previous";
            this.prev_button2.UseVisualStyleBackColor = true;
            this.prev_button2.Click += new System.EventHandler(this.prev_button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.prev_button3);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel4.Location = new System.Drawing.Point(24, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(827, 280);
            this.panel4.TabIndex = 21;
            // 
            // prev_button3
            // 
            this.prev_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.prev_button3.Location = new System.Drawing.Point(34, 251);
            this.prev_button3.Name = "prev_button3";
            this.prev_button3.Size = new System.Drawing.Size(90, 23);
            this.prev_button3.TabIndex = 3;
            this.prev_button3.Text = "Previous";
            this.prev_button3.UseVisualStyleBackColor = true;
            this.prev_button3.Click += new System.EventHandler(this.prev_button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(34, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Select here...";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(31, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Please select a bus number.";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(774, 177);
            this.dataGridView2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.prev_button4);
            this.panel5.Controls.Add(this.dataGridView3);
            this.panel5.Controls.Add(this.comboBox3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(24, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 280);
            this.panel5.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(17, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Please select a seaway line.";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(20, 50);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(307, 23);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.Text = "Select here...";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(20, 86);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(644, 161);
            this.dataGridView3.TabIndex = 2;
            // 
            // prev_button4
            // 
            this.prev_button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.prev_button4.Location = new System.Drawing.Point(20, 254);
            this.prev_button4.Name = "prev_button4";
            this.prev_button4.Size = new System.Drawing.Size(90, 23);
            this.prev_button4.TabIndex = 3;
            this.prev_button4.Text = "Previous";
            this.prev_button4.UseVisualStyleBackColor = true;
            this.prev_button4.Click += new System.EventHandler(this.prev_button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 356);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Path Transfer Route Finder System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button prev_button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button prev_button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button prev_button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
    }
}

