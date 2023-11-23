using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PPrototipo.Menu;
using CenfoEats2._0.PPrototipo.Prototipo;
using CenfoEats2._0.PSingleton.CRUD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CenfoEats2._0.UI
{
    public partial class HomePage : Form
    {
        List<ProductsDB> productsDBs;
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

            //foreach (var item in productsDBs)
            //{
            //    comboBoxPlates.Items.Add(item.nombre);
            //}
            // Event Double Click Listbox
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
                ResetForm();
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

        private void ResetForm()
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
            foreach (var item in listBoxRestaurantProducts.Items)
            {
                MessageBox.Show(item.ToString());

            }
            // Crear una lista para almacenar los platillos
            //List<ProductsDB> listaDePlatillos = new List<ProductsDB>();

            //// Iterar sobre los elementos seleccionados en el ComboBox
            //foreach (var selectedItem in comboBoxPlates.Items)
            //{
            //    if (selectedItem is ProductsDB selectedProduct && comboBoxPlates.CheckedItems.Contains(selectedItem))
            //    {
            //        // Convertir el objeto ProductsDB a Platillo y agregarlo a la lista
            //        Platillo platillo = new Platillo
            //        {
            //            nombre = selectedProduct.nombre,
            //            precio = selectedProduct.precio,
            //            descripcion = selectedProduct.descripcion
            //        };

            //        listaDePlatillos.Add(platillo);
            //    }
            //}

            //// Ahora, listaDePlatillos contiene los platillos seleccionados del ComboBox
            //Restaurant miRestaurante = new Restaurant("Nombre del Restaurante", "Dirección del Restaurante", 123456, "Tipo de Comida", 5, listaDePlatillos);
            //MessageBox.Show(miRestaurante.GetRestaurantData());
            //MessageBox.Show(miRestaurante.GetMenuData());

            //// Crear una lista para almacenar los platillos
            //List<Platillo> listaDePlatillos = new List<Platillo>();

            // Iterar sobre los elementos del ListBox y agregarlos a la lista de platillos
            //foreach (var item in listBoxRestaurantProducts.Items)
            //{
            //    if (item is ProductsDB platillo)
            //    {
            //        // Agregar el platillo a la lista
            //        listaDePlatillos.Add(platillo);
            //    }
            //}

            //// Ahora, listaDePlatillos contiene los platillos del ListBox
            //Restaurant miRestaurante = new Restaurant("Nombre del Restaurante", "Dirección del Restaurante", 123456, "Tipo de Comida", 5, listaDePlatillos);
            //MessageBox.Show(miRestaurante.GetRestaurantData());
            //MessageBox.Show(miRestaurante.GetMenuData());
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            // Obtener el elemento seleccionado del ComboBox
            string elementoSeleccionado = comboBoxPlates.Text;

            // Verificar si el elemento ya está presente en el ListBox
            if (!listBoxRestaurantProducts.Items.Contains(elementoSeleccionado) && !string.IsNullOrEmpty(elementoSeleccionado))
            {
                // Agregar el elemento al ListBox
                listBoxRestaurantProducts.Items.Add(elementoSeleccionado);
            }
            else
            {
                // Si el elemento ya está presente o es una cadena vacía, puedes mostrar un mensaje o realizar otra acción.
                MessageBox.Show("El elemento ya está en la lista o es inválido.");
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
    }
}