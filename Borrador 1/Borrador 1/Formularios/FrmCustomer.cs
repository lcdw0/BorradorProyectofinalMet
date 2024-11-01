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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomerAdd frm = new FrmCustomerAdd();
            frm.Show();
            this.Hide();
        }

        private void btnBackCustomerToMain_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
             
        }
    }
}
