using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignMode
{
    public partial class fmSimpleFactory : Form
    {
        public fmSimpleFactory()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Operation oper = SimpleFactory.GetOperation("+");
            oper.valueA = 11.1;
            oper.valueB = 22.2;
            MessageBox.Show(oper.GetResult().ToString(),"计算结果:");
        }

       
    }
}
