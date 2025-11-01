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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        // Burayı Kopyala Yapıştır
        private void systemExitButton_Click(object sender, EventArgs e) { this.Close(); }
        private void systemPreviousForm_Click(object sender, EventArgs e)
        {
            _14 previous = new _14();
            this.Hide();
            previous.ShowDialog();
            this.Close();
        }
        private void systemNextForm_Click(object sender, EventArgs e) // MessageBox ekliceksen içindekileri sil messageboxu ekle eklemeyeceksen boş bırak
        {
            _16 next = new _16();
            this.Hide();
            next.ShowDialog();
            this.Close();
        }

        private void _15_Load(object sender, EventArgs e)
        {

        }
    }
}
