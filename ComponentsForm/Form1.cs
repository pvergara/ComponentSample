using Org.Ecos.Logic.Components.LabelTextBox;

namespace ComponentsForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.label1.Posicion = LabelTextBox.EPosicion.DERECHA;
        }

        private void label1_Perico_1(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;

        }

        private void label1_EventoSeparacion(object sender, EventArgs e)
        {
            this.Text = "Separacion: " + label1.Separacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Posicion == LabelTextBox.EPosicion.DERECHA)
            {
                label1.Posicion = LabelTextBox.EPosicion.IZQUIERDA;

            }
            else if (label1.Posicion == LabelTextBox.EPosicion.IZQUIERDA)
            {
                label1.Posicion = LabelTextBox.EPosicion.DERECHA;

            }
            this.Text = "" + label1.Posicion;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Separacion += 5;
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            MessageBox.Show("HII");
        }
    }
}
