using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCR
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void ribbonButton1_Click_1(object sender, EventArgs e)
        {
            frmfornecedores frm = new frmfornecedores();
            frm.ShowDialog();
        }

        private void ribbonButton2_Click_1(object sender, EventArgs e)
        {
            frmpagar frm = new frmpagar();
            frm.ShowDialog();
        }

        private void ribbonButton4_Click_1(object sender, EventArgs e)
        {
            frmrelapagar frm = new frmrelapagar();
            frm.ShowDialog();
        }

        private void ribbonOrbMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
