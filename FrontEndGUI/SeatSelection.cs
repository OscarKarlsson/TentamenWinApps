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

namespace FrontEndGUI
{
    public partial class SeatSelection : Form
    {
        DataGetter GetData = new DataGetter();
        protected override bool ScaleChildren { get; } = false;
        public SeatSelection()
        {
            InitializeComponent();
        }

        internal void LoadSeatButtons()
        {
            var seat = GetData.GetSeats();
            int tempName;
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    tempName = int.Parse(c.Name.Remove(0, 3));
                    foreach (var item in seat)
                    {
                        if (item.SeatNumber == tempName)
                        {
                            c.BackColor = Color.Red;
                            c.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.IconColor == Color.Green)
            {
                btn1.IconColor = Color.Red;
                Order.Reservations.Add(new EventReservation { EventId = Order.EventId, SeatId = 1 });
                listOrder.Items.Add(new ListViewItem(new string[] { Order.MovieName, "1" }));
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {

        }

        private void btn12_Click(object sender, EventArgs e)
        {

        }

        private void btn13_Click(object sender, EventArgs e)
        {

        }

        private void btn14_Click(object sender, EventArgs e)
        {

        }

        private void btn15_Click(object sender, EventArgs e)
        {

        }

        private void btn16_Click(object sender, EventArgs e)
        {

        }

        private void btn17_Click(object sender, EventArgs e)
        {

        }

        private void btn18_Click(object sender, EventArgs e)
        {

        }

        private void btn19_Click(object sender, EventArgs e)
        {

        }

        private void btn20_Click(object sender, EventArgs e)
        {

        }
    }
}
