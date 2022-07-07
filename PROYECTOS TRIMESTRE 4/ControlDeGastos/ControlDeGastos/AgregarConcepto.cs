using ControlDeGastos.Modelos;
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

namespace ControlDeGastos
{
    public partial class AgregarConcepto : Form
    {
        public bool Adding { get; set; } = true;
        public AgregarConcepto()
        {
            InitializeComponent();
            obtenerRegistros();
            actualizarConceptos();
        }
        public int id()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            var listaConcepto = new List<Conceptos>();
            var ID = 1;

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile);
                listaConcepto = JsonConvert.DeserializeObject<List<Conceptos>>(json);
            }

            if(listaConcepto.Count > 0)
            {
                ID = listaConcepto.Max(x => x.Id + 1);
            }
            return ID;
        }
        private void VaciarCampos() // se crea funcion para elimiar todos los campos del formulario
        {
            txtboxID.Text = id().ToString(); // se obtiene lo escrito en dicho textbox
            txtboxNombre.Text = string.Empty;
            chkIsEnabled.Checked = false;
        }

        private void saveRecord()
        {
            var json = string.Empty; //se crear el json
            var listaConcepto = new List<Conceptos>(); //creo una lista de mi objeto conceptos creado anteriormennte (se crear un listado de todos los conceptos que yo tenga) 
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json"; //(path = ruta) para almacenar el archivo json 

            if (File.Exists(pathFile)) //si existe el archivo en la ruta indicada
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8); //se buscara todo lo que esta en ese archivo y lo metera en esa variable
                listaConcepto = JsonConvert.DeserializeObject<List<Conceptos>>(json);
            }
            var concepto = new Conceptos(); // se crea concepto que es igual a un objeto tipo concepto
            if (Adding) //Adding Record en el caso de que este agregando
            {
                var conceptoExiste = listaConcepto.Count(x => x.Nombre.ToString().ToLower().Trim() == txtboxNombre.Text.ToLower().Trim());
                if (conceptoExiste > 0)
                {
                    MessageBox.Show("Ya este concepto Existe", "LO SENTIMOS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
                concepto = new Conceptos
                {
                    Id = int.Parse(txtboxID.Text), // se crean atributos para cuando queramos anadir concepto
                    Nombre = txtboxNombre.Text,
                    Visibilidad = chkIsEnabled.Checked,
                    FechaCreacion = DateTime.Now
                };
            }
            else //Updating Record si quieremos actualizar
            {
                var Id = int.Parse(txtboxID.Text);
                concepto = listaConcepto.FirstOrDefault(x => x.Id.ToString() == txtboxID.Text);
                if (concepto != null)
                {
                    listaConcepto.Remove(concepto);
                    concepto.Nombre = txtboxNombre.Text;
                    concepto.ModifiedDate = DateTime.Now;
                    concepto.Visibilidad = chkIsEnabled.Checked;
                    concepto.Id = Id;
                }
            }
            listaConcepto.Add(concepto); // se anade nuevo concepto a la lista
            json = JsonConvert.SerializeObject(listaConcepto); //serializar: llevar los datos de nuestro objeto tipo clase (conceptos) Al formato json
            var sw = new StreamWriter(pathFile, false, Encoding.UTF8); //streamwriter: objeto que permite alterar un archivo determinado
            sw.Write(json); 
            sw.Close();

            MessageBox.Show("Registro Almacenado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            gbAgregarConceptos.Enabled = false;
            bttNuevo.Enabled = true;
            bttnGuardar.Enabled = false;
            bttnCancelar.Enabled = false;
            bttnEliminar.Enabled = false;
            VaciarCampos();
            obtenerRegistros(); //metodo para obtener todos los  registros que tenemos en el archivo
            actualizarConceptos();
        }

        private List<Conceptos> obtenerRegistros()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            var listaConcepto = new List<Conceptos>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                listaConcepto = JsonConvert.DeserializeObject<List<Conceptos>>(json);
            }

            //txtboxID.Text = (listaConcepto.Count + 1).ToString();
            //dgvConceptos.DataSource = listaConcepto; // mi dgv sera igual a mi listado de conceptos
            return listaConcepto;
        }

        private void bttNuevo_Click_1(object sender, EventArgs e)
        {
            txtboxID.Text = id().ToString();
            Adding = true; //indica que quiero agregar uno nuevo
            gbAgregarConceptos.Enabled = true;
            bttnCancelar.Enabled = true;
            bttnGuardar.Enabled = true;
            bttNuevo.Enabled = true;
            bttnEliminar.Enabled = false;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            Adding = true;
        }

        private void bttnGuardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCamposRellenos()) //Antes de crear al ciudadano se hace una validacion de que todos los campos se hayan completado
            {
                saveRecord(); //llamando a este metodo al presionar el boton de crear, los datos ingresados se guardan, solo si se cumple la condicion de que todos campos estan rellenos
            }
            obtenerRegistros();
            //else MessageBox.Show("Se produjo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        bool ValidarCamposRellenos() //Valida que los campos del contenedor esten todos llenos
        {
            foreach (Control c in gbAgregarConceptos.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Complete todos los campos", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }
        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actualizarConceptos()
        {
            dgvConceptos.DataSource = obtenerRegistros();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {

            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            var json = File.ReadAllText(pathFile, Encoding.UTF8);
            var listaConcepto = JsonConvert.DeserializeObject<List<Conceptos>>(json);
            //DataGridViewRow fila = this.dgvConceptos.SelectedRows[0];
            var Concepto = listaConcepto.FirstOrDefault(x => x.Id.ToString() == txtboxID.Text);
            listaConcepto.Remove(Concepto);
            json = JsonConvert.SerializeObject(listaConcepto);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            VaciarCampos();
            actualizarConceptos();
            bttnEliminar.Enabled = false;
        }

        private void dgvConceptos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbAgregarConceptos.Enabled = true;
            bttnGuardar.Enabled = true;
            var RowIndex = e.RowIndex; //RowIndex: variable para asignar variable (e) a la fila en la que se hizo el double click
            if(dgvConceptos.RowCount > 0)
            {
                if (RowIndex > -1) // se procura que no sea la fila de los headers
                {
                    List<Conceptos> listaConcepto = obtenerRegistros();
                    bttnEliminar.Enabled = true;
                    rellenarCampos(listaConcepto[RowIndex]);
                }
            }
        }
        private void rellenarCampos(Conceptos concepto)
        {
            txtboxNombre.Text = concepto.Nombre; //al campo se le agrega la propiedad
            txtboxID.Text = Convert.ToString(concepto.Id);
            chkIsEnabled.Checked = concepto.Visibilidad;
            Adding = false;
        }

    }
}

