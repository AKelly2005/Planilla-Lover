namespace Planilla_Lover
{
    partial class Acces_Admincs
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
            btnVerificar = new Button();
            button2 = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.Location = new Point(521, 359);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(100, 48);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Acceder";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(153, 359);
            button2.Name = "button2";
            button2.Size = new Size(110, 48);
            button2.TabIndex = 1;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 94);
            label1.Name = "label1";
            label1.Size = new Size(421, 38);
            label1.TabIndex = 2;
            label1.Text = "Ingresa un código para ingresar";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(311, 211);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(179, 27);
            txtCodigo.TabIndex = 3;
            // 
            // Acces_Admincs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnVerificar);
            Name = "Acces_Admincs";
            Text = "Acces_Admincs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private Button button2;
        private Label label1;
        private TextBox txtCodigo;
    }
}