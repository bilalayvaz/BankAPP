using BankApp.Business.Abstract;
using BankApp.Business.Concrete;
using BankApp.DataAccess.Concrete.EntityFramework;
using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankApp.WindowsFormsUI
{
    public partial class frmAccountInfo : Form
    {
        public frmAccountInfo()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EfCustomerDal());
            _csAccountService = new CsAccountManager(new EfCsAccountDal());
        }

       
        ICustomerService _customerService;
        ICsAccountService _csAccountService;

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {
            LoadEnabledAccountsData();
        }

        private void LoadEnabledAccountsData()
        {

            dgwAccount.DataSource = _csAccountService.GetEnabledCustomerAccountsWithCustomerId(StaticCustomer.GlobalCustomer.Id);
            dgwAccount.Columns[0].Visible = false;
            dgwAccount.Columns[1].Visible = false;
            dgwAccount.Columns[4].Visible = false;
            dgwAccount.Columns[2].HeaderText = "Ek Numara";
            dgwAccount.Columns[3].HeaderText = "Bakiye";
            dgwAccount.Columns[5].HeaderText = "Oluşturulma Zamanı";
            dgwAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnAccountInfoNewAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yeni hesap oluşturulacak, devam edilsin mi?", "Yeni Hesap", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Random rnd = new Random();
                
                CsAccount csAccount = new CsAccount
                {
                    CustomerId = StaticCustomer.GlobalCustomer.Id,
                    Balance = rnd.Next(0,500),
                    AccountState = true,
                    CreateTime = DateTime.Now,
                    AdditionalNumber = StaticCustomer.GlobalCustomer.CsAccount.Last().AdditionalNumber + 1
                };

                try
                {
                    _csAccountService.Add(csAccount);
                    StaticCustomer.GlobalCustomer.CsAccount.Add(csAccount);
                    LoadEnabledAccountsData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hesap açılamadı!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnAccountInfoDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgwAccount.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Seçilen hesap silinecek, devam edilsin mi?", "Hesap Silme", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (Convert.ToInt32(dgwAccount.CurrentRow.Cells[3].Value) == 0)
                    {
                        try
                        {
                            var csAccount = _csAccountService.GetCustomerAccountById(Convert.ToInt32(dgwAccount.CurrentRow.Cells[0].Value));
                            csAccount.AccountState = false;
                            _csAccountService.Update(csAccount);
                            StaticCustomer.GlobalCustomer = _customerService.GetCustomerWithOthersByCustomerId(Convert.ToInt32(dgwAccount.CurrentRow.Cells[1].Value)).FirstOrDefault();
                            LoadEnabledAccountsData();                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hesap silinemedi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hesapta bakiye mevcutken hesap silinememez. Önce bakiyenizi mevcut hesaplarınıza aktarın");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir satır seçiniz");
            }
        }
    }
}
