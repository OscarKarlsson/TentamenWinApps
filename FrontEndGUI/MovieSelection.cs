using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using Backend.Entities;
using FrontEndGUI.Events;

namespace FrontEndGUI
{
    public partial class MovieSelection : Form
    {
        public event EventHandler<FormEventArgs> formEvent;
        private FormEventArgs EventArgs = new FormEventArgs();
        DataGetter getData = new DataGetter();
        protected override bool ScaleChildren { get; } = false;
        public MovieSelection()
        {
            InitializeComponent();
            SetToolTips();
        }
        List<Movie> movies = new List<Movie>();
        private void SetToolTips()
        {
            movies = getData.GetMovies();
            toolTip1.SetToolTip(picShining, ReturnDesc("The Shining"));
            toolTip1.SetToolTip(picAlien, ReturnDesc("Aliens"));
            toolTip1.SetToolTip(picElm, ReturnDesc("A Nightmare on Elm Street"));
            toolTip1.SetToolTip(picEvilDead, ReturnDesc("Evil Dead 2: Dead by Dawn"));
            toolTip1.SetToolTip(picFog, ReturnDesc("The Fog"));
            toolTip1.SetToolTip(picPossession, ReturnDesc("Possession"));
            toolTip1.SetToolTip(picTenebre, ReturnDesc("Tenebre"));
            toolTip1.SetToolTip(picTexas, ReturnDesc("The Texas Chainsaw Massacre Part 2"));
            toolTip1.SetToolTip(picThing, ReturnDesc("The Thing"));
            toolTip1.SetToolTip(picVideodrome, ReturnDesc("Videodrome"));
        }
        private string ReturnDesc(string movieName)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Name == movieName)
                {
                    return movies[i].Description;
                }
            }
            return "N/A";
        }

        private void picShining_Click(object sender, EventArgs e)
        {
            Order.MovieName = "The Shining";
            formEvent.Invoke(this, EventArgs);
        }

        private void picAlien_Click(object sender, EventArgs e)
        {
            Order.MovieName = "Aliens";
            formEvent.Invoke(this, EventArgs);
        }

        private void picElm_Click(object sender, EventArgs e)
        {
            Order.MovieName = "A Nightmare on Elm Street";
            formEvent.Invoke(this, EventArgs);
        }

        private void picEvilDead_Click(object sender, EventArgs e)
        {
            Order.MovieName = "Evil Dead 2: Dead by Dawn";
            formEvent.Invoke(this, EventArgs);
        }

        private void picFog_Click(object sender, EventArgs e)
        {
            Order.MovieName = "The Fog";
            formEvent.Invoke(this, EventArgs);
        }

        private void picPossession_Click(object sender, EventArgs e)
        {
            Order.MovieName = "Possession";
            formEvent.Invoke(this, EventArgs);
        }

        private void picTenebre_Click(object sender, EventArgs e)
        {
            Order.MovieName = "Tenebre";
            formEvent.Invoke(this, EventArgs);
        }

        private void picTexas_Click(object sender, EventArgs e)
        {
            Order.MovieName = "The Texas Chainsaw Massacre Part 2";
            formEvent.Invoke(this, EventArgs);
        }

        private void picThing_Click(object sender, EventArgs e)
        {
            Order.MovieName = "The Thing";
            formEvent.Invoke(this, EventArgs);
        }

        private void picVideodrome_Click(object sender, EventArgs e)
        {
            Order.MovieName = "Videodrome";
            formEvent.Invoke(this, EventArgs);
        }
    }
}
