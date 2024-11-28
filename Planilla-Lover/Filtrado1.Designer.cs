namespace Planilla_Lover
{
    partial class Filtrado1
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
            listView1 = new ListView();
            label2 = new Label();
            label1 = new Label();
            listView2 = new ListView();
            btnMostrarEmpleado = new Button();
            btmMostrarEmpleado = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(27, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(911, 97);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(411, 236);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 11;
            label2.Text = "Empleado sin IR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(411, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 10;
            label1.Text = "Empleado con IR ";
            // 
            // listView2
            // 
            listView2.Location = new Point(27, 277);
            listView2.Margin = new Padding(3, 2, 3, 2);
            listView2.Name = "listView2";
            listView2.Size = new Size(911, 111);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrarEmpleado
            // 
            btnMostrarEmpleado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnMostrarEmpleado.Location = new Point(750, 418);
            btnMostrarEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnMostrarEmpleado.Name = "btnMostrarEmpleado";
            btnMostrarEmpleado.Size = new Size(188, 34);
            btnMostrarEmpleado.TabIndex = 8;
            btnMostrarEmpleado.Text = "Mostrar Empleado";
            btnMostrarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btmMostrarEmpleado
            // 
            btmMostrarEmpleado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btmMostrarEmpleado.Location = new Point(750, 186);
            btmMostrarEmpleado.Margin = new Padding(3, 2, 3, 2);
            btmMostrarEmpleado.Name = "btmMostrarEmpleado";
            btmMostrarEmpleado.Size = new Size(188, 34);
            btmMostrarEmpleado.TabIndex = 7;
            btmMostrarEmpleado.Text = "Mostrar Empleado";
            btmMostrarEmpleado.UseVisualStyleBackColor = true;
            // 
            // Filtrado1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 486);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(btnMostrarEmpleado);
            Controls.Add(btmMostrarEmpleado);
            Name = "Filtrado1";
            Text = "Filtrado1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label2;
        private Label label1;
        private ListView listView2;
        private Button btnMostrarEmpleado;
        private Button btmMostrarEmpleado;
    }
}