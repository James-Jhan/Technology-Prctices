using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technology_Practices
{
    public partial class Chapter1 : Form
    {
        public Chapter1()
        {
            InitializeComponent();
        }

        private void NameofBtn_Click(object sender, EventArgs e)
        {
            string msg1 = "執行方法名稱為：Operratornameof";
            MessageBox.Show(msg1, "程式寫死");

            string msg2 = "執行方法名稱為：" + nameof(Chapter1.Operatornameof);
            MessageBox.Show(msg2, "nameof");
        }

        public void Operatornameof(object name)
        {
            if (null == name)
                throw new ArgumentException(nameof(System.Diagnostics.ThreadState));
            else
                MessageBox.Show("Name: " + name);
        }
    }
}
