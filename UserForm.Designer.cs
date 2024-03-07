namespace Webserver
{
    partial class UserForm
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
            dataGridView1 = new DataGridView();
            formId = new DataGridViewTextBoxColumn();
            formName = new DataGridViewTextBoxColumn();
            readAccess = new DataGridViewCheckBoxColumn();
            writeAccess = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            label3 = new Label();
            label1 = new Label();
            label10 = new Label();
            label4 = new Label();
            label12 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label14 = new Label();
            label13 = new Label();
            label15 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { formId, formName, readAccess, writeAccess });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(567, 410);
            dataGridView1.TabIndex = 0;
            // 
            // formId
            // 
            formId.HeaderText = "formId";
            formId.MinimumWidth = 6;
            formId.Name = "formId";
            formId.Width = 125;
            // 
            // formName
            // 
            formName.HeaderText = "formName";
            formName.MinimumWidth = 6;
            formName.Name = "formName";
            formName.Width = 125;
            // 
            // readAccess
            // 
            readAccess.HeaderText = "readAccess";
            readAccess.MinimumWidth = 6;
            readAccess.Name = "readAccess";
            readAccess.Width = 125;
            // 
            // writeAccess
            // 
            writeAccess.HeaderText = "writeAccess";
            writeAccess.MinimumWidth = 6;
            writeAccess.Name = "writeAccess";
            writeAccess.Width = 125;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7.5F);
            button1.Location = new Point(608, 137);
            button1.Name = "button1";
            button1.Size = new Size(93, 44);
            button1.TabIndex = 1;
            button1.Text = "Hesap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 7.5F);
            button2.Location = new Point(707, 137);
            button2.Name = "button2";
            button2.Size = new Size(93, 44);
            button2.TabIndex = 2;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 7.5F);
            button6.Location = new Point(806, 137);
            button6.Name = "button6";
            button6.Size = new Size(93, 44);
            button6.TabIndex = 3;
            button6.Text = "Label Temizle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 12);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 4;
            label3.Text = "Check Olan İndex Sayısı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(613, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(946, 24);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 6;
            label10.Text = "Okuma Yetkisi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(946, 55);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 7;
            label4.Text = "Binary Yazımı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(951, 86);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 8;
            label12.Text = "binary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(946, 120);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 9;
            label5.Text = "Decimal Yazımı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(951, 151);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "decimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(951, 320);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 15;
            label2.Text = "decimal";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(946, 289);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 14;
            label14.Text = "Decimal Yazımı";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(951, 255);
            label13.Name = "label13";
            label13.Size = new Size(50, 20);
            label13.TabIndex = 13;
            label13.Text = "binary";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(946, 224);
            label15.Name = "label15";
            label15.Size = new Size(97, 20);
            label15.TabIndex = 12;
            label15.Text = "Binary Yazımı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(946, 193);
            label11.Name = "label11";
            label11.Size = new Size(103, 20);
            label11.TabIndex = 11;
            label11.Text = "Yazma Yetkisi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 435);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 47);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 493);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 47);
            textBox2.TabIndex = 17;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 7.5F);
            button3.Location = new Point(207, 438);
            button3.Name = "button3";
            button3.Size = new Size(52, 94);
            button3.TabIndex = 18;
            button3.Text = "Toplu Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7.5F);
            button4.Location = new Point(279, 438);
            button4.Name = "button4";
            button4.Size = new Size(93, 44);
            button4.TabIndex = 19;
            button4.Text = "Yazma";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 7.5F);
            button5.Location = new Point(279, 488);
            button5.Name = "button5";
            button5.Size = new Size(93, 44);
            button5.TabIndex = 20;
            button5.Text = "Okuma";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(200, 554);
            label8.Name = "label8";
            label8.Size = new Size(114, 23);
            label8.TabIndex = 21;
            label8.Text = "Binary Yazımı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(329, 555);
            label9.Name = "label9";
            label9.Size = new Size(126, 23);
            label9.TabIndex = 22;
            label9.Text = "\"Çevrilmiş Hali\"";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(946, 554);
            label7.Name = "label7";
            label7.Size = new Size(222, 20);
            label7.TabIndex = 23;
            label7.Text = "Tek Bir Sütunda Seçim Yapınız!";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(613, 453);
            label16.Name = "label16";
            label16.Size = new Size(58, 20);
            label16.TabIndex = 24;
            label16.Text = "label16";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(608, 270);
            label17.Name = "label17";
            label17.Size = new Size(119, 20);
            label17.TabIndex = 25;
            label17.Text = "Gelen Read Sayı:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(608, 339);
            label18.Name = "label18";
            label18.Size = new Size(103, 20);
            label18.TabIndex = 26;
            label18.Text = "Çevrilmiş Hali:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(613, 306);
            label19.Name = "label19";
            label19.Size = new Size(58, 20);
            label19.TabIndex = 27;
            label19.Text = "label19";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(608, 362);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(291, 34);
            textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(608, 509);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(291, 34);
            textBox5.TabIndex = 33;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(608, 486);
            label20.Name = "label20";
            label20.Size = new Size(103, 20);
            label20.TabIndex = 31;
            label20.Text = "Çevrilmiş Hali:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(608, 417);
            label21.Name = "label21";
            label21.Size = new Size(121, 20);
            label21.TabIndex = 30;
            label21.Text = "Gelen Write Sayı:";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 587);
            Controls.Add(textBox5);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(textBox4);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button6;
        private Label label3;
        private Label label1;
        private Label label10;
        private Label label4;
        private Label label12;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label14;
        private Label label13;
        private Label label15;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label8;
        private DataGridViewTextBoxColumn formId;
        private DataGridViewTextBoxColumn formName;
        private DataGridViewCheckBoxColumn readAccess;
        private DataGridViewCheckBoxColumn writeAccess;
        private Label label9;
        private Label label7;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label20;
        private Label label21;
    }
}