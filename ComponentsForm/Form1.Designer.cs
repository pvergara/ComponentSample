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
            label1.Perico += label1_Perico_1;
            label1.KeyPress += label1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelTextBox label1;
    }
}
