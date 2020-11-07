using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoDepreciacion
{
    public partial class frmCalculoDepreciacion : Form
    {
        public frmCalculoDepreciacion()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCantAnios.Clear();
            txtValActivo.Clear();
            txtValResidual.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtCantAnios.Text == string.Empty)
            {
                MessageBox.Show("El campo Cantidad de Años es requerido", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantAnios.Focus();
            }
            else if (txtValActivo.Text == string.Empty)
            {
                MessageBox.Show("El campo Valor del Activo es requerido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValActivo.Focus();
            }
            else if (txtValResidual.Text == string.Empty)
            {
                MessageBox.Show("El campo Valor Residual es requerido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValResidual.Focus();
            }
            else
            {
                double valorDepreciacion;
                double valorActivo = Convert.ToDouble(txtValActivo.Text);
                double valorResidual = Convert.ToDouble(txtValResidual.Text);
                int cantAnios = Convert.ToInt32(txtCantAnios.Text);

                valorDepreciacion = (valorActivo - valorResidual) / cantAnios;
                MessageBox.Show("El valor de depreciacion del activo es: " + valorDepreciacion);
            }
        }
    }
}
