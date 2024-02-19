using Org.Ecos.Logic.Components.LabelTextBox;

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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Margin = new Padding(4, 3, 4, 3);
            label1.Name = "label1";
            label1.Posicion = LabelTextBox.EPosicion.DERECHA;
            label1.PswChr = '\0';
            label1.Separacion = 0U;
            label1.Size = new Size(238, 23);
            label1.TabIndex = 0;
            label1.TextLbl = "label1";
            label1.TextTxt = "";
            label1.TxtChanged += label1_TextChanged;
            label1.EventSeparacion += label1_EventoSeparacion;
            label1.KeyUp += Label1_KeyUp;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 355);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label1_KeyUp(object sender, KeyEventArgs e)
        {
            this.label1.TextLbl = "Look, you keyup'd";
        }

        #endregion

        private LabelTextBox label1;
        private Button button1;
        private Button button2;
    }
}
