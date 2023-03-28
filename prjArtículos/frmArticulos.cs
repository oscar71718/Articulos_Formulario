using System;
using System.Windows.Forms;

namespace prjArtículos
{
    public partial class frmArticulos : Form
    {
        #region "atributos"

        clsTipo4 objT4;
        clsTipo7 objT7;
        clsTipo16 objT16;

        #endregion

        #region "constructor"

        public frmArticulos()
        {
            InitializeComponent();
            llenarComboTipo();
            this.objT4 = new clsTipo4();
            this.objT7 = new clsTipo7();
            this.objT16 = new clsTipo16();
            this.grbPrecio.Visible = false;
        }

        #endregion

        #region "metodos privados"

        private void llenarComboTipo()
        {
            this.cboTipo.Items.Add("Seleccione");
            this.cboTipo.Items.Add("Tipo 4  (ADATA)");
            this.cboTipo.Items.Add("Tipo 7  (KINGSTON)");
            this.cboTipo.Items.Add("Tipo 16 (CRUCIAL)");
            this.cboTipo.SelectedIndex = 0;
        }

        private void llenarComboNombre()
        {
            Limpiar("COMBONOMBRE");
            if (this.cboTipo.SelectedIndex == 0)
            {
                this.cboNombre.Items.Add("");
                this.cboNombre.SelectedIndex = 0;
                this.grbPrecio.Visible = false;
            }
            if (this.cboTipo.SelectedIndex == 1)
            {
                this.cboNombre.Items.Add("Seleccione");
                this.cboNombre.Items.Add("ADATA PCIe");
                this.cboNombre.Items.Add("ADATA M2");
                this.cboNombre.SelectedIndex = 0;
                this.grbPrecio.Visible = false;
            }
            if (this.cboTipo.SelectedIndex == 2)
            {
                this.cboNombre.Items.Add("Seleccione");
                this.cboNombre.Items.Add("KINGSTON PCIe");
                this.cboNombre.Items.Add("KINGSTON M2");
                this.cboNombre.SelectedIndex = 0;
                this.grbPrecio.Visible = false;
            }
            if (this.cboTipo.SelectedIndex == 3)
            {
                this.cboNombre.Items.Add("Seleccione");
                this.cboNombre.Items.Add("CRUCIAL PCIe");
                this.cboNombre.Items.Add("CRUCIAL M2");
                this.cboNombre.SelectedIndex = 0;
                this.grbPrecio.Visible = false;
            }

        }

        private bool Validar()
        {
            if(this.cboTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de artículo.", "Recuerde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.cboNombre.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar el nombre del artículo.", "Recuerde", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void EnviarDatos()
        {
            if(this.cboTipo.SelectedIndex == 1)
            {
                objT4.Tipo = 4;
                objT4.Nombre = cboNombre.Text;
            }
            else if (this.cboTipo.SelectedIndex == 2)
            {
                objT7.Tipo = 7;
                objT7.Nombre = cboNombre.Text;
            }
            if (this.cboTipo.SelectedIndex == 3)
            {
                objT16.Tipo = 16;
                objT16.Nombre = cboNombre.Text;
            }
        }

        private void Procesa()
        {
            if (this.cboTipo.SelectedIndex == 1)
            {
                objT4.Calcular();
            }
            else if (this.cboTipo.SelectedIndex == 2)
            {
                objT7.Calcular();
            }
            else if(this.cboTipo.SelectedIndex == 3)
            {
                objT16.Calcular();
            }
        }

        private void ImprimirDatos()
        {
            if (this.cboTipo.SelectedIndex == 1)
            {
                this.Precio.Text = objT4.Precio.ToString();
                this.Iva.Text = objT4.ParteIVA.ToString();
                this.Total.Text = objT4.Total.ToString();
                this.grbPrecio.Visible = true;
            }
            else if (this.cboTipo.SelectedIndex == 2)
            {
                this.Precio.Text = objT7.Precio.ToString();
                this.Iva.Text = objT7.ParteIVA.ToString();
                this.Total.Text = objT7.Total.ToString();
                this.grbPrecio.Visible = true;
            }
            else if (this.cboTipo.SelectedIndex == 3)
            {
                this.Precio.Text = objT16.Precio.ToString();
                this.Iva.Text = objT16.ParteIVA.ToString();
                this.Total.Text = objT16.Total.ToString();
                this.grbPrecio.Visible = true;
            }
        }

        private void Procesar()
        {
            if (!Validar())
            {
                return;
            }

            EnviarDatos();

            Procesa();

            ImprimirDatos();
        }

        private void Limpiar(string lmp)
        {
            if (lmp == "TODO")
            {
                this.cboNombre.Items.Add("");
                this.cboTipo.SelectedIndex = 0;
                this.Precio.Text = string.Empty;
                this.Iva.Text = string.Empty;
                this.Total.Text = string.Empty;
                this.grbPrecio.Visible = false;
            }
            if (lmp == "COMBONOMBRE")
            {
                this.cboNombre.Items.Clear();
            }
        }

        #endregion

        #region "eventos"

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar("TODO");
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboNombre();
        }

        #endregion
    }
}