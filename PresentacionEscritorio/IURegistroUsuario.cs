using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionEscritorio
{
    public partial class IURegistroUsuario : Form
    {
        public IURegistroUsuario()
        {
            InitializeComponent();
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            IUInicioSesion IUIniciar = new IUInicioSesion();
            IUIniciar.Visible = true;
            this.Close();
        }
    }
}
