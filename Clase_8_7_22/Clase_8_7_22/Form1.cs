namespace Clase_8_7_22
{
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = textNombre.Text;
            persona.direccion = textDireccion.Text;
            persona.edad = int.Parse(textEdad.Text);

            personas.Add(persona);
            limpiar();
            dtgvPersonas.DataSource = null;
            dtgvPersonas.DataSource = persona;

        }

        private void limpiar()
        {
            textNombre.Text = String.Empty;
            textDireccion.Text = String.Empty;
            textEdad.Text = String.Empty;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminando = textNombre.Text;
            Persona perEliminada = personas.Find(x => x.nombre == eliminando);
            personas.Remove(perEliminada);
            dtgvPersonas.DataSource = null;
            dtgvPersonas.DataSource = personas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}