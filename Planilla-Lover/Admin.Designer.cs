namespace PLANILLA_LOVERS
{
    partial class Admin
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
            txtNombre = new TextBox();
            txtHoras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtCargo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTarifa = new TextBox();
            label7 = new Label();
            txtHExtra = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(646, 133);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(250, 27);
            txtHoras.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(257, 49);
            label1.Name = "label1";
            label1.Size = new Size(432, 31);
            label1.TabIndex = 7;
            label1.Text = "INGRESAR PLANILLA DE TRABAJADOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 140);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 203);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 11;
            label4.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(149, 199);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(250, 27);
            txtCargo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(510, 137);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 12;
            label5.Text = "Horas Laborales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(510, 203);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 14;
            label6.Text = "Precio x Hora";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(646, 199);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(250, 27);
            txtTarifa.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(510, 269);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 16;
            label7.Text = "Horas Extra.";
            // 
            // txtHExtra
            // 
            txtHExtra.Location = new Point(646, 265);
            txtHExtra.Name = "txtHExtra";
            txtHExtra.Size = new Size(250, 27);
            txtHExtra.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(528, 372);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.OldLace;
            button2.Location = new Point(332, 372);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(946, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtHExtra);
            Controls.Add(label6);
            Controls.Add(txtTarifa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCargo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoras);
            Controls.Add(txtNombre);
            ForeColor = Color.Black;
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtHoras;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtCargo;
        private Label label5;
        private Label label6;
        private TextBox txtTarifa;
        private Label label7;
        private TextBox txtHExtra;
        private Button button1;
        private Button button2;
    }
}