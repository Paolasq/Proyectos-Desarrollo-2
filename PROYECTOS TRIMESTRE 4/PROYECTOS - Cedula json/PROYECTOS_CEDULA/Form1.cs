using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOS_CEDULA
{
    public partial class Form1 : Form
    {
        public bool Adding { get; set; } = true;
        //List<Ciudadano> listaCiudadanos = new List<Ciudadano>(); //creacion de lista para almacener a los ciudadanos registrados 
        public Form1()
        {
            InitializeComponent();
        }
        char Sexo = 'F';
        private void CrearCiudadano() //metodo donde se guardaran los datos de cada ciudadano que solo sera visible en la clase que se defina (void se utiliza si el metodo no retorna nada)
        {
            var json = string.Empty; //se crear el json
            var listaCiudadanos = new List<Ciudadano>(); //creo una lista de mi objeto conceptos creado anteriormennte (se crear un listado de todos los conceptos que yo tenga) 
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ciudadano.json"; //(path = ruta) para almacenar el archivo json 

            if (File.Exists(pathFile)) //si existe el archivo en la ruta indicada
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8); //se buscara todo lo que esta en ese archivo y lo metera en esa variable
                listaCiudadanos = JsonConvert.DeserializeObject<List<Ciudadano>>(json);
            }
            var ciudadano = new Ciudadano(); // se crea concepto que es igual a un objeto tipo concepto
            if (Adding) //Adding Record en el caso de que este agregando
            {
                var ciudadanoExiste = listaCiudadanos.Count(x => x.Nombre.ToString().ToLower().Trim() == txtBoxNombre.Text.ToLower().Trim());
                if (ciudadanoExiste > 0)
                {
                    MessageBox.Show("Ya este concepto Existe", "LO SENTIMOS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
                ciudadano = new Ciudadano
                {
                    //Id = int.Parse(txtboxID.Text), // se crean atributos para cuando queramos anadir concepto
                    Nombre = txtBoxNombre.Text,
                    Nacionalidad = txtBoxNacionalidad.Text,
                    EstadoCivil = txtBoxEstadoCivil.Text,
                    FechaExpiracion = dtpExpiracion     
                    Visibilidad = chkIsEnabled.Checked,
                    FechaCreacion = DateTime.Now
                };


                listaCiudadanos.Add(ciudadano); // cada ciudadano que se vaya creando se agregara a la lista
                GetCiudadanos(); //llamamos al metodo para que cada vez que se cree el ciudadano, la dgv se actualice 
                MessageBox.Show("Ciudadano agregado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.None);
                limpiarCampos();
            }

        }
        private void GetCiudadanos()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ciudadano.json";
            var listaCiudadanos = new List<Ciudadano>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                listaCiudadanos = JsonConvert.DeserializeObject<List<Ciudadano>>(json);
            }
            return listaCiudadanos;
            //txtboxID.Text = (listaCiudadanos.Count + 1).ToString();
            //dgvConceptos.DataSource = listaConcepto; // mi dgv sera igual a mi listado de conceptos
            //dgvCiudadanos.DataSource = null;
            //dgvCiudadanos.DataSource = listaCiudadanos; //el datagridview obtiene la lista de ciudadanos
        }

        private void bttnCrear_Click(object sender, EventArgs e)
        {
            gbDatosPersonales.Enabled = true;
            //if (ValidarCamposRellenos()) //Antes de crear al ciudadano se hace una validacion de que todos los campos se hayan completado
            //{
                //CrearCiudadano(); //llamando a este metodo al presionar el boton de crear, los datos ingresados se guardan, solo si se cumple la condicion de que todos campos estan rellenos

            //}
            //else MessageBox.Show("Se produjo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
        }
        private void bttnEliminar_Click(object sender, EventArgs e)
        {

            //limpiarCampos();
        }
        private void limpiarCampos()
        {
            foreach (Control c in gbDatosPersonales.Controls) //bucle que recorre todos los datos del panel | hasta encontrar alguno vacio
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

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposRellenos()) //Antes de crear al ciudadano se hace una validacion de que todos los campos se hayan completado
            {
                CrearCiudadano(); //llamando a este metodo al presionar el boton de crear, los datos ingresados se guardan, solo si se cumple la condicion de que todos campos estan rellenos

            }
            else MessageBox.Show("Se produjo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dgvCiudadanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bttnEliminar.Enabled = true;

        }
        private void bttnEliminar_Click_1(object sender, EventArgs e)
        {

        }

    }
}
