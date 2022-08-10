using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void Error_button_Click(object sender, EventArgs e)
        {
            if(this != null)
            {
                this.Close();
                Error_label.Text = "-";
            }
        }
    }
}
