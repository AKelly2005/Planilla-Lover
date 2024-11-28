namespace Planilla_Lover
{
    partial class Menu
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
            label2 = new Label();
            lblFecha = new Label();
            btnIr1 = new Button();
            lblIngresarPlanilla = new Label();
            lblVerPlanilla = new Label();
            btnIr2 = new Button();
            lblUsuarioTipo = new Label();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(540, 57);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Planilla ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 142);
            label2.Name = "label2";
            label2.Size = new Size(465, 28);
            label2.TabIndex = 3;
            label2.Text = "Empresa: Manufactura xxxx      Fecha:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(554, 142);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(28, 28);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "  ";
            // 
            // btnIr1
            // 
            btnIr1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIr1.Location = new Point(540, 317);
            btnIr1.Name = "btnIr1";
            btnIr1.Size = new Size(94, 42);
            btnIr1.TabIndex = 5;
            btnIr1.Text = "Ir";
            btnIr1.UseVisualStyleBackColor = true;
            btnIr1.Visible = false;
            btnIr1.Click += btnIr1_Click;
            // 
            // lblIngresarPlanilla
            // 
            lblIngresarPlanilla.AutoSize = true;
            lblIngresarPlanilla.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresarPlanilla.Location = new Point(487, 266);
            lblIngresarPlanilla.Name = "lblIngresarPlanilla";
            lblIngresarPlanilla.Size = new Size(200, 26);
            lblIngresarPlanilla.TabIndex = 6;
            lblIngresarPlanilla.Text = "Ingresar Planilla";
            lblIngresarPlanilla.Visible = false;
            // 
            // lblVerPlanilla
            // 
            lblVerPlanilla.AutoSize = true;
            lblVerPlanilla.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblVerPlanilla.Location = new Point(147, 266);
            lblVerPlanilla.Name = "lblVerPlanilla";
            lblVerPlanilla.Size = new Size(144, 26);
            lblVerPlanilla.TabIndex = 8;
            lblVerPlanilla.Text = "Ver Planilla";
            lblVerPlanilla.Visible = false;
            // 
            // btnIr2
            // 
            btnIr2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIr2.Location = new Point(180, 318);
            btnIr2.Name = "btnIr2";
            btnIr2.Size = new Size(94, 41);
            btnIr2.TabIndex = 7;
            btnIr2.Text = "Ir";
            btnIr2.UseVisualStyleBackColor = true;
            btnIr2.Visible = false;
            btnIr2.Click += btnIr2_Click;
            // 
            // lblUsuarioTipo
            // 
            lblUsuarioTipo.AutoSize = true;
            lblUsuarioTipo.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioTipo.Location = new Point(130, 85);
            lblUsuarioTipo.Name = "lblUsuarioTipo";
            lblUsuarioTipo.Size = new Size(30, 41);
            lblUsuarioTipo.TabIndex = 9;
            lblUsuarioTipo.Text = " ";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.Location = new Point(12, 399);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(144, 39);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblUsuarioTipo);
            Controls.Add(lblVerPlanilla);
            Controls.Add(btnIr2);
            Controls.Add(lblIngresarPlanilla);
            Controls.Add(btnIr1);
            Controls.Add(lblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Menu";
            RightToLeftLayout = true;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private Button btnIr1;
        private Label lblIngresarPlanilla;
        private Label lblVerPlanilla;
        private Button btnIr2;
        private Label lblUsuarioTipo;
        private Button btnCerrarSesion;
    }
}