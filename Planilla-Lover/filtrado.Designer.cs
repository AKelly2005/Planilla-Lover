namespace Planilla_Lover
{
    partial class filtrado
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
            listView1 = new ListView();
            button1 = new Button();
            label2 = new Label();
            listView2 = new ListView();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleados con IR mayor que 0 ";
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ControlLight;
            listView1.Location = new Point(29, 37);
            listView1.Name = "listView1";
            listView1.Size = new Size(262, 97);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(164, 156);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Mostrar IR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 9);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados con IR igual a 0";
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.ControlLight;
            listView2.Location = new Point(341, 37);
            listView2.Name = "listView2";
            listView2.Size = new Size(275, 97);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(524, 156);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Mostrar IR";
            button2.UseVisualStyleBackColor = true;
            // 
            // filtrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 197);
            Controls.Add(button2);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "filtrado";
            Text = "filtrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
        private Label label2;
        private ListView listView2;
        private Button button2;
    }
}