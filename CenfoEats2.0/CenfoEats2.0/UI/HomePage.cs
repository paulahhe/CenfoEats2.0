using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PPrototipo.Prototipo;
using CenfoEats2._0.PSingleton.CRUD;

namespace CenfoEats2._0.UI
{
    public partial class HomePage : Form
    {
        List<ProductsDB> productsDBs;
        Gestor gestor = new Gestor();
        public HomePage()
        {
            InitializeComponent();

            // Carga ComboBox Restaurantes Platillos 
            var crudFactory = new ProductCrudFactory();
            productsDBs = crudFactory.RetrieveAllProducts<ProductsDB>();

            // Enlaza el ComboBox a la lista completa de ProductsDB
            comboBoxPlates.DisplayMember = "nombre"; // Propiedad que se mostrará
            comboBoxPlates.ValueMember = "id"; // Propiedad que se utilizará como valor seleccionado
            comboBoxPlates.DataSource = productsDBs;

            listBoxRestaurantProducts.MouseDoubleClick += listBoxRestaurantProducts_MouseDoubleClick;
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            // Carga tabla Usuarios 
            this.tBL_USERTableAdapter.Fill(this.cenfoEats2DBDataSet.TBL_USER);
        }

        // TabRegisterUsers
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string type = null;
            if (rbClient.Checked)
            {
                type = "Cliente";
            }
            if (rbDriver.Checked)
            {
                type = "Repartidor";
            }
            if (email == null || name == null || phoneNumber == null || password == null || type == null)
            {
                MessageBox.Show("Por favor completar el formulario.");
                return;
            }
            else
            {
                string msg = $"Usuario creado \nEmail: {email}, Nombre: {name}, Teléfono: {phoneNumber},tipo: {type}";
                MessageBox.Show(msg);
                var fabricaUsuarios = new Gestor();
                fabricaUsuarios.nuevoUsuario(name, email, phoneNumber, type, password);
                ResetFormRegisterUsers();
            }
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClient.Checked)
            {
                rbDriver.Checked = false;
            }
        }

        private void rbDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDriver.Checked)
            {
                rbClient.Checked = false;
            }
        }

        private void ResetFormRegisterUsers()
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtPassword.Text = "";
            rbClient.Checked = false;
            rbDriver.Checked = false;
        }

        // TabRegisterRestaurant
        private void btnRegisterRestaurant_Click(object sender, EventArgs e)
        {
            if (listBoxRestaurantProducts.Items.Count == 0)
            {
                MessageBox.Show("No se puede crear un restaurante sin platillos. Agrega al menos un platillo al menú.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateTextBoxesRestaurant())
            {
                MessageBox.Show("Por favor, completa todos los campos antes de crear el restaurante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<ProductsDB> productosSeleccionados = listBoxRestaurantProducts.Items.OfType<ProductsDB>().ToList();
            // Crear el objeto de restaurante con la lista de productos seleccionados
            Restaurant nuevoRestaurante = new Restaurant(
                txtNameRestaurant.Text,
                txtLocationRestaurant.Text,
                txtPhoneNumberRestaurant.Text,
                txtTypeFood.Text,
                5,
                productosSeleccionados);

            //aqui hacer insert en la base de datos en la tabla de TBL_Restaurant mandar el nuevoRestaurante y hacer los inserts en tabla intermedia de TBL_Restaurant_Products 
            ShowRichTextBoxForm("Información del restaurante", nuevoRestaurante.GetRestaurantData());
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            // Obtener el elemento seleccionado del ComboBox
            ProductsDB elementoSeleccionado = (ProductsDB)comboBoxPlates.SelectedItem;

            // Verificar si el elemento ya está presente en el ListBox o si esta vacio
            if (!listBoxRestaurantProducts.Items.Contains(elementoSeleccionado) && elementoSeleccionado != null)
            {
                // Agregar el elemento al ListBox
                listBoxRestaurantProducts.Items.Add(elementoSeleccionado);
            }
            else
            {
                // Si el elemento ya está presente o es nulo, puedes mostrar un mensaje o realizar otra acción.
                MessageBox.Show("El elemento ya está en la lista o es inválido.");
            }
        }
        private bool ValidateTextBoxesRestaurant()
        {
            // Verificar que los TextBox no estén vacíos
            return !string.IsNullOrWhiteSpace(txtNameRestaurant.Text) &&
                   !string.IsNullOrWhiteSpace(txtLocationRestaurant.Text) &&
                   !string.IsNullOrWhiteSpace(txtPhoneNumberRestaurant.Text) &&
                   !string.IsNullOrWhiteSpace(txtTypeFood.Text);
        }

        private void ShowRichTextBoxForm(string title, string content)
        {
            using (Form messageForm = new Form())
            {
                // Configurar el formulario
                messageForm.Text = title;
                messageForm.Size = new System.Drawing.Size(400, 300);
                messageForm.StartPosition = FormStartPosition.CenterParent; // Centra el msgBox

                // Agregar un RichTextBox al formulario
                RichTextBox richTextBox = new RichTextBox();
                richTextBox.Dock = DockStyle.Fill;
                richTextBox.Text = content;
                richTextBox.ReadOnly = true; // Hacer el RichTextBox de solo lectura

                // Agregar el RichTextBox al formulario
                messageForm.Controls.Add(richTextBox);

                // Agregar un botón para cerrar el formulario
                System.Windows.Forms.Button closeButton = new System.Windows.Forms.Button();
                closeButton.Text = "Cerrar";
                closeButton.Dock = DockStyle.Bottom;
                closeButton.Click += (sender, e) => messageForm.Close();
                messageForm.Controls.Add(closeButton);

                messageForm.ShowDialog();
            }
        }

        private void listBoxRestaurantProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxRestaurantProducts.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                // Se hizo doble clic en un elemento del ListBox
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "Eliminar Elemento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el elemento seleccionado
                    string elementoSeleccionado = listBoxRestaurantProducts.Items[index].ToString();

                    // Eliminar el elemento seleccionado del ListBox
                    listBoxRestaurantProducts.Items.RemoveAt(index);
                }
            }
        }



        // TabRealizarPedido
        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {

            string restaurante = comboBoxRestaurantePedido.SelectedItem?.ToString();
            string platillo = comboBoxPlatilloPedido.SelectedItem?.ToString();
            string ingredienteExtra = comboBoxIngredientePedido.SelectedItem?.ToString();
            int idCliente = int.Parse(textBoxClientePedido.Text);
            string repartidor;
            string address = null;

            string infoPedido = $"Pedido creado:\n" +
                      $"Restaurante: {restaurante}\n" +
                      $"Platillo: {platillo}\n" +
                      $"Cliente ID: {idCliente}\n";

            // Validar campos generales
            if (!ValidatePedidoFields())
            {
                MessageBox.Show("Por favor, completa todos los campos antes de realizar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                // Obtener valores seleccionados
                // Validar campos específicos para entrega a domicilio
                if (radioButtonDomicilio.Checked)
                {
                    if (!ValidateEntregaDomicilio())
                    {


                        MessageBox.Show("Por favor, completa la información de entrega a domicilio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;


                    }

                    // Lógica para seleccionar un repartidor aleatorio
                    repartidor = gestor.ObtenerNombreRepartidorAleatorio();
                    address = textBoxUbicacionPedido.Text;

                    infoPedido += $"Nombre Repartidor: {repartidor}\n" +
                              $"Dirección de entrega: {address}\n";
                    // Puedes utilizar el valor de 'repartidor' según tu lógica de negocio
                }

                gestor.CrearPedido(restaurante, idCliente, address);



                // Muestra la información del pedido en el textBoxInfoPedido
                textBoxInfoPedido.Text = infoPedido;
            }
        }

        private bool ValidatePedidoFields()
        {
            // Validar campos generales
            return comboBoxRestaurantePedido.SelectedItem != null &&
                   comboBoxPlatilloPedido.SelectedItem != null &&
                   textBoxClientePedido.Text.Trim() != "" &&
                   (radioButtonRecoger.Checked || radioButtonDomicilio.Checked);
        }

        private bool ValidateEntregaDomicilio()
        {
            // Validar campos específicos para entrega a domicilio
            if (string.IsNullOrWhiteSpace(textBoxUbicacionPedido.Text))
            {
                return false;
            }
            return true;
        }


        private void radioButtonRecoger_CheckedChanged_1(object sender, EventArgs e)
        {
            // Ocultar los controles de entrega a domicilio
            labelUbicacionPedido.Visible = false;
            textBoxUbicacionPedido.Visible = false;
        }

        private void radioButtonDomicilio_CheckedChanged_1(object sender, EventArgs e)
        {
            // Mostrar los controles de entrega a domicilio
            labelUbicacionPedido.Visible = true;
            textBoxUbicacionPedido.Visible = true;
        }


        private void mostrarInfoPedidoProxy(object idcliente, object idrepartidor, object idpedido)
        {
            idcliente = int.Parse(inputClientID.Text);
            idrepartidor = int.Parse(inputRepartidorID.Text);
            idpedido = int.Parse(inputOrderID.Text);

            if (gestor.validacionIdRequeridos(idcliente, idrepartidor, idpedido))
            {
                int pedidoId = Convert.ToInt32(idpedido);
                int repartidorId = Convert.ToInt32(idrepartidor);
                int clienteId = Convert.ToInt32(idpedido);

                gestor.ObtenerInfoProxy(pedidoId, repartidorId, clienteId);
            }
        }



        private void RegisterUser_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxIngredientePedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            mostrarInfoPedidoProxy(inputClientID.Text, inputRepartidorID.Text, inputOrderID.Text);
        }
    }
}