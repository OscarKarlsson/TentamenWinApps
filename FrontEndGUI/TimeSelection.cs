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
    public partial class TimeSelection : Form
    {
        public event EventHandler<FormEventArgs> formEvent;
        private FormEventArgs EventArgs = new FormEventArgs();
        DataGetter getData = new DataGetter();
        public TimeSelection()
        {
            InitializeComponent();            
        }
        int btn20id = 0;
        int btn22id = 0;
        int btn00id = 0;
        int btn02id = 0;
        internal void LoadButtons()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                
                foreach (Control b in Controls)
                {
                    if (b is Button)
                    {
                        if (b.Name == "btn20")
                        {
                            btn20id = context.Events.Where(s => s.StartTime == new DateTime(2021, 05, 14, 20, 00, 00)).Where(m => m.Movie.Name == Order.MovieName).Select(e => e.AuditoriumId).First();
                            b.Text = $"Theater {btn20id}";
                            pictureBox1.Visible = false;
                            if (btn20id == 9 || btn20id == 10)
                            {
                                pictureBox1.Visible = true;
                            }
                        }
                        if (b.Name == "btn22")
                        {
                            btn22id = context.Events.Where(s => s.StartTime == new DateTime(2021, 05, 14, 22, 00, 00)).Where(m => m.Movie.Name == Order.MovieName).Select(e => e.AuditoriumId).First();
                            b.Text = $"Theater {btn22id}";
                            pictureBox2.Visible = false;
                            if (btn22id == 9 || btn22id == 10)
                            {
                                pictureBox2.Visible = true;
                            }
                        }
                        if (b.Name == "btn00")
                        {
                            btn00id = context.Events.Where(s => s.StartTime == new DateTime(2021, 05, 15, 00, 00, 00)).Where(m => m.Movie.Name == Order.MovieName).Select(e => e.AuditoriumId).First();
                            b.Text = $"Theater {btn00id}";
                            pictureBox3.Visible = false;
                            if (btn00id == 9 || btn00id == 10)
                            {
                                pictureBox3.Visible = true;
                            }
                        }
                        if (b.Name == "btn02")
                        {
                            btn02id = context.Events.Where(s => s.StartTime == new DateTime(2021, 05, 15, 02, 00, 00)).Where(m => m.Movie.Name == Order.MovieName).Select(e => e.AuditoriumId).First();
                            b.Text = $"Theater {btn02id}";
                            pictureBox4.Visible = false;
                            if (btn02id == 9 || btn02id == 10)
                            {
                                pictureBox4.Visible = true;
                            }
                        }
                    }

                }
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Order.EventId = btn20id;
            formEvent.Invoke(this, EventArgs);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            Order.EventId = btn22id;
            formEvent.Invoke(this, EventArgs);
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            Order.EventId = btn00id;
            formEvent.Invoke(this, EventArgs);
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            Order.EventId = btn02id;
            formEvent.Invoke(this, EventArgs);
        }
    }
}
