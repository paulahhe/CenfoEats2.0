namespace CenfoEats2._0.UI
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegisterUser = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gBoxRegister = new System.Windows.Forms.GroupBox();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbDriver = new System.Windows.Forms.RadioButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ListUsers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBLUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenfoEats2DBDataSet = new CenfoEats2._0.CenfoEats2DBDataSet();
            this.tBL_USERTableAdapter = new CenfoEats2._0.CenfoEats2DBDataSetTableAdapters.TBL_USERTableAdapter();
            this.iDUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.RegisterUser.SuspendLayout();
            this.gBoxRegister.SuspendLayout();
            this.ListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RegisterUser);
            this.tabControl1.Controls.Add(this.ListUsers);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 671);
            this.tabControl1.TabIndex = 0;
            // 
            // RegisterUser
            // 
            this.RegisterUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RegisterUser.Controls.Add(this.btnRegister);
            this.RegisterUser.Controls.Add(this.gBoxRegister);
            this.RegisterUser.Location = new System.Drawing.Point(4, 22);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.RegisterUser.Size = new System.Drawing.Size(1051, 645);
            this.RegisterUser.TabIndex = 0;
            this.RegisterUser.Text = "Registro Usuarios";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(437, 396);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(202, 77);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gBoxRegister
            // 
            this.gBoxRegister.Controls.Add(this.rbClient);
            this.gBoxRegister.Controls.Add(this.rbDriver);
            this.gBoxRegister.Controls.Add(this.lblPassword);
            this.gBoxRegister.Controls.Add(this.txtPassword);
            this.gBoxRegister.Controls.Add(this.lblPhoneNumber);
            this.gBoxRegister.Controls.Add(this.txtPhoneNumber);
            this.gBoxRegister.Controls.Add(this.lblEmail);
            this.gBoxRegister.Controls.Add(this.txtEmail);
            this.gBoxRegister.Controls.Add(this.lblName);
            this.gBoxRegister.Controls.Add(this.txtName);
            this.gBoxRegister.Location = new System.Drawing.Point(189, 122);
            this.gBoxRegister.Name = "gBoxRegister";
            this.gBoxRegister.Size = new System.Drawing.Size(720, 222);
            this.gBoxRegister.TabIndex = 0;
            this.gBoxRegister.TabStop = false;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbClient.Location = new System.Drawing.Point(27, 184);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(91, 29);
            this.rbClient.TabIndex = 10;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Cliente";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // rbDriver
            // 
            this.rbDriver.AutoSize = true;
            this.rbDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbDriver.Location = new System.Drawing.Point(403, 184);
            this.rbDriver.Name = "rbDriver";
            this.rbDriver.Size = new System.Drawing.Size(119, 29);
            this.rbDriver.TabIndex = 11;
            this.rbDriver.TabStop = true;
            this.rbDriver.Text = "Repartidor";
            this.rbDriver.UseVisualStyleBackColor = true;
            this.rbDriver.CheckedChanged += new System.EventHandler(this.rbDriver_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPassword.Location = new System.Drawing.Point(398, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 25);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(403, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(398, 15);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(190, 25);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Numero de Telefono";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(403, 43);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(288, 26);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmail.Location = new System.Drawing.Point(22, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Correo";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(27, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(22, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(27, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 26);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // ListUsers
            // 
            this.ListUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ListUsers.Controls.Add(this.dataGridView1);
            this.ListUsers.Location = new System.Drawing.Point(4, 22);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ListUsers.Size = new System.Drawing.Size(1051, 645);
            this.ListUsers.TabIndex = 1;
            this.ListUsers.Text = "Mostrar Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSERDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.aCCOUNTTYPEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLUSERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(130, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBLUSERBindingSource
            // 
            this.tBLUSERBindingSource.DataMember = "TBL_USER";
            this.tBLUSERBindingSource.DataSource = this.cenfoEats2DBDataSet;
            // 
            // cenfoEats2DBDataSet
            // 
            this.cenfoEats2DBDataSet.DataSetName = "CenfoEats2DBDataSet";
            this.cenfoEats2DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_USERTableAdapter
            // 
            this.tBL_USERTableAdapter.ClearBeforeFill = true;
            // 
            // iDUSERDataGridViewTextBoxColumn
            // 
            this.iDUSERDataGridViewTextBoxColumn.DataPropertyName = "ID_USER";
            this.iDUSERDataGridViewTextBoxColumn.HeaderText = "ID_USER";
            this.iDUSERDataGridViewTextBoxColumn.Name = "iDUSERDataGridViewTextBoxColumn";
            this.iDUSERDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUSERDataGridViewTextBoxColumn.Width = 150;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.Width = 150;
            // 
            // aCCOUNTTYPEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Name = "aCCOUNTTYPEDataGridViewTextBoxColumn";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Width = 150;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomePage";
            this.Text = "Pagina Inicio";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.RegisterUser.ResumeLayout(false);
            this.gBoxRegister.ResumeLayout(false);
            this.gBoxRegister.PerformLayout();
            this.ListUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RegisterUser;
        private System.Windows.Forms.TabPage ListUsers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gBoxRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rbDriver;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CenfoEats2DBDataSet cenfoEats2DBDataSet;
        private System.Windows.Forms.BindingSource tBLUSERBindingSource;
        private CenfoEats2DBDataSetTableAdapters.TBL_USERTableAdapter tBL_USERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTTYPEDataGridViewTextBoxColumn;
    }
}