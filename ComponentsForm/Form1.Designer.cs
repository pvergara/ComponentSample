using Org.Ecos.Logic.Components.LabelTextBox;
using static Org.Ecos.Logic.Components.LabelTextBox.LabelTextBox;

namespace ComponentsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new LabelTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 38);
            label1.Margin = new Padding(4, 4, 4, 4);
            label1.Name = "label1";
            label1.Posicion = LabelTextBox.EPosicion.DERECHA;
            label1.Separacion = 0U;
            label1.Size = new Size(523, 26);
            label1.TabIndex = 0;
            label1.TextLbl = "label1";
            label1.TextTxt = "";
            label1.TxtChanged += label1_Perico_1;
            label1.EventSeparacion += label1_EventoSeparacion;
            // 
            // button1
            // 
            button1.Location = new Point(212, 88);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 1;
            button1.Text = "Boton Posicion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(212, 156);
            button2.Name = "button2";
            button2.Size = new Size(162, 23);
            button2.TabIndex = 2;
            button2.Text = "Boton Separacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // etiquetaAviso1
            // 
            etiquetaAviso1.BeginColor = Color.FromArgb(255, 192, 192);
            etiquetaAviso1.EndColor = Color.FromArgb(255, 255, 128);
            etiquetaAviso1.HasGradient = true;
            etiquetaAviso1.ImagenMarca = null;
            etiquetaAviso1.Location = new Point(194, 172);
            etiquetaAviso1.Marca = EtiquetaAviso.EMarca.Imagen;
            etiquetaAviso1.Name = "etiquetaAviso1";
            etiquetaAviso1.Size = new Size(90, 20);
            etiquetaAviso1.TabIndex = 1;
            etiquetaAviso1.Text = "hola 4342432";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelTextBox label1;
    }
}
