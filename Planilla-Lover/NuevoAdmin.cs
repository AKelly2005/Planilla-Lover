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
        public NuevoAdmin(GestorUsuarios gestorUsuarios) // Recibe la instancia existente
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios;  // Usar la instancia pasada
        }

        private TextBox txtReptir;
        private Label label4;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Button Agregarbtn;
        private Label label3;
        private Label label2;
        private Button button1;
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
            button1 = new Button();
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
            Agregarbtn.Location = new Point(682, 399);
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
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(52, 399);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 23;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NuevoAdmin
            // 
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(944, 464);
            Controls.Add(button1);
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
            string repetirContraseña = txtReptir.Text;

            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(repetirContraseña))
            {
                MessageBox.Show("Por favor repita la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las contraseñas coincidan
            if (repetirContraseña != contraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todos los campos son válidos, se procede a agregar el usuario
            Usuario nuevoUsuario = new Administrador(nombre, contraseña);

            try
            {
                // Agregar usuario al gestor
                gestorUsuarios.AgregarUsuario(nuevoUsuario);

                // Enviar al usuario a inicio de sesión
                InicioSesion GoInicio = new InicioSesion(gestorUsuarios);

                // Mostrar inicio de sesión
                GoInicio.Show();

                // Ocultar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion nuevoInicio = new InicioSesion(gestorUsuarios);
            nuevoInicio.Show();
            this.Hide(); // Ocultar el formulario actual
        }
    }
}