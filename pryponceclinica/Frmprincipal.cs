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
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            especialidad frmEspecialidades = new especialidad();
           frmEspecialidades.ShowDialog();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            medico frmMedicos = new medico();
            frmMedicos.ShowDialog();
        }
    }
}
