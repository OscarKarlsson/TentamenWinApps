using Backend;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace FrontEndGUI
{
    public partial class RemoveBooking : Form
    {
        DataGetter GetData = new DataGetter();
        public RemoveBooking()
        {
            InitializeComponent();
        }

        internal void LoadListView()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var history = GetData.GetHistoryRemove(context);         
              
                if (history.Any())
                {
                    foreach (var item in history)
                    {
                        if (!ListChecker(item.Seat))
                        {
                            listView1.Items.Add(new ListViewItem(
                            new string[] { item.EventId.ToString(), item.movieName, item.StartTime.ToString(), item.Seat.ToString() }));
                            Order.Customer.ID = item.CustomerId;
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Could not find any matches.");
                    this.Hide();
                }
            }
        }
        private bool ListChecker(int id)
        {
            bool exist = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[3].Text == id.ToString())
                    exist = true;
            }
            return exist;
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order.RemoveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSetter SetData = new DataSetter();
            int counter = 0;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                counter++;
                SetData.RemoveEventReservations(int.Parse(item.SubItems[3].Text));
            }         
            MessageBox.Show($"Removed {counter} ticket(s).");
            this.Hide();
            Order.RemoveData();
        }
    }
}
