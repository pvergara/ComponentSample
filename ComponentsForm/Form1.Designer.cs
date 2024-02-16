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
            etiquetaAviso1 = new EtiquetaAviso();
            button1 = new Button();
            button2 = new Button();
            label1 = new LabelTextBox();
            SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            etiquetaAviso1.BeginColor = Color.FromArgb(255, 255, 128);
            etiquetaAviso1.EndColor = Color.Cyan;
            etiquetaAviso1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiquetaAviso1.HasGradient = true;
            etiquetaAviso1.ImagenMarca = Properties.Resources.img8;
            etiquetaAviso1.Location = new Point(31, 229);
            etiquetaAviso1.Marca = EtiquetaAviso.EMarca.Imagen;
            etiquetaAviso1.Name = "etiquetaAviso1";
            etiquetaAviso1.Size = new Size(665, 133);
            etiquetaAviso1.TabIndex = 1;
            etiquetaAviso1.Text = "Hola que tal estas";
            etiquetaAviso1.Click += EtiquetaAviso.OnClick;
            // 
            // button1
            // 
            button1.Location = new Point(416, 106);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 1;
            button1.Text = "Boton Posicion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(416, 166);
            button2.Name = "button2";
            button2.Size = new Size(162, 23);
            button2.TabIndex = 2;
            button2.Text = "Boton Separacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.LabelUnderlined = false;
            label1.Location = new Point(31, 38);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Posicion = EPosicion.DERECHA;
            label1.PswChr = '\0';
            label1.Separacion = 0U;
            label1.Size = new Size(523, 23);
            label1.TabIndex = 0;
            label1.TextLbl = "label1";
            label1.TextTxt = "";
            label1.TxtChanged += label1_Perico_1;
            label1.EventSeparacion += label1_EventoSeparacion;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(etiquetaAviso1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelTextBox label1;
        private EtiquetaAviso etiquetaAviso1;
        private Button button1;
        private Button button2;
    }
}
