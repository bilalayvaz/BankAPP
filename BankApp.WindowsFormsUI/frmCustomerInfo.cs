using BankApp.Business.Abstract;
using BankApp.Business.Concrete;
using BankApp.DataAccess.Concrete.EntityFramework;
using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp.WindowsFormsUI
{
    public partial class frmCustomerInfo : Form
    {
        public frmCustomerInfo()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EfCustomerDal());
            _csAdressService = new CsAdressManager(new EfCsAdressDal());
        }

        ICustomerService _customerService;
        ICsAdressService _csAdressService;
        
        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            lblCustomerInfoTcNo.Text = StaticCustomer.GlobalCustomer.TcNo;
            lblCustomerInfoAccountNo.Text = StaticCustomer.GlobalCustomer.CustomerNo.ToString();
            tbxCustomerInfoName.Text = StaticCustomer.GlobalCustomer.Name;
            tbxCustomerInfoLastName.Text = StaticCustomer.GlobalCustomer.LastName;
            tbxCustomerInfoPhone.Text = StaticCustomer.GlobalCustomer.PhoneNumber;
            tbxCustomerInfoCity.Text = StaticCustomer.GlobalCustomer.CsAdress.City;
            tbxCustomerInfoCountry.Text = StaticCustomer.GlobalCustomer.CsAdress.Country;
            rtbxCustomerInfoStreet.Text = StaticCustomer.GlobalCustomer.CsAdress.Street;
        }

        private void btnCustomerInfoUpdate_Click(object sender, EventArgs e)
        {
            CsAdress csAdress = new CsAdress
            {
                Id=StaticCustomer.GlobalCustomer.CsAdress.Id,
                City = tbxCustomerInfoCity.Text,
                Country = tbxCustomerInfoCountry.Text,
                Street = rtbxCustomerInfoStreet.Text,
            };

            Customer customer = new Customer
            {
                Id = StaticCustomer.GlobalCustomer.Id,
                TcNo = StaticCustomer.GlobalCustomer.TcNo,
                Name = tbxCustomerInfoName.Text,
                LastName = tbxCustomerInfoLastName.Text,
                PhoneNumber = tbxCustomerInfoPhone.Text,
                CustomerNo = StaticCustomer.GlobalCustomer.CustomerNo,
                CreateTime = StaticCustomer.GlobalCustomer.CreateTime,
                CsAdress = csAdress,
                CsAccount = StaticCustomer.GlobalCustomer.CsAccount.ToList()
            };

            try
            {
                _customerService.UpdateWithCsAdress(customer);
                StaticCustomer.GlobalCustomer = customer;
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Günceleme Başarısız");
            }
            
            
        }
    }
}
