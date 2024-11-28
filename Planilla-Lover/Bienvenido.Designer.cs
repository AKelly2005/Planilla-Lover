namespace Planilla_Lover
{
    partial class Bienvenido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pbImagen = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 27);
            label1.Name = "label1";
            label1.Size = new Size(408, 73);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido";
            // 
            // pbImagen
            // 
            pbImagen.Image = Properties.Resources.Logo;
            pbImagen.Location = new Point(288, 115);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(224, 248);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 2;
            pbImagen.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(267, 382);
            button1.Name = "button1";
            button1.Size = new Size(266, 56);
            button1.TabIndex = 3;
            button1.Text = "Continuar a Inicio de Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bienvenido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pbImagen);
            Controls.Add(label1);
            Name = "Bienvenido";
            Text = "Bienvenido";
            Load += Bienvenido_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbImagen;
        private Button button1;
    }
}