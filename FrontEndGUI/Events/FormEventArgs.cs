using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGUI.Events
{
    public class FormEventArgs : EventArgs
    {
        public Form form { get; set; }
    }
}
