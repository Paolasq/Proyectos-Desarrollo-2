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
    public partial class MisGastos : Form
    {
        public bool Adding1 { get; set; } = true;
        public MisGastos()
        {
            InitializeComponent();
            obtenerGastos();
            actualizarGastos();
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
            txtGasto.Text = string.Empty;
            txtboxCantidad.Text = string.Empty;
            txtboxDescrip.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtboxID.Text = string.Empty;

        }
        private void saveGastos()
        {
            var json1 = string.Empty; //se crear el json
            var listaGastos = new List<Gastos>(); //creo una lista de mi objeto conceptos creado anteriormennte (se crear un listado de todos los conceptos que yo tenga) 
            var pathFile1 = $"{AppDomain.CurrentDomain.BaseDirectory}\\gastos.json"; //(path = ruta) para almacenar el archivo json 

            if (File.Exists(pathFile1)) //si existe el archivo en la ruta indicada
            {
                json1 = File.ReadAllText(pathFile1, Encoding.UTF8); //se buscara todo lo que esta en ese archivo y lo metera en esa variable
                listaGastos = JsonConvert.DeserializeObject<List<Gastos>>(json1);
            }

            var GastoExiste = listaGastos.Count(x => x.Gasto.ToString().ToLower().Trim() == txtGasto.Text.ToLower().Trim());
            if (GastoExiste > 0)
            {
                MessageBox.Show("Ya este concepto Existe", "LO SENTIMOS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            var gastos = new Gastos(); // se crea concepto que es igual a un objeto tipo concepto
            if (Adding1) //Adding Record en el caso de que este agregando
            {
                gastos = new Gastos
                {
                    ID = int.Parse(txtboxID.Text), // se crean atributos para cuando queramos anadir concepto
                    Gasto = txtGasto.Text,
                    Descripcion = txtboxDescrip.Text,
                    Cantidad = int.Parse(txtboxCantidad.Text),
                    Monto = int.Parse(txtMonto.Text),
                    Fecha = dtpFecha.Value,
                };
            }
            else //Updating Record si quieremos actualizar
            {
                var Id = int.Parse(txtboxID.Text);
                gastos = listaGastos.FirstOrDefault(x => x.ID.ToString() == txtboxID.Text);
                if (gastos != null)
                {
                    listaGastos.Remove(gastos);
                    gastos.Gasto = txtGasto.Text;
                    gastos.Cantidad = int.Parse(txtboxCantidad.Text);
                    gastos.Descripcion = txtboxDescrip.Text;
                    gastos.Fecha = dtpFecha.Value;
                    gastos.Monto = int.Parse(txtMonto.Text);
                    gastos.ModifiedDate = DateTime.Now;
                }
            }

            listaGastos.Add(gastos); // se anade nuevo concepto a la lista

            json1 = JsonConvert.SerializeObject(listaGastos); //serializar: llevar los datos de nuestro objeto tipo clase (conceptos) Al formato json
            var sw1 = new StreamWriter(pathFile1, false, Encoding.UTF8);
            sw1.Write(json1);
            sw1.Close();

            MessageBox.Show("Gasto Almacenado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            gbIngresosGastos.Enabled = false;
            bttAgregar.Enabled = true;
            bttnCancelar.Enabled = false;
            bttnGuardar.Enabled = false;
            bttnEliminar.Enabled = false;

            VaciarCampos();

            obtenerGastos(); //metodo para obtener todos los  registros que tenemos en el archivo
            actualizarGastos();
        }

        private List<Gastos> obtenerGastos()
        {
            var pathFile1 = $"{AppDomain.CurrentDomain.BaseDirectory}\\gastos.json";
            var listaGastos = new List<Gastos>();

            if (File.Exists(pathFile1))
            {
                var json1 = File.ReadAllText(pathFile1, Encoding.UTF8);
                listaGastos = JsonConvert.DeserializeObject<List<Gastos>>(json1);
            }

            txtboxID.Text = (listaGastos.Count + 1).ToString();
            //dtgGastos.DataSource = listaGastos; // mi dgv sera igual a mi listado de gastos
            return listaGastos;
        }

        private void bttnMore_Click(object sender, EventArgs e)
        {
            //openChildFormInPanel(new AgregarConcepto());

            var oForm = new AgregarConcepto();
            oForm.Show();
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            gbIngresosGastos.Enabled = true;
            bttnCancelar.Enabled = true;
            bttnGuardar.Enabled = true;
            bttAgregar.Enabled = true;
            bttnEliminar.Enabled = false;
            //obtenerGastos();
            //saveGastos();
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<Conceptos> obtenerRegistros() //funcion para obtener en este forms los registros de conceptos y mostrarlos en el combo box
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            var ListaConcepto = new List<Conceptos>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                ListaConcepto = JsonConvert.DeserializeObject<List<Conceptos>>(json);
            }
            if (ListaConcepto == null)
            {
                return new List<Conceptos>();

            }
            return ListaConcepto;
        }
        public void cbConcepto_Click(object sender, EventArgs e)
        {
            cbConcepto.DataSource = obtenerRegistros().FindAll(x => x.Visibilidad==true);
            cbConcepto.DisplayMember = "Nombre";
            cbConcepto.ValueMember = "Nombre";
        }

        private  List<Pago> obtenerMetodosPago()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\pagos.json";
            var listaPagos = new List<Pago>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                listaPagos = JsonConvert.DeserializeObject<List<Pago>>(json);
            }
            if (listaPagos == null)
            {
                return new List<Pago>();

            }
            return listaPagos;

        }
        private void bttnMetodoPago_Click(object sender, EventArgs e)
        {
            var oForm = new AgregarPago();
            oForm.Show();
        }

        private void cbMetodoPago_Click(object sender, EventArgs e)
        {
            cbMetodoPago.DataSource = obtenerMetodosPago().FindAll(x => x.Visibilidad == true);
            cbMetodoPago.DisplayMember = "Metodo";
            cbMetodoPago.ValueMember = "Metodo";

        }
        private void actualizarGastos()
        {
            dtgGastos.DataSource = obtenerGastos();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            var pathFile1 = $"{AppDomain.CurrentDomain.BaseDirectory}\\gastos.json";
            var json1 = File.ReadAllText(pathFile1, Encoding.UTF8);
            var listaGastos = JsonConvert.DeserializeObject<List<Gastos>>(json1);
            DataGridViewRow fila = this.dtgGastos.SelectedRows[0];
            listaGastos.RemoveAt(fila.Index);
            json1 = JsonConvert.SerializeObject(listaGastos);

            var sw = new StreamWriter(pathFile1, false, Encoding.UTF8);
            sw.Write(json1);
            sw.Close();

            actualizarGastos();
            VaciarCampos();
            bttnEliminar.Enabled = false;
        }

        private void dtgGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowIndex = e.RowIndex;
            if (RowIndex > -1) //condicion que solo permitira eliminar las celdas que no son titulos
            {
                List<Gastos> listaPagos = obtenerGastos();
                bttnEliminar.Enabled = true;
                rellenarCampos(listaPagos[RowIndex]);
            }
        }
        private void rellenarCampos(Gastos gasto)
        {
            txtGasto.Text = gasto.Gasto;
            txtboxID.Text = Convert.ToString(gasto.ID);
            txtboxCantidad.Text = Convert.ToString(gasto.Cantidad);
            txtMonto.Text = Convert.ToString(gasto.Monto);
            txtboxDescrip.Text = gasto.Descripcion;
        }
        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            obtenerGastos();

            if (ValidarCamposRellenos()) //Antes de crear al ciudadano se hace una validacion de que todos los campos se hayan completado
            {
                saveGastos(); //llamando a este metodo al presionar el boton de crear, los datos ingresados se guardan, solo si se cumple la condicion de que todos campos estan rellenos
            }
            //else MessageBox.Show("Se produjo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        bool ValidarCamposRellenos() //Valida que los campos del contenedor esten todos llenos
        {
            foreach (Control c in gbIngresosGastos.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Complete todos los campos", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }
    }

}

