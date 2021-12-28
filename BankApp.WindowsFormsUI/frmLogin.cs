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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            _loginService = new LoginManager(new EfLoginDal());
            _customerService = new CustomerManager(new EfCustomerDal());

        }

        private ILoginService _loginService;
        private ICustomerService _customerService;
        frmRegister _frmRegister = new frmRegister();
        frmCustomerPanel _frmCustomerPanel = new frmCustomerPanel();

        private void lblLoginRegister_Click(object sender, EventArgs e)
        {
            _frmRegister.Show();
            this.Hide();
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
          string tcNo = tbxLoginTcNo.Text;
           string password = tbxLoginPassword.Text;
           var controlTcNo = _loginService.CheckLoginTcNo(tcNo);
           var control = _loginService.CheckLoginDetails(tcNo,password);

            if (controlTcNo.Count>0 && control.Count>0)
            {
                var liste = _customerService.GetCustomerWithOthersByCustomerTcNo(tcNo);
                Customer customer = liste.FirstOrDefault();
                StaticCustomer.GlobalCustomer = customer;
                MessageBox.Show("Kullanıcı Girişi Başarılı");
                this.Hide();
               _frmCustomerPanel.Show();
            }
            else if(controlTcNo.Count==0)
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }
            else
            {
                MessageBox.Show("Şifre Yanlış!");
            }      
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbxLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
