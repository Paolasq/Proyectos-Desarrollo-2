using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOS_CEDULA
{
    public partial class Form1 : Form
    {
        List<Ciudadano> listaCiudadanos = new List<Ciudadano>(); //creacion de lista para almacener a los ciudadanos registrados 
        public Form1()
        {
            InitializeComponent();
        }
        char Sexo = 'F';
        private void CrearCiudadano() //metodo donde se guardaran los datos de cada ciudadano que solo sera visible en la clase que se defina (void se utiliza si el metodo no retorna nada)
        {

            var persona = new Ciudadano // var es utilizado cuando no queremos especificar el tipo de variable ya que en esta se encontraran varios tipos DE datos
            {
                Id = Guid.NewGuid(),
                Nombre = txtBoxNombre.Text, //indicamos que la propiedad nombre debe de contener lo escrito en el combobox
                Cedula = txtBoxCedula.Text,
                Sexo = Sexo,
                LugarNacimiento = txtboxLugarNaci.Text,
                FechaNacimiento = dtpNacimiento.Value, // indicamos que la propiedad debe de contener la fecha seleccionada en el datetimepicker 
                Nacionalidad = txtBoxNacionalidad.Text,
                Sangre = cbSangre.Text, // indicamos que la propiedad sangre debe contener la opcion que se seleccione en el combobox
                EstadoCivil = txtBoxEstadoCivil.Text,
                FechaExpiracion = dtpExpiracion.Value, // indicamos que la propiedad debe de contener la fecha seleccionada en el datetimepicker 
                Ocupacion = txtBoxOcupacion.Text,
            };

            listaCiudadanos.Add(persona); // cada ciudadano que se vaya creando se agregara a la lista

            GetCiudadanos(); //llamamos al metodo para que cada vez que se cree el ciudadano, la dgv se actualice 
            MessageBox.Show("Ciudadano agregado", "EXITO" , MessageBoxButtons.OK, MessageBoxIcon.None);
            limpiarCampos();

        }
        private void GetCiudadanos()
        {
            dgvCiudadanos.DataSource = null;
            dgvCiudadanos.DataSource = listaCiudadanos; //el datagridview obtiene la lista de ciudadanos
        }

        private void bttnCrear_Click(object sender, EventArgs e)
        {
            gbDatosPersonales.Enabled = true;
            if (ValidarCamposRellenos()) //Antes de crear al ciudadano se hace una validacion de que todos los campos se hayan completado
            {
                CrearCiudadano(); //llamando a este metodo al presionar el boton de crear, los datos ingresados se guardan, solo si se cumple la condicion de que todos campos estan rellenos

            }
            else MessageBox.Show("Se produjo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
        }
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            foreach (Control c in gbDatosPersonales.Controls) //bucle que recorre todos los datos del panel hasta encontrar alguno vacio
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            txtBoxNombre.Clear();
            pbFoto.Image = null;
            gbDatosPersonales.Enabled = false; //desactivando el panel
        }
        bool ValidarCamposRellenos() //Valida que los campos del contenedor esten todos llenos
        {
            foreach (Control c in gbDatosPersonales.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Complete todos los campos", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = rbFemenino.Checked ? 'F' : 'M';
        }

        private void bttnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog(); // clase creada para abrir archivos 
            abrirArchivo.Filter = "Image files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; //filtrando el archivo por los tipos 
            if (abrirArchivo.ShowDialog() == DialogResult.OK) 
            {
                pbFoto.Image = new Bitmap(abrirArchivo.FileName);
            }

        }
    }
}
