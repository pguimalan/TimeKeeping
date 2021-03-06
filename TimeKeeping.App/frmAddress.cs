﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmAddress : Form
    {
        public string strAddressSelected { get; set; }
        public bool IsSelectAddress;

        private readonly IAddressService svc;
        public frmAddress(IAddressService svc)
        {
            this.svc = svc;
        }

        public frmAddress() : this(new AddressService())
        {
            InitializeComponent();
            IsSelectAddress = false;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadvars(string txtSearch)
        {
            try
            {
                List<AddressModel> list = svc.Address_Select(txtSearch);
                listView1.Items.Clear();
                if (list.Count >= 100)
                    MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.AddressId.ToString());
                    lv.SubItems.Add(li.Barangay);
                    lv.SubItems.Add(li.Municipal_City);
                    lv.SubItems.Add(li.Province);
                    lv.SubItems.Add(li.Country);
                    lv.SubItems.Add(li.ZipCode);
                    lv.Font = new Font(lv.Font, FontStyle.Regular);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadvars(txtSearch.Text);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
             if (listView1.Items.Count > 0)
            {
                if (IsSelectAddress)
                {
                    strAddressSelected = string.Concat(listView1.SelectedItems[0].SubItems[1].Text.ToString(), ", ", listView1.SelectedItems[0].SubItems[2].Text.ToString(), ", ", listView1.SelectedItems[0].SubItems[3].Text.ToString(), ", ", listView1.SelectedItems[0].SubItems[4].Text.ToString(), " ", listView1.SelectedItems[0].SubItems[5].Text.ToString());
                    this.Close();
                }
                else
                {
                    bttnEdit.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("No records found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            frmAddress_AE f = new frmAddress_AE();
            f.ADD_STATE = true;
            f.bttnSave.Text = "Save Item";
            f.ShowDialog();
            loadvars("");
        }

        private void frmAddress_Load(object sender, EventArgs e)
        {
            loadvars("");
            if (!IsSelectAddress)
            {
                label2.Visible = false;
            }
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Pls. Select an Item.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmAddress_AE f = new frmAddress_AE();
                f.ADD_STATE = false;
                f.addressForEditModel = new AddressModel
                {
                    AddressId = int.Parse(listView1.SelectedItems[0].Text),
                    Barangay = listView1.SelectedItems[0].SubItems[1].Text,
                    Municipal_City = listView1.SelectedItems[0].SubItems[2].Text,
                    Province = listView1.SelectedItems[0].SubItems[3].Text,
                    Country = listView1.SelectedItems[0].SubItems[4].Text,
                    ZipCode = listView1.SelectedItems[0].SubItems[5].Text
                };

                f.bttnSave.Text = "Edit Item";
                f.ShowDialog();
                loadvars("");
            }
        }
    }
}
