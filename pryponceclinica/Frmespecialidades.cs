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
    public partial class especialidades : Form
    {
        public especialidades()
        {
            InitializeComponent();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            especialidad objEspecialidad = new especialidad();
            objEspecialidad.Grabar(txtNumeroE.Text, txtNombreE.Text);
        }
    }
}
