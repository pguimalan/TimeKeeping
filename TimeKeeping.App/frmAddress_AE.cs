using System;
using System.Windows.Forms;
using TimeKeeping.App.Helpers;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmAddress_AE : Form
    {
        public bool ADD_STATE;
        public AddressModel addressForEditModel;
        private readonly IAddressService svc;

        public frmAddress_AE(IAddressService svc)
        {
            this.svc = svc;
        }

        public frmAddress_AE()
            : this(new AddressService())
        {
            InitializeComponent();
        }


        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (Validation.IsTextEmpty(txtBarangay))
            {
                Validation.FocusTextBox(txtBarangay, "Barangay");
            }
            else if (Validation.IsTextEmpty(txtCity))
            {
                Validation.FocusTextBox(txtCity, "City");
            }
            else if (Validation.IsTextEmpty(txtCountry))
            {
                Validation.FocusTextBox(txtCountry, "Country");
            }
            else if (Validation.IsMaskedTextEmpty(txtZipCode))
            {
                Validation.FocusMaskedTextBox(txtZipCode, "Zip Code");
            }
            else
            {
                if (ADD_STATE == true)
                {
                    result = svc.Address_Insert(new AddressModel
                    {
                        Barangay = txtBarangay.Text,
                        Municipal_City = txtCity.Text,
                        Country = txtCountry.Text,
                        Province = txtProvince.Text,
                        ZipCode = txtZipCode.Text
                    });
                    if (result > 0)
                    {
                        ShowMessage.ShowMessageBox(1);
                    }
                    else if (result == -1)
                        ShowMessage.ShowMessageBox(4);
                    else
                        ShowMessage.ShowMessageBox(3);
                }
                else
                {
                    result = svc.Address_Update(new AddressModel
                    {
                        AddressId = addressForEditModel.AddressId,
                        Barangay = txtBarangay.Text,
                        Municipal_City = txtCity.Text,
                        Province = txtProvince.Text,
                        Country = txtCountry.Text,
                        ZipCode = txtZipCode.Text
                    });

                    if (result > 0)
                        ShowMessage.ShowMessageBox(1);
                    else
                        ShowMessage.ShowMessageBox(3);
                }
                this.Close();
            }
        }

        private void txtBarangay_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtBarangay);
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCity);
        }

        private void txtProvince_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtProvince);
        }

        private void txtCountry_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCountry);
        }

        private void frmAddress_AE_Load(object sender, EventArgs e)
        {
            if (this.ADD_STATE == false && this.addressForEditModel != null)
            {
                txtBarangay.Text = addressForEditModel.Barangay;
                txtCity.Text = addressForEditModel.Municipal_City;
                txtProvince.Text = addressForEditModel.Province;
                txtCountry.Text = addressForEditModel.Country;
                txtZipCode.Text = addressForEditModel.ZipCode;
            }
        }
    }
}
