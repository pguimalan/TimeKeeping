using HRIS.App.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.App
{
    public partial class frmAddress_AE : Form
    {
        public bool ADD_STATE;
        public string strSearch { get; set; }
        public frmAddress_AE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSearch = "";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
            else if (Validation.IsTextEmpty(txtZipCode))
            {
                Validation.FocusTextBox(txtCountry, "Zip Code");
            }
            else
            {
                //if (ADD_STATE == true)
                //{
                //    result = service.AddressInsert(new Address
                //    {
                //        Barangay = txtBarangay.Text,
                //        Municipal_City = txtCity.Text,
                //        Country = txtCountry.Text,
                //        ZipCode = txtZipCode.Text
                //    });
                //    if (result > 1)
                //    {
                //        ShowMessage.ShowMessageBox(1);
                //    }
                //    else
                //        ShowMessage.ShowMessageBox(3);
                //}
                //else
                //{
                //    result = service.AddressUpdate(new Address
                //    {
                //        AddressId = addressId,
                //        Barangay = txtBarangay.Text,
                //        Municipal_City = txtCity.Text,
                //        Country = txtCountry.Text,
                //        ZipCode = txtZipCode.Text
                //    });

                //    if (result > 1)
                //        ShowMessage.ShowMessageBox(1);
                //    else
                //        ShowMessage.ShowMessageBox(3);
                //}

                this.Close();
            }
        }
    }
}
