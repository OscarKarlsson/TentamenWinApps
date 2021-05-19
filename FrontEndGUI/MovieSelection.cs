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
        private void SetToolTips()
        {
            List<Movie> movies = getData.GetMovies();
            toolTip1.SetToolTip(picShining, ReturnDesc("The Shining", movies));
            toolTip1.SetToolTip(picAlien, ReturnDesc("Aliens", movies));
            toolTip1.SetToolTip(picElm, ReturnDesc("A Nightmare on Elm Street", movies));
            toolTip1.SetToolTip(picEvilDead, ReturnDesc("Evil Dead 2: Dead by Dawn", movies));
            toolTip1.SetToolTip(picFog, ReturnDesc("The Fog", movies));
            toolTip1.SetToolTip(picPossession, ReturnDesc("Possession", movies));
            toolTip1.SetToolTip(picTenebre, ReturnDesc("Tenebre", movies));
            toolTip1.SetToolTip(picTexas, ReturnDesc("The Texas Chainsaw Massacre Part 2", movies));
            toolTip1.SetToolTip(picThing, ReturnDesc("The Thing", movies));
            toolTip1.SetToolTip(picVideodrome, ReturnDesc("Videodrome", movies));
        }
        private string ReturnDesc(string movieName, List<Movie> movies)
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
            
            
            formEvent.Invoke(this, EventArgs);
        }
    }
}
