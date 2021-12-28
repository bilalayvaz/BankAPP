using BankApp.Business.Abstract;
using BankApp.Business.Concrete;
using BankApp.DataAccess.Concrete.EntityFramework;
using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp.WindowsFormsUI
{
    public partial class frmCustomerPanel : Form
    {
        public frmCustomerPanel()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EfCustomerDal());
        }

        private ICustomerService _customerService;

        frmAccountInfo _frmAccountInfo = new frmAccountInfo();
        frmCustomerInfo _frmCustomerInfo = new frmCustomerInfo();

        private void btnCustomerPanelAccountInfo_Click(object sender, EventArgs e)
        {
            _frmAccountInfo.ShowDialog();
        }

        private void btnCustomerPanelCustomerInfo_Click(object sender, EventArgs e)
        {
            _frmCustomerInfo.ShowDialog();
        }

        frmTransfer _frmTransfer = new frmTransfer();
        private void btnCustomerPanelVirman_Click(object sender, EventArgs e)
        {
            _frmTransfer.ShowDialog();
        }
    }
}
