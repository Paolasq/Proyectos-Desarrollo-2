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

        private void GenerateNewID()
        {
            VaciarCampos();
            //var Id = 1; // se indica que es un id numerico con valor inicial de 1
            //txtboxID.Text = Id.ToString(); // se obtiene lo escrito en dicho textbox
        }

        private void VaciarCampos() // se crea funcion para elimiar todos los campos del formulario
        {
            txtboxID.Text = string.Empty; // se obtiene lo escrito en dicho textbox
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
                }
            }

            listaConcepto.Add(concepto); // se anade nuevo concepto a la lista

            json = JsonConvert.SerializeObject(listaConcepto); //serializar: llevar los datos de nuestro objeto tipo clase (conceptos) Al formato json

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
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

            txtboxID.Text = (listaConcepto.Count + 1).ToString();
            //dgvConceptos.DataSource = listaConcepto; // mi dgv sera igual a mi listado de conceptos
            return listaConcepto;
        }

        private void bttNuevo_Click_1(object sender, EventArgs e)
        {
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
            saveRecord();
            obtenerRegistros();
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
            DataGridViewRow fila = this.dgvConceptos.SelectedRows[0];
            listaConcepto.RemoveAt(fila.Index);
            json = JsonConvert.SerializeObject(listaConcepto);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            actualizarConceptos();
            VaciarCampos();
            bttnEliminar.Enabled = false;
        }

        private void dgvConceptos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowIndex = e.RowIndex;
            if(RowIndex > -1)
            {
                List<Conceptos> listaConcepto = obtenerRegistros();
                bttnEliminar.Enabled = true;
                rellenarCampos(listaConcepto[RowIndex]);
            }
        }
        private void rellenarCampos(Conceptos concepto)
        {
            txtboxNombre.Text = concepto.Nombre;
            txtboxID.Text = Convert.ToString(concepto.Id);
            chkIsEnabled.Checked = concepto.Visibilidad;
            Adding = false;
        }
    }
}
