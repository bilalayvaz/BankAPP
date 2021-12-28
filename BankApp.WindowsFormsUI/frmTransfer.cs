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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp.WindowsFormsUI
{
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EfCustomerDal());
            _csAccountService = new CsAccountManager(new EfCsAccountDal());
        }

        ICustomerService _customerService;
        ICsAccountService _csAccountService;

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            LoadEnabledAccountsData();
        }

        private void LoadEnabledAccountsData()
        {
            lblVirmanSenderBalance.Visible = false;
            lblVirmanSenderAccountNoAdditionalNo.Visible = false;
            lblVirmanReceiverBalance.Visible = false;
            lblVirmanReceiverAccountNoAdditionalNo.Visible = false;

            var account1 = _csAccountService.GetEnabledCustomerAccountsWithCustomerId(StaticCustomer.GlobalCustomer.Id);
            var account2 = _csAccountService.GetEnabledCustomerAccountsWithCustomerId(StaticCustomer.GlobalCustomer.Id);
            var account3 = _csAccountService.GetEnabledCustomerAccountsWithCustomerId(StaticCustomer.GlobalCustomer.Id);

            dgwVirmanSender.DataSource = account1;
            dgwVirmanSender.Columns[0].Visible = false;
            dgwVirmanSender.Columns[1].Visible = false;
            dgwVirmanSender.Columns[4].Visible = false;
            dgwVirmanSender.Columns[2].HeaderText = "Ek Numara";
            dgwVirmanSender.Columns[3].HeaderText = "Bakiye";
            dgwVirmanSender.Columns[5].HeaderText = "Oluşturulma Zamanı";
            dgwVirmanSender.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgwVirmanReceiver.DataSource = account2;
            dgwVirmanReceiver.Columns[0].Visible = false;
            dgwVirmanReceiver.Columns[1].Visible = false;
            dgwVirmanReceiver.Columns[4].Visible = false;
            dgwVirmanReceiver.Columns[2].HeaderText = "Ek Numara";
            dgwVirmanReceiver.Columns[3].HeaderText = "Bakiye";
            dgwVirmanReceiver.Columns[5].HeaderText = "Oluşturulma Zamanı";
            dgwVirmanReceiver.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgwHavaleSender.DataSource = account3;
            dgwHavaleSender.Columns[0].Visible = false;
            dgwHavaleSender.Columns[1].Visible = false;
            dgwHavaleSender.Columns[4].Visible = false;
            dgwHavaleSender.Columns[2].HeaderText = "Ek Numara";
            dgwHavaleSender.Columns[3].HeaderText = "Bakiye";
            dgwHavaleSender.Columns[5].HeaderText = "Oluşturulma Zamanı";
            dgwHavaleSender.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dgwVirmanSender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwVirmanSender.CurrentRow != null)
            {
                lblVirmanSenderBalance.Visible = true;
                lblVirmanSenderAccountNoAdditionalNo.Visible = true;
                lblVirmanSenderBalance.Text = dgwVirmanSender.CurrentRow.Cells[3].Value.ToString();
                lblVirmanSenderAccountNoAdditionalNo.Text = StaticCustomer.GlobalCustomer.CustomerNo.ToString() + " - " + dgwVirmanSender.CurrentRow.Cells[2].Value.ToString();
            }
        }
         
        private void dgwVirmanReceiver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwVirmanReceiver.CurrentRow != null)
            {
                lblVirmanReceiverBalance.Visible = true;
                lblVirmanReceiverAccountNoAdditionalNo.Visible = true;
                lblVirmanReceiverBalance.Text = dgwVirmanReceiver.CurrentRow.Cells[3].Value.ToString();
                lblVirmanReceiverAccountNoAdditionalNo.Text = StaticCustomer.GlobalCustomer.CustomerNo.ToString() + " - " + dgwVirmanReceiver.CurrentRow.Cells[2].Value.ToString();
            }
        }

        Regex _regex = new Regex(@"^\d+$");
        private void btnVirman_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Virman işlemi gerçekleşecek, devam edilsin mi?", "Virman Onay", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgwVirmanSender.CurrentRow != null)
                {
                    if (_regex.IsMatch(tbxVirmanSenderAmount.Text) && Convert.ToInt32(tbxVirmanSenderAmount.Text)>0)
                    {
                        if (Convert.ToInt32(tbxVirmanSenderAmount.Text) <= Convert.ToInt32(dgwVirmanSender.CurrentRow.Cells[3].Value))
                        {
                            if (Convert.ToInt32(dgwVirmanSender.CurrentRow.Cells[0].Value) != Convert.ToInt32(dgwVirmanReceiver.CurrentRow.Cells[0].Value))
                            {
                                if (dgwVirmanReceiver.CurrentRow != null)
                                {
                                    var csAccountOld = _csAccountService.GetCustomerAccountById(Convert.ToInt32(dgwVirmanSender.CurrentRow.Cells[0].Value));
                                    csAccountOld.Balance = csAccountOld.Balance - Convert.ToInt32(tbxVirmanSenderAmount.Text);
                                    var csAccountNew = _csAccountService.GetCustomerAccountById(Convert.ToInt32(dgwVirmanReceiver.CurrentRow.Cells[0].Value));
                                    csAccountNew.Balance = csAccountNew.Balance + Convert.ToInt32(tbxVirmanSenderAmount.Text);

                                    try
                                    {
                                        _csAccountService.Update(csAccountOld);
                                        _csAccountService.Update(csAccountNew);
                                        var liste = _customerService.GetCustomerWithOthersByCustomerId(StaticCustomer.GlobalCustomer.Id);
                                        StaticCustomer.GlobalCustomer = liste.FirstOrDefault();
                                        MessageBox.Show("Transfer Gerçekleşti. " + dgwVirmanSender.CurrentRow.Cells[2].Value +
                                                       " numaralı hesaptan " + dgwVirmanReceiver.CurrentRow.Cells[2].Value +
                                                       " numaralı hesaba para transferi gerçekleşmiştir.");
                                        LoadEnabledAccountsData();

                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Virman İşlemi Başarısız");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Para aktarılacak hesabı seçmediniz");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Aynı hesaplar arasında transfer yapılamaz");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Hesapta yeterli bakiye yoktur");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir sayı giriniz");
                    }
                }
                else
                {
                    MessageBox.Show("Para aktaracak hesabı seçmediniz");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnHavaleSend_Click(object sender, EventArgs e)
        {
            var customerAll = _customerService.GetCustomerByCustomerNo(Convert.ToInt32(tbxHavaleReceiverAccountNo.Text));
            
            DialogResult dialogResult = MessageBox.Show("Havale işlemi gerçekleşecek, devam edilsin mi?", "Havale Onay", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgwHavaleSender.CurrentRow != null)
                {
                    if (customerAll != null)
                    {
                        var customerExistAdditionalNumber = _csAccountService.GetEnableCustomerAccountByAdditionalNumberandCustomerId(customerAll.Id,Convert.ToInt32(tbxHavaleReceiverAdditionalNo.Text));
                        
                        if (customerExistAdditionalNumber != null)
                        {   
                            if (dgwHavaleSender.CurrentRow != null)
                            {
                                if (_regex.IsMatch(tbxHavaleReceiverAmount.Text) && Convert.ToInt32(tbxHavaleReceiverAmount.Text) > 0)
                                {

                                    if (Convert.ToInt32(tbxHavaleReceiverAmount.Text) <= Convert.ToInt32(dgwHavaleSender.CurrentRow.Cells[3].Value))
                                    {
                                        customerExistAdditionalNumber.Balance += Convert.ToInt32(tbxHavaleReceiverAmount.Text);
                                        try
                                        {
                                            _csAccountService.Update(customerExistAdditionalNumber);
                                            var csAccount = _csAccountService.GetCustomerAccountById(Convert.ToInt32(dgwHavaleSender.CurrentRow.Cells[0].Value));
                                            csAccount.Balance -= Convert.ToInt32(tbxHavaleReceiverAmount.Text);
                                            _csAccountService.Update(csAccount);
                                            var liste = _customerService.GetCustomerWithOthersByCustomerId(StaticCustomer.GlobalCustomer.Id);
                                            StaticCustomer.GlobalCustomer = liste.FirstOrDefault();
                                            LoadEnabledAccountsData();
                                            MessageBox.Show("Havale başarılı. Hesaptan para çıkışı gerçekleşmiştir");

                                        }
                                        catch (Exception)
                                        {

                                            MessageBox.Show("Havale Başarısız");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hesapta yeterli bakiye yoktur");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Geçerli bir sayı giriniz");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Para aktaracak hesabı seçmediniz");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Bu hesap numarası ile eşleşen bir ek numara yoktur");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir hesap numarası yoktur");
                    }
                }
                else
                {
                    MessageBox.Show("Para aktaracak hesabı seçmediniz");
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
