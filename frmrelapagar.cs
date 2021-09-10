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
    public partial class frmrelapagar : Form
    {
        public frmrelapagar()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            imprelpagar frm = new imprelpagar();
            frm.ShowDialog();
        }
    }
}
