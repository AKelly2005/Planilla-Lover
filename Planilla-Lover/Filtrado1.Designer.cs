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
            btnMostrarEmpleado2 = new Button();
            btmMostrarEmpleado1 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(31, 89);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1041, 128);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(470, 315);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 11;
            label2.Text = "Empleado sin IR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(470, 12);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 10;
            label1.Text = "Empleado con IR ";
            // 
            // listView2
            // 
            listView2.Location = new Point(31, 369);
            listView2.Name = "listView2";
            listView2.Size = new Size(1041, 147);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrarEmpleado2
            // 
            btnMostrarEmpleado2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarEmpleado2.Location = new Point(857, 557);
            btnMostrarEmpleado2.Name = "btnMostrarEmpleado2";
            btnMostrarEmpleado2.Size = new Size(215, 45);
            btnMostrarEmpleado2.TabIndex = 8;
            btnMostrarEmpleado2.Text = "Mostrar Empleado";
            btnMostrarEmpleado2.UseVisualStyleBackColor = true;
            btnMostrarEmpleado2.Click += btnMostrarEmpleado2_Click;
            // 
            // btmMostrarEmpleado1
            // 
            btmMostrarEmpleado1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btmMostrarEmpleado1.Location = new Point(857, 248);
            btmMostrarEmpleado1.Name = "btmMostrarEmpleado1";
            btmMostrarEmpleado1.Size = new Size(215, 45);
            btmMostrarEmpleado1.TabIndex = 7;
            btmMostrarEmpleado1.Text = "Mostrar Empleado";
            btmMostrarEmpleado1.UseVisualStyleBackColor = true;
            btmMostrarEmpleado1.Click += btmMostrarEmpleado1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(46, 582);
            button1.Name = "button1";
            button1.Size = new Size(113, 35);
            button1.TabIndex = 13;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Filtrado1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 648);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(btnMostrarEmpleado2);
            Controls.Add(btmMostrarEmpleado1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnMostrarEmpleado2;
        private Button btmMostrarEmpleado1;
        private Button button1;
    }
}