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
    public partial class Anasayfa : Form
    {
        public Anasayfa() { InitializeComponent(); }
        private void number1_Click(object sender, EventArgs e) { numericLabel.Text += "1"; }
        private void number2_Click(object sender, EventArgs e) { numericLabel.Text += "2"; }
        private void number3_Click(object sender, EventArgs e) { numericLabel.Text += "3"; }
        private void number4_Click(object sender, EventArgs e) { numericLabel.Text += "4"; }
        private void number5_Click(object sender, EventArgs e) { numericLabel.Text += "5"; }
        private void number6_Click(object sender, EventArgs e) { numericLabel.Text += "6"; }
        private void number7_Click(object sender, EventArgs e) { numericLabel.Text += "7"; }
        private void number8_Click(object sender, EventArgs e) { numericLabel.Text += "8"; }
        private void number9_Click(object sender, EventArgs e) { numericLabel.Text += "9"; }
        private void number0_Click(object sender, EventArgs e) { numericLabel.Text += "0"; }
        private void delete_Click(object sender, EventArgs e) { numericLabel.Text = ""; }
        private void lastEnter_Click(object sender, EventArgs e)
        {
            _20 lastform = new _20();
            lastform.ShowDialog();
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
            numericLabel.Text = "";
            list.Items.Add("1.) Birinci Proje");
            list.Items.Add("2.) İkinci Proje");
            list.Items.Add("3.) Üçüncü Proje");
            list.Items.Add("4.) Dördüncü Proje");
            list.Items.Add("5.) Beşinci Proje");
            list.Items.Add("6.) Altıncı Proje");
            list.Items.Add("7.) Yedinci Proje");
            list.Items.Add("8.) Sekizinci Proje");
            list.Items.Add("9.) Dokuzuncu Proje");
            list.Items.Add("10.) Onuncu Proje");
            list.Items.Add("11.) On Birinci Proje");
            list.Items.Add("12.) On İkinci Proje");
            list.Items.Add("13.) On Üçüncü Proje");
            list.Items.Add("14.) On Dördüncü Proje");
            list.Items.Add("15.) On Beşinci Proje");
            list.Items.Add("16.) On Altıncı Proje");
            list.Items.Add("17.) On Yedinci Proje");
            list.Items.Add("18.) On Sekizinci Proje");
            list.Items.Add("19.) On Dokuzuncu Proje");
            list.Items.Add("20.) Yirminci Proje");
        }
        private void enter_Click(object sender, EventArgs e)
        {
            if (numericLabel.Text == "")
            {
                MessageBox.Show("Lütfen bir sayfa tuşlayınız!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericLabel.Text == "1")
            {
                _1 form1 = new _1();
                form1.ShowDialog();
            }
            else if (numericLabel.Text == "2")
            {
                _2 form2 = new _2();
                form2.ShowDialog();
            }
            else if (numericLabel.Text == "3")
            {
                _3 form3 = new _3();
                form3.ShowDialog();
            }
            else if (numericLabel.Text == "4")
            {
                _4 form4 = new _4();
                form4.ShowDialog();
            }
            else if (numericLabel.Text == "5")
            {
                _5 form5 = new _5();
                form5.ShowDialog();
            }
            else if (numericLabel.Text == "6")
            {
                _6 form6 = new _6();
                form6.ShowDialog();
            }
            else if (numericLabel.Text == "7")
            {
                _7 form7 = new _7();
                form7.ShowDialog();
            }
            else if (numericLabel.Text == "8")
            {
                _8 form8 = new _8();
                form8.ShowDialog();
            }
            else if (numericLabel.Text == "9")
            {
                _9 form9 = new _9();
                form9.ShowDialog();
            }
            else if (numericLabel.Text == "10")
            {
                _10 form10 = new _10();
                form10.ShowDialog();
            }
            else if (numericLabel.Text == "11")
            {
                _11 form11 = new _11();
                form11.ShowDialog();
            }
            else if (numericLabel.Text == "12")
            {
                _12 form12 = new _12();
                form12.ShowDialog();
            }
            else if (numericLabel.Text == "13")
            {
                _13 form13 = new _13();
                form13.ShowDialog();
            }
            else if (numericLabel.Text == "14")
            {
                _14 form14 = new _14();
                form14.ShowDialog();
            }
            else if (numericLabel.Text == "15")
            {
                _15 form15 = new _15();
                form15.ShowDialog();
            }
            else if (numericLabel.Text == "16")
            {
                _16 form16 = new _16();
                form16.ShowDialog();
            }
            else if (numericLabel.Text == "17")
            {
                _17 form17 = new _17();
                form17.ShowDialog();
            }
            else if (numericLabel.Text == "18")
            {
                _18 form18 = new _18();
                form18.ShowDialog();
            }
            else if (numericLabel.Text == "19")
            {
                _19 form19 = new _19();
                form19.ShowDialog();
            }
            else if (numericLabel.Text == "20")
            {
                _20 form20 = new _20();
                form20.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayfa tuşlayınız!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            numericLabel.Text = "";
        }
        private void numericLabel_TextChanged(object sender, EventArgs e)
        {
            if (numericLabel.Text.Length > 2)
            {
                MessageBox.Show("Sayfa sayısı 2 rakamdan uzun olamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericLabel.Text = numericLabel.Text.Substring(0, 2);
                numericLabel.Text = "";
            }
        }
        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (list.SelectedIndex == -1) return;
            int selected = list.SelectedIndex + 1;

            if (selected == 1)
            {
                _1 form1 = new _1();
                form1.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 2)
            {
                _2 form2 = new _2();
                form2.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 3)
            {
                _3 form3 = new _3();
                form3.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 4)
            {
                _4 form4 = new _4();
                form4.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 5)
            {
                _5 form5 = new _5();
                form5.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 6)
            {
                _6 form6 = new _6();
                form6.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 7)
            {
                _7 form7 = new _7();
                form7.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 8)
            {
                _8 form8 = new _8();
                form8.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 9)
            {
                _9 form9 = new _9();
                form9.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 10)
            {
                _10 form10 = new _10();
                form10.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 11)
            {
                _11 form11 = new _11();
                form11.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 12)
            {
                _12 form12 = new _12();
                form12.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 13)
            {
                _13 form13 = new _13();
                form13.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 14)
            {
                _14 form14 = new _14();
                form14.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 15)
            {
                _15 form15 = new _15();
                form15.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 16)
            {
                _16 form16 = new _16();
                form16.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 17)
            {
                _17 form17 = new _17();
                form17.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 18)
            {
                _18 form18 = new _18();
                form18.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 19)
            {
                _19 form19 = new _19();
                form19.ShowDialog();
                list.SelectedIndex = -1;
            }
            else if (selected == 20)
            {
                _20 form20 = new _20();
                form20.ShowDialog();
                list.SelectedIndex = -1;
            }
        }
    }
}