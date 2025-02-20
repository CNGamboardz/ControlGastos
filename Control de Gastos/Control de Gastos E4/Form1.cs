using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Control_de_Gastos_E4
{
    public partial class Inicio : Form
    {
        MySqlConnection connection;

        public Inicio()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=control_gastos;Uid=root;Pwd=;");
            CargarDatosEnDataGridView(); // Llamar a la función al iniciar el formulario
            ObtenerSumaTotal();

        }

        private void mas_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual (Inicio)
            this.Hide();

            // Crear una instancia del formulario Añadir_Transsacciones y pasarle la referencia de Inicio
            Añadir_Transsacciones formTransacciones = new Añadir_Transsacciones(this);

            // Mostrar el formulario de manera modal
            formTransacciones.ShowDialog();
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
                dataGridView1.DataSource = dataTable;

                // Configura la apariencia del DataGridView (opcional)
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ObtenerSumaTotal()
        {
            try
            {
                connection.Open();

                // Consulta para obtener la suma total de la columna 'costo'
                string query = "SELECT SUM(costo) FROM importe";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Ejecutamos la consulta y obtenemos el resultado
                object result = cmd.ExecuteScalar();  // ExecuteScalar devuelve el primer valor de la primera fila

                // Verificamos si el resultado es null y asignamos 0 si es el caso
                if (result != DBNull.Value)
                {
                    // Convertimos el resultado a decimal y lo mostramos con el formato adecuado
                    suma_total.Text = Convert.ToDecimal(result).ToString("N2");  // Usa "N2" para formatear con comas y dos decimales
                }
                else
                {
                    suma_total.Text = "0.00";  // Si no hay registros, mostramos 0.00
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la suma total: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void Inicio_Load(object sender, EventArgs e)
        {
            // Bloquear el TextBox para que no se pueda editar
            suma_total.ReadOnly = true;  // O suma_total.Enabled = false;
            Total_Buscado.ReadOnly = true;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = Text_Buscar.Text.Trim(); // Usamos el TextBox correcto

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                // Si no hay texto en el cuadro de búsqueda, puedes cargar todos los datos
                CargarDatosEnDataGridView();
                Total_Buscado.Text = "0"; // Reseteamos el total si no hay búsqueda
            }
            else
            {
                try
                {
                    // Establece la consulta SQL con filtro para obtener los campos deseados y sumar el costo
                    string query = "SELECT categoria.nombre, importe.id_importe, importe.costo, importe.fecha " +
                                   "FROM categoria " +
                                   "JOIN importe ON categoria.id_categoria = importe.id_categoria " +
                                   "WHERE categoria.nombre LIKE @categoria";

                    // Crea el comando con la consulta y la conexión
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Usa LIKE para buscar coincidencias en el nombre de la categoría
                    cmd.Parameters.AddWithValue("@categoria", "%" + textoBusqueda + "%");

                    // Abre la conexión
                    connection.Open();

                    // Ejecuta la consulta
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Si quieres actualizar un DataGridView con los resultados
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt; // Suponiendo que el DataGridView se llama 'miDataGridView'

                    reader.Close();

                    // Ahora vamos a calcular el total del costo y asignarlo al TextBox
                    // Realizamos una nueva consulta solo para sumar los costos
                    string sumQuery = "SELECT SUM(importe.costo) FROM categoria " +
                                      "JOIN importe ON categoria.id_categoria = importe.id_categoria " +
                                      "WHERE categoria.nombre LIKE @categoria";

                    MySqlCommand sumCmd = new MySqlCommand(sumQuery, connection);
                    sumCmd.Parameters.AddWithValue("@categoria", "%" + textoBusqueda + "%");

                    // Ejecuta la consulta para la suma del costo
                    var total = sumCmd.ExecuteScalar(); // Esto devuelve el resultado de la suma

                    // Asignamos el resultado a Total_Buscado, si el resultado es null asignamos 0
                    Total_Buscado.Text = total != DBNull.Value ? total.ToString() : "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
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
