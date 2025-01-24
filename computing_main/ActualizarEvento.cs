﻿
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
using OfEvento_data;

namespace computing_main
{
    public partial class ActualizarEvento : Form
    {

        public String codeEvento {  get; set; }
        public DateTime fecRegistro {  get; set; }
        public String usuRegistro {  get; set; }

        // Instancias...
        EventoE objEventoE = new EventoE();
        EventoN objEventoN = new EventoN();


        public ActualizarEvento()
        {
            InitializeComponent();
        }

        private void ActualizarEvento_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique


                // Cargamos los combos...

               EventoN eventoE=  objEventoE.ConsultarEvento(this.codeEvento);

                evento.Text = eventoE.Evento;

                UbigeoE ubigeoE = new UbigeoE();
                DataTable dt = ubigeoE.ListarUbigeo();

                DataRow dr;


                dr = dt.NewRow();
                dr["idUbigeo"] = eventoE.IdUbigeo;
                dr["ubigeo"] = eventoE.Ubigeo;
                dt.Rows.InsertAt(dr, 0);
                ubigeo.DataSource = dt;
                ubigeo.ValueMember = "idUbigeo";
                ubigeo.DisplayMember = "ubigeo";

                //TURNO
                List<ComboBoxItem> items = new List<ComboBoxItem>
                {
                   // new ComboBoxItem(eventoE.nameTurno, (eventoE.Turno =="M" ? 1 : eventoE.Turno =="T" ? 2 : 3) ),
                    new ComboBoxItem("Mañana", 0),
                    new ComboBoxItem("Tarde", 1),
                    new ComboBoxItem("Noche", 2)
                };

                turno.DataSource = items;
                turno.DisplayMember = "Display";
                turno.ValueMember = "Value";

                if(eventoE.Turno=="M")
                turno.SelectedIndex = 0;
                if (eventoE.Turno == "T")
                    turno.SelectedIndex = 1; 
                if (eventoE.Turno == "N")
                    turno.SelectedIndex = 2;
                //FRECUENCIA
                List<ComboBoxItem> itemsF = new List<ComboBoxItem>
                {
                    new ComboBoxItem(eventoE.nameFrecuencia, Convert.ToInt16(eventoE.Frecuencia)),
                    new ComboBoxItem("Lunes, Miércoles y Viernes ", 1),
                    new ComboBoxItem("Martes, Jueves y Sábado", 2),
                };

                frecuencia.DataSource = itemsF;
                frecuencia.DisplayMember = "Display";
                frecuencia.ValueMember = "Value";
                // EMPRESA
                EmpresaE empresaE = new EmpresaE();
                DataTable dte = empresaE.ListarEmpresa();

                DataRow dre;

                dre = dte.NewRow();
                dre["idEmpresa"] = eventoE.IdEmpresa;
                dre["razonSocial"] = eventoE.RazonSocial;
                dte.Rows.InsertAt(dre, 0);
                empresa.DataSource = dte;
                empresa.ValueMember = "idEmpresa";
                empresa.DisplayMember = "razonSocial";

                //EXPOSITOR
                ExpositorE expositorE = new ExpositorE();
                DataTable dtex = expositorE.ListarExpositor();

                DataRow drex;

                dtex.Columns.Add("nombreCompleto", typeof(string));
                foreach (DataRow row in dtex.Rows)
                {
                    row["nombreCompleto"] = $"{row["nombre"]} {row["apePaterno"]} {row["apeMaterno"]}";
                }

                drex = dtex.NewRow();
                drex["idExpositor"] = eventoE.IdExpositor;
                drex["nombreCompleto"] = eventoE.Expositor;
                dtex.Rows.InsertAt(drex, 0);
                expositor.DataSource = dtex;
                expositor.ValueMember = "idExpositor";
                expositor.DisplayMember = "nombreCompleto";

                //CURSO

                CursoE cursoE = new CursoE();
                DataTable dtec = cursoE.ListarCurso();

                DataRow drec;

                drec = dtec.NewRow();
                drec["idcurso"] = eventoE.IdCurso;
                drec["curso"] =eventoE.Curso;
                dtec.Rows.InsertAt(drec, 0);
                curso.DataSource = dtec;
                curso.ValueMember = "idcurso";
                curso.DisplayMember = "curso";

                codigo.Text = eventoE.IdEvento.ToString();
                cupos.Text = eventoE.CuposProg.ToString();
                presupuesto.Text = eventoE.Presupuesto.ToString();
                local.Text = eventoE.DirecLocal.ToString();
                inicio.Text = eventoE.FecInicio.ToString();
                fin.Text = eventoE.FecFin.ToString();
                this.fecRegistro = eventoE.FecRegistro;
                this.usuRegistro = eventoE.UsuRegistro;

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




                if (evento.Text.Trim() == "" || local.Text.Trim() == ""
                    || presupuesto.Text.ToString() == "" || cupos.Text.ToString() == ""
                     )
                {
                    throw new Exception("Complete los Campos *");
                }

                objEventoN.IdEvento = this.codeEvento;
                objEventoN.Evento = evento.Text.Trim();
                objEventoN.FecInicio = inicio.Value;
                objEventoN.FecFin = fin.Value;
                objEventoN.Frecuencia = Convert.ToInt16(frecuencia.SelectedValue);

                if (curso.SelectedValue.ToString() == "0" || expositor.SelectedValue.ToString() == "0"
                    || empresa.SelectedValue.ToString() == "0" || ubigeo.SelectedValue.ToString() == "0")
                {
                    throw new Exception("Seleccione la Lista");
                }

                if (Convert.ToInt16(turno.SelectedValue) == 0)
                    objEventoN.Turno = "M";
                else if (Convert.ToInt16(turno.SelectedValue) == 1)
                    objEventoN.Turno = "T";
                if (Convert.ToInt16(turno.SelectedValue) == 2)
                    objEventoN.Turno = "N";

                objEventoN.Presupuesto = Convert.ToSingle(presupuesto.Text.Trim());
                objEventoN.DirecLocal = local.Text.Trim();
                objEventoN.CuposProg = Convert.ToInt16(cupos.Text.Trim());

                objEventoN.UsuRegistro = this.usuRegistro;
                objEventoN.FecRegistro = this.fecRegistro;
                objEventoN.UsuUlt_Mod = clsCredenciales.Usuario;
                 objEventoN.FecUlt_Mod = DateTime.Now;
                objEventoN.IdCurso = Convert.ToInt16(curso.SelectedValue);
                objEventoN.IdExpositor = expositor.SelectedValue.ToString();
                objEventoN.IdEmpresa = Convert.ToInt16(empresa.SelectedValue);
                objEventoN.IdUbigeo = ubigeo.SelectedValue.ToString();


                if (objEventoE.ActualizarEvento(objEventoN))
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

        private void presupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void cupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignorar la tecla presionada
                e.Handled = true;
            }
        }
    }
}
