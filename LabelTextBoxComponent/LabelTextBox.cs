﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Org.Ecos.Logic.Components.LabelTextBox
{
    public partial class LabelTextBox: UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
        }

        private EPosicion _posicion = EPosicion.IZQUIERDA;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA delTextbox")]
        public EPosicion Posicion {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    _posicion = value;
                    Recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get => _posicion;
        }

        private uint _separacion;
        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public uint Separacion
        {
            set
            {
                _separacion = value;

                Recolocar();
                OnSeparacionChanged(EventArgs.Empty);
            }
            get => _separacion;
        }

        [Category("Design")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                label1.Text = value;
                Recolocar();
            }
            get => label1.Text;
        }

        [Category("Design")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set => textBox1.Text = value;
            get => textBox1.Text;
        }

        [Category("Design")]
        [Description("Texto asociado al TextBox del control")]
        public char PswChr
        {
            set => textBox1.PasswordChar = value;
            get => textBox1.PasswordChar;
        }


        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event EventHandler TxtChanged;

        public event EventHandler EventSeparacion;

        private void Recolocar()
        {
            if (_posicion == EPosicion.IZQUIERDA)
            {
                label1.Location = new Point(0, 0);
                textBox1.Location = new Point((int)(label1.Width + Separacion), 0);
                textBox1.Width = 200;
                this.Width = (int)(this.textBox1.Width + label1.Width + Separacion);
                this.Height = Math.Max(textBox1.Height, label1.Height);
            }
            else if (_posicion == EPosicion.DERECHA)
            {
                textBox1.Location = new Point(0, 0);
                textBox1.Width = 200;
                this.Width = (int)(this.textBox1.Width + label1.Width + Separacion);
                label1.Location = new Point((int)(textBox1.Width + Separacion), 0);
                this.Height = Math.Max(textBox1.Height, label1.Height);
            }
        }


        #region Types
        public enum EPosicion
        {
            IZQUIERDA,
            DERECHA
        }


        #endregion

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Recolocar();
        }

        

        protected virtual void OnTxtChanged(EventArgs e)
        {
            this.TxtChanged?.Invoke(this, e);
        }


        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            this.EventSeparacion?.Invoke(this, e);
        }



        private void label1_EventoSeparacion(object sender, EventArgs e)
        {
            OnSeparacionChanged(e);
        }


        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Lanzar this.onkeyup
        {
            OnTxtChanged(e);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }
    }

}
