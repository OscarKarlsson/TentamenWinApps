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
    public partial  class Form1 : Form
    {
        SeatSelection childFormSeat = new SeatSelection();
        MovieSelection childFormMovie = new MovieSelection();
        TimeSelection childFormTime = new TimeSelection();
        CustomerInfo childFormCustomer = new CustomerInfo();
        static Random rnd = new Random();
        CinemaContext db = new CinemaContext("CinemaContext");
        public Form1()
        {
            InitializeComponent();
            CuztomizeDesign();
            if (db.Database.CreateIfNotExists()) CreateData();            
            childFormMovie.formEvent += OpenChildFormTime;
            childFormTime.formEvent += OpenChildFormSeat;
            childFormSeat.formEvent += OpenChildFormCustomer;
        }
        private void CuztomizeDesign()
        {
            panelSubBooking.Visible = false;
            panelSubCinema.Visible = false;
            panelSubHistory.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubBooking.Visible == true) panelSubBooking.Visible = false;
            if (panelSubCinema.Visible == true) panelSubCinema.Visible = false;
            if (panelSubHistory.Visible == true) panelSubHistory.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region CreateDataRegion
        private void CreateData()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                CreateMovies(context);
                CreateAuditoriums(context);
                CreateEvents(context);
                CreateCustomers(context);
            }

        }
        private void CreateMovies(CinemaContext context)
        {
            var movie = new Movie()
            {
                Name = "The Shining",
                Duration = new TimeSpan(2, 26, 00),
                Description = "A family heads to an isolated hotel for the winter" +
                                " where a sinister presence influences the father into violence," +
                                " while his psychic son sees horrific forebodings from both past and future.",
                FilePath = "shining-poster.jpg"
            };
            context.Movies.Add(movie);
            var movie1 = new Movie()
            {
                Name = "The Thing",
                Duration = new TimeSpan(1, 49, 00),
                Description = "A research team in Antarctica is hunted by a shape - " +
                "shifting alien that assumes the appearance of its victims.",
                FilePath = "thing-poster.jpg"
            };
            context.Movies.Add(movie1);
            var movie2 = new Movie()
            {
                Name = "Aliens",
                Duration = new TimeSpan(2, 17, 00),
                Description = "Fifty-seven years after surviving an apocalyptic" +
                " attack aboard her space vessel by merciless space creatures," +
                " Officer Ripley awakens from hyper-sleep and tries to warn anyone who will listen about the predators.",
                FilePath = "aliens-poster.jpg"
            };
            context.Movies.Add(movie2);
            var movie3 = new Movie()
            {
                Name = "Possession",
                Duration = new TimeSpan(2, 4, 00),
                Description = "A woman starts exhibiting increasingly disturbing behavior after asking her husband for a divorce." +
                " Suspicions of infidelity soon give way to something much more sinister.",
                FilePath = "possession-poster.jpg"
            };
            context.Movies.Add(movie3);
            var movie4 = new Movie()
            {
                Name = "A Nightmare on Elm Street",
                Duration = new TimeSpan(1, 31, 00),
                Description = "The monstrous spirit of a slain child murderer seeks" +
                " revenge by invading the dreams of teenagers whose parents were " +
                "responsible for his untimely death.",
                FilePath = "elm-poster.jpg"
            };
            context.Movies.Add(movie4);
            var movie5 = new Movie()
            {
                Name = "Evil Dead 2: Dead by Dawn",
                Duration = new TimeSpan(1, 24, 00),
                Description = "The lone survivor of an onslaught of flesh-possessing spirits" +
                " holes up in a cabin with a group of strangers while the demons continue their attack.",
                FilePath = "evildead-poster.jpg"
            };
            context.Movies.Add(movie5);
            var movie6 = new Movie()
            {
                Name = "The Texas Chainsaw Massacre Part 2",
                Duration = new TimeSpan(1, 41, 00),
                Description = "A radio host is victimized by the cannibal family " +
                "as a former Texas Marshall hunts them.",
                FilePath = "texas-poster.jpg"
            };
            context.Movies.Add(movie6);
            var movie7 = new Movie()
            {
                Name = "The Fog",
                Duration = new TimeSpan(1, 29, 00),
                Description = "An unearthly fog rolls into a small coastal town exactly 100 years " +
                "after a ship mysteriously sank in its waters.",
                FilePath = "fog-poster.jpg"
            };
            context.Movies.Add(movie7);
            var movie8 = new Movie()
            {
                Name = "Videodrome",
                Duration = new TimeSpan(1, 27, 00),
                Description = "A programmer at a TV station that specializes in adult entertainment " +
                "searches for the producers of a dangerous and bizarre broadcast.",
                FilePath = "videodrome-poster.jpg"
            };
            context.Movies.Add(movie8);
            var movie9 = new Movie()
            {
                Name = "Tenebre",
                Duration = new TimeSpan(1, 41, 00),
                Description = "An American writer in Rome is stalked and harassed by " +
                "a serial killer who is murdering everyone associated with his work on his latest book.",
                FilePath = "tenebrae-poster.jpg"
            };
            context.Movies.Add(movie9);
            context.SaveChanges();
        }
        private void CreateAuditoriums(CinemaContext context)
        {
            var Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = false
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = true
            };
            context.Auditoriums.Add(Auditorium);
            Auditorium = new Auditorium()
            {
                HasRamp = true
            };
            context.Auditoriums.Add(Auditorium);
            context.SaveChanges();
        }
        private void CreateEvents(CinemaContext context)
        {
            RandomizeEvents(new DateTime(2021, 05, 14, 20, 00, 00), new DateTime(2021, 05, 14, 22, 00, 00), context);
            RandomizeEvents(new DateTime(2021, 05, 14, 22, 00, 00), new DateTime(2021, 05, 15, 00, 00, 00), context);
            RandomizeEvents(new DateTime(2021, 05, 15, 00, 00, 00), new DateTime(2021, 05, 15, 02, 00, 00), context);
            RandomizeEvents(new DateTime(2021, 05, 15, 02, 00, 00), new DateTime(2021, 05, 15, 04, 00, 00), context);
        }
        private void RandomizeEvents(DateTime start, DateTime end, CinemaContext context)
        {
            List<int> ints1 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            int random1;
            List<int> ints2 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            int random2;
            var events = new Event();
            while (ints1.Count > 0)
            {
                random1 = rnd.Next(ints1.Count);
                events.AuditoriumId = ints1[random1];
                random2 = rnd.Next(ints2.Count);
                events.MovieId = ints2[random2];
                events.StartTime = start;
                events.EndTime = end;
                context.Events.Add(events);
                context.SaveChanges();
                ints1.RemoveAt(random1);
                ints2.RemoveAt(random2);
            }


        }
        private void CreateCustomers(CinemaContext context)
        {
            var customer = new Customer()
            {
                FirstName = "Oscar",
                LastName = "Karlsson",
                PhoneNr = "076555555"
            };
            context.Customers.Add(customer);
            var customer1 = new Customer()
            {
                FirstName = "Filip",
                LastName = "Ekberg",
                PhoneNr = "076123456"
            };
            context.Customers.Add(customer1);
            var customer2 = new Customer()
            {
                FirstName = "Josefine",
                LastName = "Holstensson",
                PhoneNr = "076999999"
            };
            context.Customers.Add(customer2);
            var customer3 = new Customer()
            {
                FirstName = "Lennart",
                LastName = "Josefsson",
                PhoneNr = "0761234"
            };
            context.Customers.Add(customer3);
            var customer4 = new Customer()
            {
                FirstName = "Oscar",
                LastName = "Svensson",
                PhoneNr = "07612345"
            };
            context.Customers.Add(customer4);
            context.SaveChanges();
        }
        #endregion
        #region BookingSubMenu
        private void btnTickets_Click(object sender, EventArgs e)
        {
            OpenChildForm(childFormMovie);
            HideSubMenu();
        }

        private void btnChangeBooking_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubBooking);
        }
        #endregion
        #region CinemaSubMenu
        private void btnCinema_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubCinema);
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTheaters_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion
        #region HistorySubMenu
        private void btnHistory_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubHistory);
        }

        private void btnSubHistory_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion
        internal Form activeForm = null;
        internal void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        internal void OpenChildFormSeat(object sender, FormEventArgs args)
        {
            OpenChildForm(childFormSeat);
            childFormSeat.LoadSeatButtons();
            childFormSeat.LoadMoviePic();
        }
        internal void OpenChildFormTime(object sender, FormEventArgs args)
        {
            OpenChildForm(childFormTime);
            childFormTime.LoadButtons();
        }
        internal void OpenChildFormCustomer(object sender, FormEventArgs args)
        {
            OpenChildForm(childFormCustomer);
            childFormCustomer.LoadViewList();
        }
    }
}
