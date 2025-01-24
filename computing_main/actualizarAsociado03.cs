
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
// Agregar...
using computing_negocio;
using computing_identidad_Ne;
using computing_data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace computing_main
{
    public partial class actualizarAsociado03 : Form
    {

        private byte[] imageBytes = null;
        // Instancias...
        AsociadoE objAsociadoE = new AsociadoE();
        AsociadoN objAsociadoN = new AsociadoN();
        UbigeoE objUbigeoE = new UbigeoE();

        public DateTime fecRegistro { get; set; }
        public String usuRegistro { get; set; }

        public actualizarAsociado03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }
        private void ActualizarAsociado03_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique

                // Cargamos los combos...

                DataTable dt = objUbigeoE.ListarUbigeo();
                AsociadoN objAsociado = objAsociadoE.ConsultarAsociado(this.Codigo);

                DataRow dr;
                dr = dt.NewRow();
                dr["idUbigeo"] = objAsociado.IdUbigeo;

                dr["ubigeo"] = objAsociado.Ubigeo;
                dt.Rows.InsertAt(dr, 0);

                ubigeo.DataSource = dt;

                ubigeo.ValueMember = "idUbigeo";

                ubigeo.DisplayMember = "ubigeo";



                codigo.Text = objAsociado.IdAsociado;
                paterno.Text = objAsociado.ApePaterno;
                materno.Text = objAsociado.ApeMaterno;
                nombre.Text = objAsociado.Nombre;
                direccion.Text = objAsociado.Direccion;

                dni.Text = objAsociado.Dni;
                domicilio.Text = objAsociado.TelDomicilio;
                celular.Text = objAsociado.TelCelular;
                correo.Text = objAsociado.Mail;
                //  imagen.Text = objAsociado.Foto;

                usuRegistro = objAsociado.UsuRegistro;
                fecRegistro = objAsociado.FecRegistro;
                
                if (objAsociado.Foto != null)
                {
                    //  MessageBox.Show("soy null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    using (MemoryStream ms = new MemoryStream(objAsociado.Foto))
                    {
                        imagen.Image = Image.FromStream(ms);
                       imageBytes = objAsociado.Foto;
                    }

                }
                ingreso.Text = objAsociado.FecIngreso.ToString();
                capacitacion.Text = objAsociado.FecUltimaCapac.ToString();



                if (objAsociado.Estado == 0)
                {
                    activo.Checked = true;
                }
                else
                {
                    activo.Checked = false;
                }



                // MessageBox.Show(paterno.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

               
                if (paterno.Text.Trim() == "" || materno.Text.Trim() == ""
                   || nombre.Text.Trim() == "" || correo.Text.Trim() == "")
                {
                    // MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("Los campos son obligatorios *");
                }

                if (string.IsNullOrWhiteSpace(direccion.Text.Trim()))
                    throw new Exception("Ingrese una dirreción valida");


                if (dni.Text.Trim().Length < 8)
                    throw new Exception("Ingrese un Dni valido");

                if (ubigeo.SelectedValue.ToString() == "0")
                    throw new Exception("Seleccion un Ubigeo valido");

                if (celular.Text.Trim().Length <= 8)
                    throw new Exception("Ingrese un numero valido");

                objAsociadoN.IdAsociado = this.Codigo;
                objAsociadoN.ApePaterno = paterno.Text.Trim();
                objAsociadoN.ApeMaterno = materno.Text.Trim();
                objAsociadoN.Nombre = nombre.Text.Trim();
                objAsociadoN.Direccion = direccion.Text.Trim();
                objAsociadoN.Dni = dni.Text.Trim();
                objAsociadoN.FecIngreso = ingreso.Value;

                objAsociadoN.TelDomicilio = domicilio.Text.Trim();

                objAsociadoN.TelCelular = celular.Text.Trim();
                objAsociadoN.Mail = correo.Text.Trim();
                objAsociadoN.FecUltimaCapac = capacitacion.Value;
               
                objAsociadoN.Foto = imageBytes;
               // objAsociadoN.Foto = null;

                if (activo.Checked)
                {
                    objAsociadoN.Estado = 0;
                }
                else
                {
                    objAsociadoN.Estado = 1;
                }
                objAsociadoN.UsuRegistro = this.usuRegistro;
                objAsociadoN.FecRegistro = this.fecRegistro;
                objAsociadoN.UsuUlt_Mod = clsCredenciales.Usuario ;
                objAsociadoN.FecUlt_Mod = DateTime.Now;

                objAsociadoN.IdUbigeo = ubigeo.SelectedValue.ToString();


                ;
                if (objAsociadoE.ActualizarAsociado(objAsociadoN))
                {
                    this.Close();
                }
                // MessageBox.Show(ubigeo.SelectedValue.ToString(), "fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                imagen.Image = Image.FromFile(imagePath);

                imageBytes = File.ReadAllBytes(imagePath);
                
                /* using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                 {

                     using (BinaryReader br = new BinaryReader(fs))
                     {
                         imageBytes = br.ReadBytes((int)fs.Length);
                     }
                 }*/

            }
        }

        private void dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Indica que se ha manejado el evento, evitando que se ingrese el carácter
                e.Handled = true;
            }
        }

        private void dni_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(dni.Text, out _))
            {


                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Cancel = true;

            }
        }

        private void domicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignorar la tecla presionada
                e.Handled = true;
            }
        }
    }
}
