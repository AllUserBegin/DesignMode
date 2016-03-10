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
    public partial class fmTemplate : Form
    {
        public fmTemplate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 模版方法调用
            OrderGenerator orderGenerator = new B2COrderGenerator();
            orderGenerator.Excute();
            #endregion
        }
    }
}
