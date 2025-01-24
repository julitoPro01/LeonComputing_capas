
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

namespace computing_main
{
    public partial class ActualizarCurso : Form
    {

        private byte[] imageBytes;
        // Instancias...
        CursoE objCursoE = new CursoE();
        CursoN objCursoN = new CursoN();

        public DateTime fecRegistro { get; set; }
        public String usuRegistro { get; set; }
        public ActualizarCurso()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }
        private void ActualizarCurso_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique

                // Cargamos los combos...
              //  horaTeoria.SelectedIndex=2;
             //   horaPractica.SelectedIndex=4;

                CursoN objCurso =  objCursoE.ConsultarCurso( this.Codigo );

                codigo.Text = objCurso.IdCurso;
                curso.Text= objCurso.NameCurso;
                horaTeoria.Text = objCurso.HorasTeoria;
                horaPractica.Text = objCurso.HorasPractica;
                complejidad.SelectedIndex=objCurso.Complejidad;
                
                usuRegistro = objCurso.UsuRegistro;
                fecRegistro = objCurso.FecRegistro;

                if (objCurso.Estado == 1)
                    activo.Checked=false;
                else activo.Checked=true;
                
                comentario.Text = objCurso.Comentario;

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

                if ( curso.Text.Trim()=="" || comentario.Text.Trim()=="" )
                {
                    throw new Exception("Complete los Campos *");
                }
                objCursoN.IdCurso = this.Codigo;
                objCursoN.NameCurso = curso.Text.Trim();
                objCursoN.HorasTeoria = horaTeoria.Text.Trim();
                objCursoN.HorasPractica = horaPractica.Text.Trim();
                objCursoN.Comentario = comentario.Text.Trim();

                switch (complejidad.SelectedIndex)
                {
                    case 0: objCursoN.Complejidad=0; break;
                    case 1: objCursoN.Complejidad=1; break;
                    case 2: objCursoN.Complejidad=2; break;
                }

                if (activo.Checked)
                    objCursoN.Estado = 0;
                else
                    objCursoN.Estado = 1;

                objCursoN.UsuRegistro = this.usuRegistro;
                objCursoN.FecRegistro = this.fecRegistro;
                objCursoN.UsuUlt_Mod = clsCredenciales.Usuario;
                objCursoN.FecUlt_Mod = DateTime.Now;


                ;
                if (objCursoE.ActualizarCurso(objCursoN))
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
