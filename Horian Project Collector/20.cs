using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horian_Project_Collector
{
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void systemExitButton_Click(object sender, EventArgs e) { this.Close(); }
        private void systemPreviousForm_Click(object sender, EventArgs e)
        {
            _19 previous = new _19();
            this.Hide();
            previous.ShowDialog();
            this.Close();
        }

        private void _20_Load(object sender, EventArgs e)
        {

        }
    }
}
