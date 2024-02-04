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

        private void label1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
        }

        private void label1_Perico_1(object sender, KeyPressEventArgs e)
        {
            this.Text = "Sólo a: " + e.KeyChar;

        }
    }
}
