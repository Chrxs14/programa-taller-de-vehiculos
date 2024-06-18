using POE_proyecto.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_proyecto.Vista
{
    public partial class FormReporte : Form
    {
        private CtlPrincipal CtlPrincipal;
        public FormReporte(CtlPrincipal ctlPrincipal)
        {
            CtlPrincipal = ctlPrincipal;
            InitializeComponent();
        }
    }
}
