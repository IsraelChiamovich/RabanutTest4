using System;
using System.Windows.Forms;
using static Rabanut.Service.RabanutService;

namespace Rabanut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            
            CreateQuery(DaycomboBox.Text, int.Parse(DayManthcomboBox.Text), ManthcomboBox.Text, YearcomboBox.Text);
            ShowResult();
        }

        public void ShowResult()
        {
            string result = StrResult(DaycomboBox.Text, int.Parse(DayManthcomboBox.Text), ManthcomboBox.Text, YearcomboBox.Text);
            MessageBox.Show(result);
        }
    }
}
