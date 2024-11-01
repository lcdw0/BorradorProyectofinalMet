using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador_1.Formularios
{
    public partial class FrmCustomerAdd : Form
    {
        public FrmCustomerAdd()
        {
            InitializeComponent();
        }

        private void btnCloseFrm_Click(object sender, EventArgs e)
        {
            FrmCustomer frm = new FrmCustomer();
            this.Hide();
            frm.Show();
            


        


        }
    }
}
