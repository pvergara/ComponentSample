using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ComponentsForm
{
    public class EtiquetaAviso : Control  //Subrayado de labeltextbox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using var graphics = e.Graphics;
            var width = 0;
            var height = this.Font.Height;
            var offsetX = 0;
            var offsetY = 0;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (this.HasGradient) {
                using var linearGradient = new LinearGradientBrush(new Point(0, 0), new Point(width, height), this.BeginColor, this.EndColor);
                e.Graphics.FillRectangle(linearGradient, 0, 0, this.Size.Width, this.Size.Width);
            }

            Pen pen;
            switch (this.Marca)
            {
                case EMarca.Cruz:
                    width = 3;
                    using (pen = new Pen(Color.Red, width))
                    {
                        graphics.DrawLine(pen, width, width, height, height);
                        graphics.DrawLine(pen, height, width, width, height);
                        offsetX = height + width;
                        offsetY = width / 2;
                    }
                    break;
                case EMarca.Circulo:
                    width = 20;
                    pen = new Pen(Color.Green, width);
                    graphics.DrawEllipse(pen, width, width, height, height);
                    offsetX = height + width;
                    offsetY = width;
                    pen.Dispose();
                    break;
                case EMarca.Nada:
                    break;
                case EMarca.Imagen:
                    if (_imagenMarca != null)
                    {
                        width = 20;
                        graphics.DrawImage(this._imagenMarca, width, width, height, height);
                        offsetX = height + width;
                        offsetY = width;
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            using var solidBrush = new SolidBrush(this.ForeColor);


            graphics.DrawString(this.Text, this.Font, solidBrush, offsetX + width, offsetY);

            var tam = graphics.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + width, tam.Height + offsetY * 2);

        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        private EMarca marca = EMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get => marca;
        }

        [Category("Appearance")]
        [Description("Indica si se muestra o no el gradiente")]
        private Boolean _hasGradient = false;
        public Boolean HasGradient
        {
            set
            {
                _hasGradient = value;
                this.Refresh();
            }
            get => _hasGradient;
        }

        private Color _beginColor;
        [Category("Appearance")]
        [Description("Indica el color de inicio del gradiente")]
        public Color BeginColor
        {
            get => _beginColor;
            set
            {
                _beginColor = value;
                this.Refresh();
            }
        }

        private Color _endColor;
        [Category("Appearance")]
        [Description("Indica el color de inicio del gradiente")]
        public Color EndColor
        {
            get => _endColor;
            set
            {
                _endColor = value;
                this.Refresh();
            }
        }

        private Image? _imagenMarca;
        [Category("Appearance")]
        [Description("Indica la imagen (en caso de seleccionar EMarca=Imagen)")]
        public Image? ImagenMarca
        {
            get => _imagenMarca;
            set
            {
                _imagenMarca = value;
                this.Refresh();
            }
        }

        public event EventHandler ClickEnMarca;

        private void marcaClick(EventArgs e)
        {
            ClickEnMarca?.DynamicInvoke(e);
            MessageBox.Show("clicked");
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (MousePosition.X < this.Width)
            {
                marcaClick(e); 
            }
        }

        public enum EMarca
        {
            Nada,
            Cruz,
            Circulo,
            Imagen
        }
    }
}
