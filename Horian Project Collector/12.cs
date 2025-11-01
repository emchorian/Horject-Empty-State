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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        // Burayı Kopyala Yapıştır
        private void systemExitButton_Click(object sender, EventArgs e) { this.Close(); }
        private void systemPreviousForm_Click(object sender, EventArgs e)
        {
            _11 previous = new _11();
            this.Hide();
            previous.ShowDialog();
            this.Close();
        }
        private void systemNextForm_Click(object sender, EventArgs e) // MessageBox ekliceksen içindekileri sil messageboxu ekle eklemeyeceksen boş bırak
        {
            _13 next = new _13();
            this.Hide();
            next.ShowDialog();
            this.Close();
        }

        private void _12_Load(object sender, EventArgs e)
        {

        }
    }
}
