namespace ejercicio8form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnformula_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            var formula = (N * (N + 1)) / 2;
            MessageBox.Show($"la suma de los primeros N numero entero es {formula}", "resultado",
            MessageBoxButtons.OK, MessageBoxIcon.Question);
            Limpieza();
        }

        private void Limpieza()
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fin del Programa", "Salir",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}