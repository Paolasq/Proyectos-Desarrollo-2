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
        List<Ciudadano> listaCiudadanos = new List<Ciudadano>(); //creacion de lista para almacener a los ciudadanos registrados 
        public Form1()
        {
            InitializeComponent();
            GetCiudadanos();
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
            var ciudadanoExiste = listaCiudadanos.Count(x => x.Cedula.ToString().ToLower().Trim() == txtBoxCedula.Text.ToLower().Trim());
            if (ciudadanoExiste > 0)
            {
                MessageBox.Show("Ya este ciudadano Existe", "LO SENTIMOS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Adding = false;
            }

            var ciudadanos = new Ciudadano(); // se crea concepto que es igual a un objeto tipo concepto
            if (Adding) //Adding Record en el caso de que este agregando
            {
                ciudadanos = new Ciudadano
                {
                    //Id = int.Parse(txtboxID.Text), // se crean atributos para cuando queramos anadir concepto
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
                    Foto = pbFoto.ImageLocation,
                };
            }

            else //Updating Record si quieremos actualizar
            {
                //var Id = int.Parse(txtboxID.Text);
                ciudadanos = listaCiudadanos.FirstOrDefault(x => x.Cedula.ToString() == txtBoxCedula.Text);
                //if (ciudadanos != null)
                //{
                    listaCiudadanos.Remove(ciudadanos);
                    ciudadanos.Nombre = txtBoxNombre.Text;
                    ciudadanos.Sexo = Sexo;
                    ciudadanos.LugarNacimiento = txtboxLugarNaci.Text;
                    ciudadanos.FechaNacimiento = dtpNacimiento.Value; // indicamos que la propiedad debe de contener la fecha seleccionada en el datetimepicker 
                    ciudadanos.Nacionalidad = txtBoxNacionalidad.Text;
                    ciudadanos.Sangre = cbSangre.Text; // indicamos que la propiedad sangre debe contener la opcion que se seleccione en el combobox
                    ciudadanos.EstadoCivil = txtBoxEstadoCivil.Text;
                    ciudadanos.FechaExpiracion = dtpExpiracion.Value; // indicamos que la propiedad debe de contener la fecha seleccionada en el datetimepicker 
                    ciudadanos.Ocupacion = txtBoxOcupacion.Text;
                    ciudadanos.Foto = pbFoto.ImageLocation;
                //}
            }
            listaCiudadanos.Add(ciudadanos); // cada ciudadano que se vaya creando se agregara a la lista
            json = JsonConvert.SerializeObject(listaCiudadanos); //serializar: llevar los datos de nuestro objeto tipo clase (conceptos) Al formato json
            var sw = new StreamWriter(pathFile, false, Encoding.UTF8); //streamwriter: objeto que permite alterar un archivo determinado
            sw.Write(json);
            sw.Close();
            MessageBox.Show("Ciudadano agregado", "EXITO" , MessageBoxButtons.OK, MessageBoxIcon.None);
            //GetCiudadanos(); //llamamos al metodo para que cada vez que se cree el ciudadano, la dgv se actualice 
            //dgvCiudadanos.DataSource = GetCiudadanos();
            actualizarCiudadano();
            limpiarCampos();
        }
        private List<Ciudadano> GetCiudadanos()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ciudadano.json";
            var listaCiudadanos = new List<Ciudadano>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                listaCiudadanos = JsonConvert.DeserializeObject<List<Ciudadano>>(json);
            }
            dgvCiudadanos.DataSource = listaCiudadanos;
            return listaCiudadanos;

            //txtboxID.Text = (listaConcepto.Count + 1).ToString();
            //dgvConceptos.DataSource = listaConcepto; // mi dgv sera igual a mi listado de conceptos

            //dgvCiudadanos.DataSource = null;
            //dgvCiudadanos.DataSource = listaCiudadanos; //el datagridview obtiene la lista de ciudadanos
        }

        private void bttnCrear_Click(object sender, EventArgs e)
        {
            Adding = true;
            gbDatosPersonales.Enabled = true;
            bttnCancelar.Enabled = true;
            bttnGuardar.Enabled = true;
            bttnCrear.Enabled = true;
            bttnEliminar.Enabled = false;
            limpiarCampos();
            //if (ValidarCamposRellenos()) //Antes de crear al ciudadano se hace una validacion de que todos los campos se hayan completado
            //{
            //CrearCiudadano(); //llamando a este metodo al presionar el boton de crear, los datos ingresados se guardan, solo si se cumple la condicion de que todos campos estan rellenos

            //}
            //else MessageBox.Show("Se produjo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
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
            //gbDatosPersonales.Enabled = false; //desactivando el panel
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
                pbFoto.ImageLocation = abrirArchivo.FileName;

            }

        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            GetCiudadanos();
            if (ValidarCamposRellenos()) //Antes de crear al ciudadano se hace una validacion de que todos los campos se hayan completado
            {
                CrearCiudadano(); //llamando a este metodo al presionar el boton de crear, los datos ingresados se guardan, solo si se cumple la condicion de que todos campos estan rellenos
                GetCiudadanos();
            }
            else MessageBox.Show("Se produjo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Adding = false;
            gbDatosPersonales.Enabled = false;
            limpiarCampos();

        }
        private void rellenarCampos(Ciudadano ciudadanos)
        {
            txtBoxNombre.Text = ciudadanos.Nombre;
            txtBoxCedula.Text = ciudadanos.Cedula;
            txtBoxEstadoCivil.Text = ciudadanos.EstadoCivil;
            txtboxLugarNaci.Text = ciudadanos.LugarNacimiento;
            txtBoxNacionalidad.Text = ciudadanos.Nacionalidad;
            txtBoxOcupacion.Text = ciudadanos.Ocupacion;
            dtpNacimiento.Value = ciudadanos.FechaNacimiento;
            dtpExpiracion.Value = ciudadanos.FechaExpiracion;
            cbSangre.Text = ciudadanos.Sangre;
            Sexo = ciudadanos.Sexo;
            pbFoto.ImageLocation = ciudadanos.Foto;
        }

        private void dgvCiudadanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowIndex = e.RowIndex;
            if (RowIndex > -1)
            {
                List<Ciudadano>listaCiudadanos = GetCiudadanos();
                bttnEliminar.Enabled = true;
                rellenarCampos(listaCiudadanos[RowIndex]);
            }
        }
        private void actualizarCiudadano()
        {
            dgvCiudadanos.DataSource = GetCiudadanos();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ciudadano.json";
            var json = File.ReadAllText(pathFile, Encoding.UTF8);
            var listaCiudadanos = JsonConvert.DeserializeObject<List<Ciudadano>>(json);
            var Concepto = listaCiudadanos.FirstOrDefault(x => x.Cedula.ToString() == txtBoxCedula.Text);
            listaCiudadanos.Remove(Concepto);
            json = JsonConvert.SerializeObject(listaCiudadanos);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            limpiarCampos();
            actualizarCiudadano();
            bttnEliminar.Enabled = false;

        }

    }
}
