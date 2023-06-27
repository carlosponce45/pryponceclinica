using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryponceclinica
{
    public partial class Frmmedico : Form
    {
        public Frmmedico()
        {
            InitializeComponent();
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            medico objMedico = new medico();
            objMedico.Grabar(txtMatricula, txtNombreM, cmbEspecialidadM, cmbEspecialidadC);
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }

        private void Frmmedico_Load(object sender, EventArgs e)
        {
            especialidad objEspecialidad = new especialidad();
            objEspecialidad.CargarEspecialidades(cmbEspecialidadM, cmbEspecialidadC);
            medico objMedico = new medico();
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }

        private void cmbEspecialidadC_SelectedIndexChanged(object sender, EventArgs e)
        {
            medico objMedico = new medico();
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }
    }
}
