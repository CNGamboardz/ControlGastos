using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Gastos_E4
{
    public partial class Añadir_Transsacciones : Form
    {
        private Form inicioForm;
        MySqlConnection connection;

        public Añadir_Transsacciones()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=control_gastos;Uid=root;Pwd=;");
            LlenarComboBox(); // Llama al método para llenar el ComboBox

        }

        public Añadir_Transsacciones(Form formInicio)
        {
            InitializeComponent();
            this.inicioForm = formInicio; // Guarda la referencia al formulario Inicio
            connection = new MySqlConnection("Server=localhost;Database=control_gastos;Uid=root;Pwd=;");
            LlenarComboBox(); // Llama al método para llenar el ComboBox

        }


        private void regresar_Click(object sender, EventArgs e)
        {
            Inicio invoca = new Inicio();
            this.Hide();
            invoca.Show();
        }

        private void costo_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; // Si no es un número, punto o retroceso, bloquea la entrada
            }

            // Evita más de un punto decimal
            if (e.KeyChar == '.' && costo_B.Text.Contains("."))
            {
                e.Handled = true; // Si ya tiene un punto, bloquea el segundo
            }

            // Limita el número de caracteres a 10 (incluyendo decimales)
            if (costo_B.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void limpiar_B_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear(); 
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1; 
                }
            }

           
        }

        private void regresar_MouseEnter(object sender, EventArgs e)
        {
            regresar.BackColor = Color.LightGreen;

        }

        private void regresar_MouseLeave(object sender, EventArgs e)
        {
            regresar.BackColor = Color.DarkSeaGreen;

        }

        private void limpiar_B_MouseEnter(object sender, EventArgs e)
        {
            limpiar_B.BackColor = Color.LightGreen;

        }

        private void limpiar_B_MouseLeave(object sender, EventArgs e)
        {
            regresar.BackColor = Color.DarkSeaGreen;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGreen;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            regresar.BackColor = Color.DarkSeaGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Obtener la categoría seleccionada
                Categoria categoriaSeleccionada = comboBox1.SelectedItem as Categoria;
                if (categoriaSeleccionada != null)
                {
                    string query = "INSERT INTO importe (costo, fecha, id_categoria) VALUES (@costo, @fecha, @id_categoria)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Asigna valores a los parámetros
                    cmd.Parameters.AddWithValue("@costo", Convert.ToDecimal(costo_B.Text));
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@id_categoria", categoriaSeleccionada.ID);  // Usar el ID de la categoría seleccionada

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente.");

                    // Actualiza el DataGridView del formulario Inicio
                    if (inicioForm is Inicio formInicio)
                    {
                        formInicio.CargarDatosEnDataGridView();
                    }

                    // Regresa al formulario Inicio
                    Inicio invoca = new Inicio();
                    this.Hide();
                    invoca.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public class Categoria
        {
            public int ID { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto es lo que se mostrará en el ComboBox
            }
        }
        private void LlenarComboBox()
        {
            List<Categoria> categorias = new List<Categoria>
    {
            new Categoria { ID = 2, Nombre = "Agua" },
            new Categoria { ID = 4, Nombre = "Alquiler" },
            new Categoria { ID = 7, Nombre = "Despensa" },
            new Categoria { ID = 13, Nombre = "Extras" },
            new Categoria { ID = 3, Nombre = "Gas" },
            new Categoria { ID = 8, Nombre = "Gasolina" },
            new Categoria { ID = 11, Nombre = "Gastos Medicos" },
            new Categoria { ID = 6, Nombre = "Internet" },
            new Categoria { ID = 1, Nombre = "Luz" },
            new Categoria { ID = 9, Nombre = "Pasajes" },
            new Categoria { ID = 5, Nombre = "Predial" },
            new Categoria { ID = 12, Nombre = "Saldo" },
            new Categoria { ID = 10, Nombre = "Seguro" }
    };

            // Establece la lista como la fuente de datos
            comboBox1.DataSource = categorias;

            // Configura el DisplayMember y el ValueMember
            comboBox1.DisplayMember = "Nombre"; // Muestra el nombre en el ComboBox
            comboBox1.ValueMember = "ID"; // Usa el ID como el valor del ComboBox
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_transacciones invoca = new Eliminar_transacciones();
            this.Hide();
            invoca.Show();
        }
    }
}
