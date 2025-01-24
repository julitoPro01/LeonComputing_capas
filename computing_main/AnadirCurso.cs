
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar...
using computing_negocio;
using computing_identidad_Ne;
using computing_data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Computing_main;
using System.Diagnostics;

namespace computing_main
{
    public partial class AnadirCurso : Form
    {

        private byte[] imageBytes;
        // Instancias...
        CursoE objCursoE = new CursoE();
        CursoN objCursoN = new CursoN();


        public AnadirCurso()
        {
            InitializeComponent();
        }

        private void AnadirAsociado02_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique

                // Cargamos los combos...
                complejidad.SelectedIndex=0;
                horaTeoria.SelectedIndex=2;
                horaPractica.SelectedIndex=4;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique

               

                if (curso.Text.Trim() == "" || comentario.Text.Trim() == "")
                {
                    throw new Exception("Complete los Campos *");
                }

                objCursoN.NameCurso = curso.Text.Trim();
                objCursoN.HorasTeoria = horaTeoria.Text.Trim();
                objCursoN.HorasPractica = horaPractica.Text.Trim();
                objCursoN.Comentario = comentario.Text.Trim();

                switch (complejidad.SelectedIndex)
                {
                    case 0: objCursoN.Complejidad = 0; break;
                    case 1: objCursoN.Complejidad = 1; break;
                    case 2: objCursoN.Complejidad = 2; break;
                }
               
                if (activo.Checked)
                    objCursoN.Estado = 1;
                else
                    objCursoN.Estado = 0;

                objCursoN.UsuRegistro = clsCredenciales.Usuario;
                objCursoN.FecRegistro = DateTime.Now;
                objCursoN.UsuUlt_Mod = "";
              //  objCursoN.FecUlt_Mod = (Object)DBNull.Value;


                ;
                if (objCursoE.InsertarCurso(objCursoN))
                {

                    this.Close();

                    // MessageBox.Show("grabajo", "fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
