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
    public partial class AgregarPago : Form
    {
        public bool Adding2 { get; set; } = true;

        public AgregarPago()
        {
            InitializeComponent();
            obtenerMetodosPago();
            actualizarMetodos();

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
            txtboxMetodo.Text = string.Empty;
            chkIsEnabled.Checked = false;
        }

        private void saveMetodos()
        {
            var json2 = string.Empty; //se crear el json
            var listaPagos = new List<Pago>(); //creo una lista de mi objeto conceptos creado anteriormennte (se crear un listado de todos los conceptos que yo tenga) 
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\pagos.json"; //(path = ruta) para almacenar el archivo json 

            if (File.Exists(pathFile)) //si existe el archivo en la ruta indicada
            {
                json2 = File.ReadAllText(pathFile, Encoding.UTF8); //se buscara todo lo que esta en ese archivo y lo metera en esa variable
                listaPagos = JsonConvert.DeserializeObject<List<Pago>>(json2);
            }

            var pago = new Pago(); // se crea concepto que es igual a un objeto tipo concepto
            if (Adding2) //Adding Record en el caso de que este agregando
            {
                var MetodoExiste = listaPagos.Count(x => x.Metodo.ToString().ToLower().Trim() == txtboxMetodo.Text.ToLower().Trim());
                if (MetodoExiste > 0)
                {
                    MessageBox.Show("Ya este concepto Existe", "LO SENTIMOS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
                pago = new Pago
                {
                    Id = int.Parse(txtboxID.Text), // se crean atributos para cuando queramos anadir concepto
                    Metodo = txtboxMetodo.Text,
                    Visibilidad = chkIsEnabled.Checked,
                    CreatedDate = DateTime.Now

                };
            }
            else //Updating Record si quieremos actualizar
            {
                var Id = int.Parse(txtboxID.Text);
                pago = listaPagos.FirstOrDefault(x => x.Id.ToString() == txtboxID.Text);
                if (pago != null)
                {
                    listaPagos.Remove(pago);
                    pago.Metodo = txtboxMetodo.Text;
                    pago.ModifiedDate = DateTime.Now;
                    pago.Visibilidad = chkIsEnabled.Checked;

                }
            }

            listaPagos.Add(pago); // se anade nuevo concepto a la lista

            json2 = JsonConvert.SerializeObject(listaPagos); //serializar: llevar los datos de nuestro objeto tipo clase (conceptos) Al formato json

            var sw2 = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw2.Write(json2);
            sw2.Close();

            MessageBox.Show("Metodo de pago Almacenado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            gbAgregarMetodo.Enabled = false;
            bttNuevo.Enabled = true;
            bttnGuardar.Enabled = false;
            bttnCancelar.Enabled = false;
            bttnEliminar.Enabled = false;

            VaciarCampos();
            obtenerMetodosPago(); //metodo para obtener todos los  registros que tenemos en el archivo
            actualizarMetodos();
        }

        private List<Pago> obtenerMetodosPago()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\pagos.json";
            var listaPagos = new List<Pago>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                listaPagos = JsonConvert.DeserializeObject<List<Pago>>(json);
            }

            txtboxID.Text = (listaPagos.Count + 1).ToString();
            //dgvMetodos.DataSource = listaPagos; // mi dgv sera igual a mi listado de Pagos
            return listaPagos;
        }


        private void bttNuevo_Click_1(object sender, EventArgs e)
        {
            gbAgregarMetodo.Enabled = true;
            bttnCancelar.Enabled = true;
            bttnGuardar.Enabled = true;
            bttNuevo.Enabled = false;
            bttnEliminar.Enabled = false;

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            Adding2 = true;
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttNuevo_Click(object sender, EventArgs e)
        {
            gbAgregarMetodo.Enabled = true;
            bttnCancelar.Enabled = true;
            bttnGuardar.Enabled = true;
            bttNuevo.Enabled = false;

        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            saveMetodos();
            obtenerMetodosPago();
            actualizarMetodos(); 
        }
        private void actualizarMetodos()
        {
            dgvMetodos.DataSource = obtenerMetodosPago();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\pagos.json";
            var json = File.ReadAllText(pathFile, Encoding.UTF8);
            var listaPagos = JsonConvert.DeserializeObject<List<Pago>>(json);
            DataGridViewRow fila = this.dgvMetodos.SelectedRows[0];
            listaPagos.RemoveAt(fila.Index);
            json = JsonConvert.SerializeObject(listaPagos);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            actualizarMetodos();
            VaciarCampos();
            bttnEliminar.Enabled = false;
        }

        private void dgvMetodos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            if(rowIndex > -1)
            {
                List<Pago> listaPagos = obtenerMetodosPago();
                bttnEliminar.Enabled = true;
                rellenarCampos(listaPagos[rowIndex]);

            }
        }
        private void rellenarCampos(Pago pago)
        {
            txtboxMetodo.Text = pago.Metodo;
            txtboxID.Text = Convert.ToString(pago.Id);
            chkIsEnabled.Checked = pago.Visibilidad;
            Adding2 = false;
        }
    }
}
