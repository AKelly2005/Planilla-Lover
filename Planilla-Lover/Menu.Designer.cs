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
            btIr1 = new Button();
            label3 = new Label();
            label4 = new Label();
            btnIr2 = new Button();
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
            label2.Location = new Point(93, 66);
            label2.Name = "label2";
            label2.Size = new Size(465, 28);
            label2.TabIndex = 3;
            label2.Text = "Empresa: Manufactura xxxx      Fecha:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(555, 66);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(28, 28);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "  ";
            // 
            // btIr1
            // 
            btIr1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btIr1.Location = new Point(353, 317);
            btIr1.Name = "btIr1";
            btIr1.Size = new Size(94, 42);
            btIr1.TabIndex = 5;
            btIr1.Text = "Ir";
            btIr1.UseVisualStyleBackColor = true;
            btIr1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(300, 288);
            label3.Name = "label3";
            label3.Size = new Size(200, 26);
            label3.TabIndex = 6;
            label3.Text = "Ingresar Planilla";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(328, 152);
            label4.Name = "label4";
            label4.Size = new Size(145, 26);
            label4.TabIndex = 8;
            label4.Text = "Ver nomina";
            label4.Visible = false;
            // 
            // btnIr2
            // 
            btnIr2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIr2.Location = new Point(353, 181);
            btnIr2.Name = "btnIr2";
            btnIr2.Size = new Size(94, 41);
            btnIr2.TabIndex = 7;
            btnIr2.Text = "Ir";
            btnIr2.UseVisualStyleBackColor = true;
            btnIr2.Visible = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnIr2);
            Controls.Add(label3);
            Controls.Add(btIr1);
            Controls.Add(lblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private Button btIr1;
        private Label label3;
        private Label label4;
        private Button btnIr2;
    }
}