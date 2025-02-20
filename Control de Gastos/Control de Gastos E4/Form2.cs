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
    public partial class Eliminar_transacciones : Form
    {
        MySqlConnection connection;

        public Eliminar_transacciones()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=control_gastos;Uid=root;Pwd=;");
            CargarDatosEnDataGridView(); // Llamar a la función al iniciar el formulario
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Añadir_Transsacciones invoca = new Añadir_Transsacciones();
            this.Hide();
            invoca.Show();
        }

        public void CargarDatosEnDataGridView()
        {
            try
            {
                connection.Open();

                // Realiza un JOIN entre la tabla 'importe' y 'categorias' para obtener los datos
                string query = @"
                SELECT 
                    i.id_importe, 
                    i.costo, 
                    i.fecha, 
                    c.Nombre AS categoria
                FROM 
                    importe i
                INNER JOIN 
                    categoria c 
                ON 
                    i.id_categoria = c.id_categoria";  // Usamos el nombre correcto de la columna

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asigna los datos al DataGridView
                Mostrar_Datos.DataSource = dataTable;

                // Configura la apariencia del DataGridView (opcional)
                Mostrar_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Mostrar_Datos.ReadOnly = true;
                Mostrar_Datos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Mostrar_Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Verifica que se haya seleccionado una fila válida
            {
                DataGridViewRow row = Mostrar_Datos.Rows[e.RowIndex];

                id_importe.Text = Convert.ToInt32(row.Cells["id_importe"].Value).ToString();

                // Llena los TextBox con los datos de la fila seleccionada
                costo_B1.Text = row.Cells["costo"].Value.ToString();

                // Convierte la fecha en formato adecuado y la muestra en el TextBox
                DateTime fecha = Convert.ToDateTime(row.Cells["fecha"].Value);
                Fecha1.Text = fecha.ToString("yyyy-MM-dd");  // O usa el formato que prefieras

                comboBox1.Text = row.Cells["categoria"].Value.ToString();

                // Desactiva los TextBox para que no puedan ser editados
                id_importe.ReadOnly = true;  // id_importe es un TextBox
                costo_B1.ReadOnly = true;    // costo_B1 es un TextBox

                // Desactivar el ComboBox para que no se pueda seleccionar otro valor
                comboBox1.Enabled = false;  // comboBox_categoria es el ComboBox

                // Desactivar el DateTimePicker para que no se pueda cambiar la fecha
                Fecha1.Enabled = false;  // dateTimePicker1 es el control para la fecha
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si hay un ID seleccionado
            if (string.IsNullOrEmpty(id_importe.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Muestra el mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Verifica si la conexión está abierta, y si no lo está, abre la conexión
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    // Consulta SQL para eliminar el registro
                    string query = "DELETE FROM importe WHERE id_importe = @id_importe";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Asigna el valor del TextBox al parámetro de la consulta
                    cmd.Parameters.AddWithValue("@id_importe", id_importe.Text);  // Utiliza el valor del TextBox

                    // Ejecuta el comando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro eliminado correctamente.");

                    // Recarga los datos en el DataGridView
                    CargarDatosEnDataGridView();

                    // Regresa al formulario principal
                    Inicio invoca = new Inicio();
                    this.Hide();
                    invoca.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                finally
                {
                    // Cierra la conexión si está abierta
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

    }
}
