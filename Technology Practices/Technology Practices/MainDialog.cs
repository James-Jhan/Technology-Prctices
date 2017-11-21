using System;
using System.Windows.Forms;

namespace Technology_Practices
{
    public partial class MainDialog : Form
    {
        public MainDialog()
        {
            InitializeComponent();
        }

        private void Chapter1_Click(object sender, EventArgs e)
        {
            Chapter1 dlg = new Chapter1();

            this.Visible = false;

            dlg.Visible = true;
        }
    }
}
