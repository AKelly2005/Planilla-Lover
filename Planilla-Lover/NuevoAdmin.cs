using Planilla_Lover;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA_LOVERS
{
    public partial class NuevoAdmin : Form
    {
        private GestorUsuarios gestorUsuarios;
        public NuevoAdmin()
        {
            InitializeComponent();
            gestorUsuarios = new GestorUsuarios();
        }

        private TextBox txtReptir;
        private Label label4;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Button Agregarbtn;
        private Label label3;
        private Label label2;
        private Label label1;

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(NuevoAdmin));
            txtReptir = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            Agregarbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtReptir
            // 
            txtReptir.Location = new Point(425, 312);
            txtReptir.Multiline = true;
            txtReptir.Name = "txtReptir";
            txtReptir.Size = new Size(260, 27);
            txtReptir.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(259, 303);
            label4.Name = "label4";
            label4.Size = new Size(141, 44);
            label4.TabIndex = 21;
            label4.Text = "REPETIR \r\nCONTRASEÑA";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(425, 248);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(260, 27);
            txtContraseña.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(425, 188);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 19;
            // 
            // Agregarbtn
            // 
            Agregarbtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Agregarbtn.Location = new Point(384, 399);
            Agregarbtn.Name = "Agregarbtn";
            Agregarbtn.Size = new Size(187, 29);
            Agregarbtn.TabIndex = 18;
            Agregarbtn.Text = "AGREGAR";
            Agregarbtn.UseVisualStyleBackColor = true;
            Agregarbtn.Click += Agregarbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(259, 253);
            label3.Name = "label3";
            label3.Size = new Size(141, 22);
            label3.TabIndex = 17;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(259, 190);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 16;
            label2.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(200, 74);
            label1.Name = "label1";
            label1.Size = new Size(544, 45);
            label1.TabIndex = 15;
            label1.Text = "NUEVO ADMINISTRADOR";
            // 
            // NuevoAdmin
            // 
            ClientSize = new Size(944, 503);
            Controls.Add(txtReptir);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(Agregarbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoAdmin";
            Text = "Nuevo Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string tipoUsuario;
            string repetirContraseña = txtReptir.Text;

            Usuario nuevoUsuario = new Administrador(nombre, contraseña);
           

            // Agregar usuario al gestor
            if (repetirContraseña == contraseña) 
            {
                gestorUsuarios.AgregarUsuario(nuevoUsuario);


                // Crear una instancia del segundo formulario
                InicioSesion GoInicio = new InicioSesion();

                // Mostrar el segundo formulario
                GoInicio.Show();

                // Ocultar el formulario actual (Form1)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden");
            }
            

        }
    }
}
