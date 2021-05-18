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

namespace FrontEndGUI
{
    public partial class MovieSelection : Form
    {
        DataGetter getData = new Backend.DataGetter();
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

        }
    }
}
