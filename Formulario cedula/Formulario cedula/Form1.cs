namespace Formulario_cedula
{
    public partial class Forms1 : Form
    {
        List<Ciudadano> Ciudadanos = new List<Ciudadano>();

        public Forms1()
        {
            InitializeComponent();
        }


        void buttonActualizar_Click(object sender, EventArgs e)
        {
            var Ciudadano = new Ciudadano
            {
                Id = Guid.NewGuid(),
                Nombre = textBoxNombre.Text,
                Cedula = textBoxCedula.Text,
                LugarNacimiento = textBoxLugar.Text,
                Nacionalidad = textBoxNacionalidad.Text,
                Ocupacion = textBoxOcupacion.Text
            };

            Ciudadanos.Add(Ciudadano);
            MessageBox.Show("Ciudadano Registrado");

            EmptyControls();
            buttonCrear.Enabled = true;
            buttonActualizar.Enabled = false;
            buttonBorrar.Enabled = false;
            buttonSubirfoto.Enabled = false;
            gbPanel.Enabled = false;
            GetCiudadanos();
        }

        void EmptyControls()
        {
            pbFoto.Image = null;

            foreach (Control c in gbPanel.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
            }
        }

        void GetCiudadanos()
        {
            dgvCiudadanos.DataSource = null;
            dgvCiudadanos.DataSource = Ciudadanos;

        }

        void buttonCrear_Click(object sender, EventArgs e)
        {
            buttonCrear.Enabled = false;
            buttonActualizar.Enabled = true;
            buttonBorrar.Enabled = true;
            gbPanel.Enabled = true;
        }

        void buttonBorrar_Click(object sender, EventArgs e)
        {
            EmptyControls();
        }

        void buttonSubirfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
    public class Ciudadano
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public string Sangre { get; set; }
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string FechaExp { get; set; }
    }
}