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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EfCustomerDal());
            _loginService = new LoginManager(new EfLoginDal());
            _csAdressService = new CsAdressManager(new EfCsAdressDal());
        }

        private ICustomerService _customerService;
        private ILoginService _loginService;
        private ICsAdressService _csAdressService;
        

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            frmLogin _frmLogin = new frmLogin();


            CsAdress cs = new CsAdress
            {
                Country = tbxRegisterCountry.Text,
                City = tbxRegisterCity.Text,
                Street = rtbxRegisterStreet.Text
            };

            List<CsAccount> accountList = new List<CsAccount>();

            CsAccount csAccount = new CsAccount
            {
                AccountState = true,
                Balance = 0,
                AdditionalNumber = 1001,
                CreateTime = System.DateTime.Now
            };

            Login login = new Login
            {
                TcNo = tbxRegisterTcNo.Text,
                Password = tbxRegisterPassword.Text
            };

            accountList.Add(csAccount);

            Customer customer = new Customer
            {
                TcNo = tbxRegisterTcNo.Text,
                Name = tbxRegisterName.Text,
                LastName = tbxRegisterLastName.Text,
                CreateTime = System.DateTime.Now,
                PhoneNumber = tbxRegisterPhoneNumber.Text,
                CustomerNo = _customerService.GetRandomUniqueCustomerNo(),
                CsAdress = cs,
                CsAccount = accountList,
                Login = login
            };

          var control =  _customerService.GetCustomerByTcNo(tbxRegisterTcNo.Text);

            if (control.Count==0)
            {   
                try
                {
                    _customerService.Add(customer);
                    MessageBox.Show("Kayıt Başarılı");
                    this.Hide();
                    _frmLogin.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kayıt Başarısız");
                }
            }
            else
            {
                MessageBox.Show("Bu Tc Kimlik Numarası ile daha önce kayıt olunmuş");

            }
        }

        private void tbxRegisterPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
