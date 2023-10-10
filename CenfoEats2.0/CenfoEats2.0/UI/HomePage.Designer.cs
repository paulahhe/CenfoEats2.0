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
            this.CreateRestaurant = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.RegisterUser.SuspendLayout();
            this.gBoxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RegisterUser);
            this.tabControl1.Controls.Add(this.CreateRestaurant);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1412, 826);
            this.tabControl1.TabIndex = 0;
            // 
            // RegisterUser
            // 
            this.RegisterUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RegisterUser.Controls.Add(this.btnRegister);
            this.RegisterUser.Controls.Add(this.gBoxRegister);
            this.RegisterUser.Location = new System.Drawing.Point(4, 25);
            this.RegisterUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterUser.Size = new System.Drawing.Size(1404, 797);
            this.RegisterUser.TabIndex = 0;
            this.RegisterUser.Text = "Registro Usuarios";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(583, 487);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(269, 95);
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
            this.gBoxRegister.Location = new System.Drawing.Point(252, 150);
            this.gBoxRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxRegister.Name = "gBoxRegister";
            this.gBoxRegister.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxRegister.Size = new System.Drawing.Size(960, 273);
            this.gBoxRegister.TabIndex = 0;
            this.gBoxRegister.TabStop = false;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbClient.Location = new System.Drawing.Point(36, 226);
            this.rbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(113, 33);
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
            this.rbDriver.Location = new System.Drawing.Point(537, 226);
            this.rbDriver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDriver.Name = "rbDriver";
            this.rbDriver.Size = new System.Drawing.Size(151, 33);
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
            this.lblPassword.Location = new System.Drawing.Point(531, 116);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 29);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(537, 150);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(383, 30);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(531, 18);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(243, 29);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Numero de Telefono";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(537, 53);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(383, 30);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmail.Location = new System.Drawing.Point(29, 116);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 29);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Correo";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(36, 150);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(29, 18);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(36, 53);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(383, 30);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // CreateRestaurant
            // 
            this.CreateRestaurant.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CreateRestaurant.Location = new System.Drawing.Point(4, 25);
            this.CreateRestaurant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateRestaurant.Name = "CreateRestaurant";
            this.CreateRestaurant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateRestaurant.Size = new System.Drawing.Size(1404, 797);
            this.CreateRestaurant.TabIndex = 1;
            this.CreateRestaurant.Text = "Registrar Restaurantes";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1404, 797);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registrar Platillos";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(1404, 797);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Text = "Pagina Inicio";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.RegisterUser.ResumeLayout(false);
            this.gBoxRegister.ResumeLayout(false);
            this.gBoxRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RegisterUser;
        private System.Windows.Forms.TabPage CreateRestaurant;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
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
    }
}