using Backend;
using Backend.Entities;
using FrontEndGUI.Events;
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
    public partial class ChangeBooking : Form
    {
        public event EventHandler<FormEventArgs> formEvent;
        private FormEventArgs EventArgs = new FormEventArgs();
        Regex regexPhone = new Regex(@"^\d{3,10}$");
        DataGetter GetData = new DataGetter();
        public ChangeBooking()
        {
            InitializeComponent();
            btnCheck.Enabled = false;
        }
        private string phoneNr;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (regexPhone.IsMatch(textBox1.Text))
            {
                textBox1.BackColor = Color.Green;
                btnCheck.Enabled = true;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                btnCheck.Enabled = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var history = GetData.GetHistory(textBox1.Text, context);
                if (history.Any())
                {
                    foreach (var item in history)
                    {
                        if (!ListChecker(item.EventId))
                        {
                            listView1.Items.Add(new ListViewItem(
                            new string[] { item.EventId.ToString(), item.movieName, item.StartTime.ToString() }));
                        }
                    }
                    phoneNr = textBox1.Text;
                }
            }
        }
        private bool ListChecker(int id)
        {
            bool exist = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == id.ToString())
                    exist = true;
            }
            return exist;
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = listView1.SelectedItems[0];
            Order.EventIdRemove = int.Parse(item.SubItems[0].Text);
            Order.Customer.PhoneNr = phoneNr;
            textBox1.Text = "";
            formEvent.Invoke(this, EventArgs);
        }
    }
}
