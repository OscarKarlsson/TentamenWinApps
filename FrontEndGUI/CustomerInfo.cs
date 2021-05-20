using Backend;
using Backend.Entities;
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

namespace FrontEndGUI
{
    public partial class CustomerInfo : Form
    {
        protected override bool ScaleChildren { get; } = false;
        DataGetter GetData = new DataGetter();
        Customer activeCustomer = new Customer();
        Regex regexPhone = new Regex(@"^\d{3,10}$");
        Regex regexFirst = new Regex(@"^[a-zA-Z]{3,15}$");
        Regex regexLast = new Regex(@"^[a-zA-Z]{3,20}$");
        public CustomerInfo()
        {
            InitializeComponent();
            DisableControls();
        }
        private void DisableControls()
        {
            BtnCheckout.Enabled = false;
            btnSubmit.Enabled = false;
            btnCheck.Enabled = false;
            txtFirst.Enabled = false;
            txtLast.Enabled = false;
        }
        internal void LoadViewList()
        {
            foreach (var item in Order.Reservations)
            {
                listSeats.Items.Add(new ListViewItem(new string[] { Order.MovieName, item.SeatId.ToString() }));
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            activeCustomer = GetData.GetCustomer(txtPhone.Text);
            if (activeCustomer == null)
            {
                MessageBox.Show("Could not find a customer with that phone number!\nPlease insert first/lastname.");
                txtFirst.Enabled = true;
                txtLast.Enabled = true;
                txtPhone.Enabled = false;
                btnCheck.Enabled = false;
                txtFirst.Text = "";
                txtLast.Text = "";
                
            }
            else
            {
                txtPhone.Enabled = false;
                btnCheck.Enabled = false;
                txtFirst.Text = activeCustomer.FirstName;
                txtLast.Text = activeCustomer.LastName;
                btnSubmit.Enabled = false;
                BtnCheckout.Enabled = true;

            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (regexPhone.IsMatch(txtPhone.Text))
            {
                txtPhone.BackColor = Color.Green;
                btnCheck.Enabled = true;
            }
            else
            {
                txtPhone.BackColor = Color.Red;
                btnCheck.Enabled = false;
            }
                       
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            if (regexFirst.IsMatch(txtFirst.Text))
            {
                txtFirst.BackColor = Color.Green;                
            }
            else
            {
                txtPhone.BackColor = Color.Red;
            }
            if (txtFirst.BackColor == Color.Green && txtLast.BackColor == Color.Green)
            {
                btnSubmit.Enabled = true;
            }
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            if (regexLast.IsMatch(txtLast.Text))
            {
                txtLast.BackColor = Color.Green;
            }
            else
            {
                txtLast.BackColor = Color.Red;
            }
            if (txtFirst.BackColor == Color.Green && txtLast.BackColor == Color.Green)
            {
                btnSubmit.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Order.Customer.FirstName = txtFirst.Text;
            Order.Customer.LastName = txtLast.Text;
            Order.Customer.PhoneNr = txtPhone.Text;
            BtnCheckout.Enabled = true;
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Order.Customer.FirstName = txtFirst.Text;
            Order.Customer.LastName = txtLast.Text;
            Order.Customer.PhoneNr = txtPhone.Text;
            DataSetter SetData = new DataSetter();
            SetData.SetCustomer(Order.Customer.PhoneNr, Order.Customer.FirstName,Order.Customer.LastName);
            SetData.SetEventReservation();
            SetData.SetSeats();
            MessageBox.Show($"You booked {Order.Reservations.Count} ticket(s).");
            Order.RemoveData();
        }
    }
}
