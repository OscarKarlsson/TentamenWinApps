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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGUI
{
    public partial class SeatSelection : Form
    {
        DataGetter GetData = new DataGetter();
        public event EventHandler<FormEventArgs> formEvent;
        private FormEventArgs EventArgs = new FormEventArgs();
        protected override bool ScaleChildren { get; } = false;
        public SeatSelection()
        {
            InitializeComponent();
        }
        internal void LoadMoviePic()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var movie = context.Movies.Where(m => m.Name == Order.MovieName).First();
                picMovie.BackgroundImage = Image.FromFile($@"Pics\{movie.FilePath}");
            }
            
            
        }
        internal void LoadSeatButtons()
        {
            var reservations = GetData.GetSeats();
            int tempName;
            foreach (Control c in panel2.Controls)
            {
                if (c is FontAwesome.Sharp.IconButton)
                {
                    c.Enabled = true;
                    tempName = int.Parse(c.Name.Remove(0, 3));
                    foreach (var item in reservations)
                    {
                        if (item.SeatId == tempName)
                        {
                            c.Enabled = false;
                        }
                    }
                }
            }
        }
        internal void LoadViewItems()
        {

        }
        ListViewItem item1 = new ListViewItem(new string[] { Order.MovieName, "1" });
        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (btn1.IconColor == Color.Green)
            {                
                btn1.IconColor = Color.Red;
              
            }
            else if (btn1.IconColor == Color.Red)
            {
                btn1.IconColor = Color.Green;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.IconColor == Color.Green)
            {
                btn2.IconColor = Color.Red;
             
            }
            else if (btn2.IconColor == Color.Red)
            {
                btn2.IconColor = Color.Green;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.IconColor == Color.Green)
            {
                btn3.IconColor = Color.Red;
             
            }
            else if (btn3.IconColor == Color.Red)
            {
                btn3.IconColor = Color.Green;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.IconColor == Color.Green)
            {
                btn4.IconColor = Color.Red;
             
            }
            else if (btn4.IconColor == Color.Red)
            {
                btn4.IconColor = Color.Green;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.IconColor == Color.Green)
            {
                btn5.IconColor = Color.Red;
               
            }
            else if (btn5.IconColor == Color.Red)
            {
                btn5.IconColor = Color.Green;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.IconColor == Color.Green)
            {
                btn6.IconColor = Color.Red;
               
            }
            else if (btn6.IconColor == Color.Red)
            {
                btn6.IconColor = Color.Green;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.IconColor == Color.Green)
            {
                btn7.IconColor = Color.Red;
              
            }
            else if (btn7.IconColor == Color.Red)
            {
                btn7.IconColor = Color.Green;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.IconColor == Color.Green)
            {
                btn8.IconColor = Color.Red;
                
            }
            else if (btn8.IconColor == Color.Red)
            {
                btn8.IconColor = Color.Green;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.IconColor == Color.Green)
            {
                btn9.IconColor = Color.Red;
               
            }
            else if (btn9.IconColor == Color.Red)
            {
                btn9.IconColor = Color.Green;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.IconColor == Color.Green)
            {
                btn10.IconColor = Color.Red;
              
            }
            else if (btn10.IconColor == Color.Red)
            {
                btn10.IconColor = Color.Green;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.IconColor == Color.Green)
            {
                btn11.IconColor = Color.Red;
             
            }
            else if (btn11.IconColor == Color.Red)
            {
                btn11.IconColor = Color.Green;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.IconColor == Color.Green)
            {
                btn12.IconColor = Color.Red;
            
            }
            else if (btn12.IconColor == Color.Red)
            {
                btn12.IconColor = Color.Green;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (btn13.IconColor == Color.Green)
            {
                btn13.IconColor = Color.Red;
                
            }
            else if (btn13.IconColor == Color.Red)
            {
                btn13.IconColor = Color.Green;
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (btn14.IconColor == Color.Green)
            {
                btn14.IconColor = Color.Red;
               
            }
            else if (btn14.IconColor == Color.Red)
            {
                btn14.IconColor = Color.Green;
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (btn15.IconColor == Color.Green)
            {
                btn15.IconColor = Color.Red;
             
            }
            else if (btn15.IconColor == Color.Red)
            {
                btn15.IconColor = Color.Green;
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (btn16.IconColor == Color.Green)
            {
                btn16.IconColor = Color.Red;
            
            }
            else if (btn16.IconColor == Color.Red)
            {
                btn16.IconColor = Color.Green;
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (btn17.IconColor == Color.Green)
            {
                btn17.IconColor = Color.Red;
              
            }
            else if (btn17.IconColor == Color.Red)
            {
                btn17.IconColor = Color.Green;
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (btn18.IconColor == Color.Green)
            {
                btn18.IconColor = Color.Red;
             
            }
            else if (btn18.IconColor == Color.Red)
            {
                btn18.IconColor = Color.Green;
            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (btn19.IconColor == Color.Green)
            {
                btn19.IconColor = Color.Red;
        
            }
            else if (btn19.IconColor == Color.Red)
            {
                btn19.IconColor = Color.Green;
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (btn20.IconColor == Color.Green)
            {
                btn20.IconColor = Color.Red;
            }
            else if (btn20.IconColor == Color.Red)
            {
                btn20.IconColor = Color.Green;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is FontAwesome.Sharp.IconButton)
                {
                    if (((FontAwesome.Sharp.IconButton)c).IconColor == Color.Red)
                    {
                        Order.Reservations.Add(new EventReservation
                        { EventId = Order.EventId, SeatId = int.Parse(c.Name.Remove(0, 3)) });
                        ((FontAwesome.Sharp.IconButton)c).IconColor = Color.Green;
                    }
                    
                }
            }
            formEvent.Invoke(this, EventArgs);
        }
    }
}
