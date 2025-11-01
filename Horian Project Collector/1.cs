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
    public partial class _1 : Form
    {
        public _1()
        {
            InitializeComponent();
        }

        private void systemExitButton_Click(object sender, EventArgs e) { this.Close(); }
        private void systemNextForm_Click(object sender, EventArgs e)
        {
            _2 next = new _2();
            this.Hide();
            next.ShowDialog();
            this.Close();
        }

        private void _1_Load(object sender, EventArgs e)
        {

        }
    }
}
