using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Using...
using computing_negocio;
using computing_identidad_Ne;

namespace computing_main
{
    public partial class frmLogin : Form
    {
        // Declaramos variableas de intentos y tiempo....
        Int16 intentos = 0;
        Int16 tiempo = 20;
        // Declaramos instancias para autenficacion de Usuarios....
        UsuarioN objUsuarioN = new UsuarioN();
        UsuarioE objUsuarioE = new UsuarioE();



        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
                {
                    // Codifique...
                    objUsuarioN = objUsuarioE.ConsultarUsuario(txtLogin.Text.Trim(), txtPassword.Text.Trim());
                  
                    if (objUsuarioN.Login_Usuario == null)
                    {
                        intentos += 1;
                        ValidaAccesos();
                        throw new Exception("Usuario no existe");
                    }
                    else if (objUsuarioN.Login_Usuario == txtLogin.Text.Trim()
                       && objUsuarioN.Pass_Usuario == txtPassword.Text.Trim())
                    {
                        this.Hide();
                        timer1.Enabled = false;

                        //GUARDAR CREDENCIALES
                        clsCredenciales.Usuario = objUsuarioN.Login_Usuario;
                        clsCredenciales.Password = objUsuarioN.Pass_Usuario;
                        clsCredenciales.Nivel = objUsuarioN.Niv_Usuario;
                        //
                        MDIPrincipal objMDI = new MDIPrincipal();
                        objMDI.ShowDialog();

                    }
                    else
                    {
                        intentos += 1;
                        ValidaAccesos();
                        throw new Exception("Usuario o contraseña incorrecto");
                    }

                }

                else
                {
                    MessageBox.Show("Usuario o Password obligatorios",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();

            }
        }

      
    }
}
