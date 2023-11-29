using System;

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
            this.tBLUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenfoEats2DBDataSet = new CenfoEats2._0.CenfoEats2DBDataSet();
            this.tBLPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenfoEats2DBProductNameIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenfoEats2DBProductNameId = new CenfoEats2._0.CenfoEats2DBProductNameId();
            this.tBL_USERTableAdapter = new CenfoEats2._0.CenfoEats2DBDataSetTableAdapters.TBL_USERTableAdapter();
            this.cenfoEats2DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_PRODUCTSTableAdapter = new CenfoEats2._0.CenfoEats2DBProductNameIdTableAdapters.TBL_PRODUCTSTableAdapter();
            this.RegisterOrder = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUbicacionPedido = new System.Windows.Forms.TextBox();
            this.labelUbicacionPedido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPlatilloPedido = new System.Windows.Forms.ComboBox();
            this.buttonIngredientePedido = new System.Windows.Forms.Button();
            this.comboBoxRestaurantePedido = new System.Windows.Forms.ComboBox();
            this.radioButtonRecoger = new System.Windows.Forms.RadioButton();
            this.radioButtonDomicilio = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxClientePedido = new System.Windows.Forms.TextBox();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxIngredientePedido = new System.Windows.Forms.ComboBox();
            this.textBoxInfoPedido = new System.Windows.Forms.TextBox();
            this.RegisterPlates = new System.Windows.Forms.TabPage();
            this.RegisterRestaurant = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNameRestaurant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocationRestaurant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumberRestaurant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPlates = new System.Windows.Forms.ComboBox();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.listBoxRestaurantProducts = new System.Windows.Forms.ListBox();
            this.btnRegisterRestaurant = new System.Windows.Forms.Button();
            this.ListUsers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aCCOUNTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterUser = new System.Windows.Forms.TabPage();
            this.gBoxRegister = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rbDriver = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBProductNameIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBProductNameId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBDataSetBindingSource)).BeginInit();
            this.RegisterOrder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RegisterRestaurant.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RegisterUser.SuspendLayout();
            this.gBoxRegister.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // tBLPRODUCTSBindingSource
            // 
            this.tBLPRODUCTSBindingSource.DataMember = "TBL_PRODUCTS";
            this.tBLPRODUCTSBindingSource.DataSource = this.cenfoEats2DBProductNameIdBindingSource;
            // 
            // cenfoEats2DBProductNameIdBindingSource
            // 
            this.cenfoEats2DBProductNameIdBindingSource.DataSource = this.cenfoEats2DBProductNameId;
            this.cenfoEats2DBProductNameIdBindingSource.Position = 0;
            // 
            // cenfoEats2DBProductNameId
            // 
            this.cenfoEats2DBProductNameId.DataSetName = "CenfoEats2DBProductNameId";
            this.cenfoEats2DBProductNameId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_USERTableAdapter
            // 
            this.tBL_USERTableAdapter.ClearBeforeFill = true;
            // 
            // cenfoEats2DBDataSetBindingSource
            // 
            this.cenfoEats2DBDataSetBindingSource.DataSource = this.cenfoEats2DBDataSet;
            this.cenfoEats2DBDataSetBindingSource.Position = 0;
            // 
            // tBL_PRODUCTSTableAdapter
            // 
            this.tBL_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterOrder
            // 
            this.RegisterOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RegisterOrder.Controls.Add(this.groupBox2);
            this.RegisterOrder.Location = new System.Drawing.Point(4, 22);
            this.RegisterOrder.Name = "RegisterOrder";
            this.RegisterOrder.Size = new System.Drawing.Size(1051, 645);
            this.RegisterOrder.TabIndex = 3;
            this.RegisterOrder.Text = "Registrar Pedidos";
            this.RegisterOrder.Click += new System.EventHandler(this.RegisterOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxInfoPedido);
            this.groupBox2.Controls.Add(this.comboBoxIngredientePedido);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnRealizarPedido);
            this.groupBox2.Controls.Add(this.textBoxClientePedido);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.radioButtonDomicilio);
            this.groupBox2.Controls.Add(this.radioButtonRecoger);
            this.groupBox2.Controls.Add(this.comboBoxRestaurantePedido);
            this.groupBox2.Controls.Add(this.buttonIngredientePedido);
            this.groupBox2.Controls.Add(this.comboBoxPlatilloPedido);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelUbicacionPedido);
            this.groupBox2.Controls.Add(this.textBoxUbicacionPedido);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(165, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 579);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(22, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Restaurante";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBoxUbicacionPedido
            // 
            this.textBoxUbicacionPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUbicacionPedido.Location = new System.Drawing.Point(403, 148);
            this.textBoxUbicacionPedido.Name = "textBoxUbicacionPedido";
            this.textBoxUbicacionPedido.Size = new System.Drawing.Size(288, 26);
            this.textBoxUbicacionPedido.TabIndex = 2;
            this.textBoxUbicacionPedido.Visible = false;
            // 
            // labelUbicacionPedido
            // 
            this.labelUbicacionPedido.AutoSize = true;
            this.labelUbicacionPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelUbicacionPedido.Location = new System.Drawing.Point(404, 120);
            this.labelUbicacionPedido.Name = "labelUbicacionPedido";
            this.labelUbicacionPedido.Size = new System.Drawing.Size(198, 25);
            this.labelUbicacionPedido.TabIndex = 3;
            this.labelUbicacionPedido.Text = "Ubicación de Entrega";
            this.labelUbicacionPedido.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(398, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(421, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 7;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(22, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Platillo";
            // 
            // comboBoxPlatilloPedido
            // 
            this.comboBoxPlatilloPedido.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLPRODUCTSBindingSource, "NAME", true));
            this.comboBoxPlatilloPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatilloPedido.FormattingEnabled = true;
            this.comboBoxPlatilloPedido.Items.AddRange(new object[] {
            "BigMac",
            "Tacos al Patrón",
            "Ensalda de patrones"});
            this.comboBoxPlatilloPedido.Location = new System.Drawing.Point(27, 110);
            this.comboBoxPlatilloPedido.Name = "comboBoxPlatilloPedido";
            this.comboBoxPlatilloPedido.Size = new System.Drawing.Size(311, 21);
            this.comboBoxPlatilloPedido.TabIndex = 9;
            // 
            // buttonIngredientePedido
            // 
            this.buttonIngredientePedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIngredientePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngredientePedido.Location = new System.Drawing.Point(63, 214);
            this.buttonIngredientePedido.Name = "buttonIngredientePedido";
            this.buttonIngredientePedido.Size = new System.Drawing.Size(229, 32);
            this.buttonIngredientePedido.TabIndex = 11;
            this.buttonIngredientePedido.Text = "Agregar ingrediente extra\r\n\r\n";
            this.buttonIngredientePedido.UseVisualStyleBackColor = true;
            this.buttonIngredientePedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxRestaurantePedido
            // 
            this.comboBoxRestaurantePedido.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLPRODUCTSBindingSource, "NAME", true));
            this.comboBoxRestaurantePedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRestaurantePedido.FormattingEnabled = true;
            this.comboBoxRestaurantePedido.Items.AddRange(new object[] {
            "Macdonals",
            "CenfoSoda",
            "TacoBell"});
            this.comboBoxRestaurantePedido.Location = new System.Drawing.Point(27, 43);
            this.comboBoxRestaurantePedido.Name = "comboBoxRestaurantePedido";
            this.comboBoxRestaurantePedido.Size = new System.Drawing.Size(311, 21);
            this.comboBoxRestaurantePedido.TabIndex = 13;
            this.comboBoxRestaurantePedido.SelectedIndexChanged += new System.EventHandler(this.comboBoxRestaurantePedido_SelectedIndexChanged);
            // 
            // radioButtonRecoger
            // 
            this.radioButtonRecoger.AutoSize = true;
            this.radioButtonRecoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButtonRecoger.Location = new System.Drawing.Point(396, 73);
            this.radioButtonRecoger.Name = "radioButtonRecoger";
            this.radioButtonRecoger.Size = new System.Drawing.Size(173, 29);
            this.radioButtonRecoger.TabIndex = 14;
            this.radioButtonRecoger.TabStop = true;
            this.radioButtonRecoger.Text = "Recoger en Sitio";
            this.radioButtonRecoger.UseVisualStyleBackColor = true;
            this.radioButtonRecoger.CheckedChanged += new System.EventHandler(this.radioButtonRecoger_CheckedChanged_1);
            // 
            // radioButtonDomicilio
            // 
            this.radioButtonDomicilio.AutoSize = true;
            this.radioButtonDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButtonDomicilio.Location = new System.Drawing.Point(572, 74);
            this.radioButtonDomicilio.Name = "radioButtonDomicilio";
            this.radioButtonDomicilio.Size = new System.Drawing.Size(127, 29);
            this.radioButtonDomicilio.TabIndex = 15;
            this.radioButtonDomicilio.TabStop = true;
            this.radioButtonDomicilio.Text = "A Domicilio";
            this.radioButtonDomicilio.UseVisualStyleBackColor = true;
            this.radioButtonDomicilio.CheckedChanged += new System.EventHandler(this.radioButtonDomicilio_CheckedChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(404, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Código de cliente";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBoxClientePedido
            // 
            this.textBoxClientePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxClientePedido.Location = new System.Drawing.Point(403, 44);
            this.textBoxClientePedido.Name = "textBoxClientePedido";
            this.textBoxClientePedido.Size = new System.Drawing.Size(288, 26);
            this.textBoxClientePedido.TabIndex = 17;
            this.textBoxClientePedido.TextChanged += new System.EventHandler(this.textBoxClientePedido_TextChanged);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRealizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPedido.Location = new System.Drawing.Point(278, 289);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(169, 33);
            this.btnRealizarPedido.TabIndex = 18;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(22, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(328, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Desea agregar un ingrediente extra?";
            // 
            // comboBoxIngredientePedido
            // 
            this.comboBoxIngredientePedido.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLPRODUCTSBindingSource, "NAME", true));
            this.comboBoxIngredientePedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIngredientePedido.FormattingEnabled = true;
            this.comboBoxIngredientePedido.Items.AddRange(new object[] {
            "Cebolla Extra",
            "Tomate Extra",
            "Queso Extra"});
            this.comboBoxIngredientePedido.Location = new System.Drawing.Point(27, 187);
            this.comboBoxIngredientePedido.Name = "comboBoxIngredientePedido";
            this.comboBoxIngredientePedido.Size = new System.Drawing.Size(311, 21);
            this.comboBoxIngredientePedido.TabIndex = 20;
            // 
            // textBoxInfoPedido
            // 
            this.textBoxInfoPedido.Location = new System.Drawing.Point(20, 348);
            this.textBoxInfoPedido.Multiline = true;
            this.textBoxInfoPedido.Name = "textBoxInfoPedido";
            this.textBoxInfoPedido.Size = new System.Drawing.Size(671, 185);
            this.textBoxInfoPedido.TabIndex = 21;
            // 
            // RegisterPlates
            // 
            this.RegisterPlates.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RegisterPlates.Location = new System.Drawing.Point(4, 22);
            this.RegisterPlates.Name = "RegisterPlates";
            this.RegisterPlates.Size = new System.Drawing.Size(1051, 645);
            this.RegisterPlates.TabIndex = 2;
            this.RegisterPlates.Text = "Registrar Platillos";
            // 
            // RegisterRestaurant
            // 
            this.RegisterRestaurant.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RegisterRestaurant.Controls.Add(this.btnRegisterRestaurant);
            this.RegisterRestaurant.Controls.Add(this.groupBox1);
            this.RegisterRestaurant.Location = new System.Drawing.Point(4, 22);
            this.RegisterRestaurant.Name = "RegisterRestaurant";
            this.RegisterRestaurant.Size = new System.Drawing.Size(1051, 645);
            this.RegisterRestaurant.TabIndex = 4;
            this.RegisterRestaurant.Text = "Registrar Restaurante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxRestaurantProducts);
            this.groupBox1.Controls.Add(this.btnAddProducts);
            this.groupBox1.Controls.Add(this.comboBoxPlates);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTypeFood);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhoneNumberRestaurant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLocationRestaurant);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNameRestaurant);
            this.groupBox1.Location = new System.Drawing.Point(189, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 423);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtNameRestaurant
            // 
            this.txtNameRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNameRestaurant.Location = new System.Drawing.Point(27, 43);
            this.txtNameRestaurant.Name = "txtNameRestaurant";
            this.txtNameRestaurant.Size = new System.Drawing.Size(288, 26);
            this.txtNameRestaurant.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(22, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // txtLocationRestaurant
            // 
            this.txtLocationRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLocationRestaurant.Location = new System.Drawing.Point(27, 122);
            this.txtLocationRestaurant.Name = "txtLocationRestaurant";
            this.txtLocationRestaurant.Size = new System.Drawing.Size(288, 26);
            this.txtLocationRestaurant.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ubicacion";
            // 
            // txtPhoneNumberRestaurant
            // 
            this.txtPhoneNumberRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhoneNumberRestaurant.Location = new System.Drawing.Point(403, 43);
            this.txtPhoneNumberRestaurant.Name = "txtPhoneNumberRestaurant";
            this.txtPhoneNumberRestaurant.Size = new System.Drawing.Size(288, 26);
            this.txtPhoneNumberRestaurant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(398, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero de Telefono";
            // 
            // txtTypeFood
            // 
            this.txtTypeFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTypeFood.Location = new System.Drawing.Point(403, 122);
            this.txtTypeFood.Name = "txtTypeFood";
            this.txtTypeFood.Size = new System.Drawing.Size(288, 26);
            this.txtTypeFood.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(398, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo Comida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(22, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Platillos";
            // 
            // comboBoxPlates
            // 
            this.comboBoxPlates.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLPRODUCTSBindingSource, "NAME", true));
            this.comboBoxPlates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlates.FormattingEnabled = true;
            this.comboBoxPlates.Location = new System.Drawing.Point(27, 196);
            this.comboBoxPlates.Name = "comboBoxPlates";
            this.comboBoxPlates.Size = new System.Drawing.Size(288, 21);
            this.comboBoxPlates.TabIndex = 9;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.Location = new System.Drawing.Point(403, 168);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(288, 49);
            this.btnAddProducts.TabIndex = 11;
            this.btnAddProducts.Text = "Agregar";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // listBoxRestaurantProducts
            // 
            this.listBoxRestaurantProducts.FormattingEnabled = true;
            this.listBoxRestaurantProducts.Location = new System.Drawing.Point(27, 259);
            this.listBoxRestaurantProducts.Name = "listBoxRestaurantProducts";
            this.listBoxRestaurantProducts.Size = new System.Drawing.Size(664, 147);
            this.listBoxRestaurantProducts.TabIndex = 12;
            // 
            // btnRegisterRestaurant
            // 
            this.btnRegisterRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterRestaurant.Location = new System.Drawing.Point(437, 551);
            this.btnRegisterRestaurant.Name = "btnRegisterRestaurant";
            this.btnRegisterRestaurant.Size = new System.Drawing.Size(202, 77);
            this.btnRegisterRestaurant.TabIndex = 10;
            this.btnRegisterRestaurant.Text = "Registrar";
            this.btnRegisterRestaurant.UseVisualStyleBackColor = true;
            this.btnRegisterRestaurant.Click += new System.EventHandler(this.btnRegisterRestaurant_Click);
            // 
            // ListUsers
            // 
            this.ListUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ListUsers.Controls.Add(this.dataGridView1);
            this.ListUsers.Location = new System.Drawing.Point(4, 22);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Padding = new System.Windows.Forms.Padding(3);
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
            // 
            // aCCOUNTTYPEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Name = "aCCOUNTTYPEDataGridViewTextBoxColumn";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDUSERDataGridViewTextBoxColumn
            // 
            this.iDUSERDataGridViewTextBoxColumn.DataPropertyName = "ID_USER";
            this.iDUSERDataGridViewTextBoxColumn.HeaderText = "ID_USER";
            this.iDUSERDataGridViewTextBoxColumn.Name = "iDUSERDataGridViewTextBoxColumn";
            this.iDUSERDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUSERDataGridViewTextBoxColumn.Width = 150;
            // 
            // RegisterUser
            // 
            this.RegisterUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RegisterUser.Controls.Add(this.btnRegister);
            this.RegisterUser.Controls.Add(this.gBoxRegister);
            this.RegisterUser.Location = new System.Drawing.Point(4, 22);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterUser.Size = new System.Drawing.Size(1051, 645);
            this.RegisterUser.TabIndex = 0;
            this.RegisterUser.Text = "Registro Usuarios";
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(27, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 26);
            this.txtName.TabIndex = 0;
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
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(27, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 26);
            this.txtEmail.TabIndex = 2;
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(403, 43);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(288, 26);
            this.txtPhoneNumber.TabIndex = 4;
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
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(403, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RegisterUser);
            this.tabControl1.Controls.Add(this.ListUsers);
            this.tabControl1.Controls.Add(this.RegisterRestaurant);
            this.tabControl1.Controls.Add(this.RegisterPlates);
            this.tabControl1.Controls.Add(this.RegisterOrder);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 671);
            this.tabControl1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBProductNameIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBProductNameId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenfoEats2DBDataSetBindingSource)).EndInit();
            this.RegisterOrder.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RegisterRestaurant.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ListUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RegisterUser.ResumeLayout(false);
            this.gBoxRegister.ResumeLayout(false);
            this.gBoxRegister.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CenfoEats2DBDataSet cenfoEats2DBDataSet;
        private System.Windows.Forms.BindingSource tBLUSERBindingSource;
        private CenfoEats2DBDataSetTableAdapters.TBL_USERTableAdapter tBL_USERTableAdapter;
        private System.Windows.Forms.BindingSource cenfoEats2DBDataSetBindingSource;
        private System.Windows.Forms.BindingSource cenfoEats2DBProductNameIdBindingSource;
        private CenfoEats2DBProductNameId cenfoEats2DBProductNameId;
        private System.Windows.Forms.BindingSource tBLPRODUCTSBindingSource;
        private CenfoEats2DBProductNameIdTableAdapters.TBL_PRODUCTSTableAdapter tBL_PRODUCTSTableAdapter;
        private System.Windows.Forms.TabPage RegisterOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxInfoPedido;
        private System.Windows.Forms.ComboBox comboBoxIngredientePedido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.TextBox textBoxClientePedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonDomicilio;
        private System.Windows.Forms.RadioButton radioButtonRecoger;
        private System.Windows.Forms.ComboBox comboBoxRestaurantePedido;
        private System.Windows.Forms.Button buttonIngredientePedido;
        private System.Windows.Forms.ComboBox comboBoxPlatilloPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelUbicacionPedido;
        private System.Windows.Forms.TextBox textBoxUbicacionPedido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage RegisterPlates;
        private System.Windows.Forms.TabPage RegisterRestaurant;
        private System.Windows.Forms.Button btnRegisterRestaurant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxRestaurantProducts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.ComboBox comboBoxPlates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumberRestaurant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocationRestaurant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameRestaurant;
        private System.Windows.Forms.TabPage ListUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage RegisterUser;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gBoxRegister;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbDriver;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabControl tabControl1;
    }
}