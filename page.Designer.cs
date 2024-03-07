namespace Webserver
{
    partial class page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            webUserID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            authType = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            readOnlyAccess = new DataGridViewTextBoxColumn();
            readWriteAccess = new DataGridViewTextBoxColumn();
            isActive = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, webUserID, name, authType, email, password, readOnlyAccess, readWriteAccess, isActive });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1180, 345);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // webUserID
            // 
            webUserID.HeaderText = "webUserID";
            webUserID.MinimumWidth = 6;
            webUserID.Name = "webUserID";
            webUserID.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // authType
            // 
            authType.HeaderText = "authType";
            authType.MinimumWidth = 6;
            authType.Name = "authType";
            authType.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // password
            // 
            password.HeaderText = "password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // readOnlyAccess
            // 
            readOnlyAccess.HeaderText = "readOnlyAccess";
            readOnlyAccess.MinimumWidth = 6;
            readOnlyAccess.Name = "readOnlyAccess";
            readOnlyAccess.Width = 125;
            // 
            // readWriteAccess
            // 
            readWriteAccess.HeaderText = "readWriteAccess";
            readWriteAccess.MinimumWidth = 6;
            readWriteAccess.Name = "readWriteAccess";
            readWriteAccess.Width = 125;
            // 
            // isActive
            // 
            isActive.HeaderText = "isActive";
            isActive.MinimumWidth = 6;
            isActive.Name = "isActive";
            isActive.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn webUserID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn authType;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn readOnlyAccess;
        private DataGridViewTextBoxColumn readWriteAccess;
        private DataGridViewTextBoxColumn isActive;
    }
}
