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
    public partial class fmCommand : Form
    {
        public fmCommand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //服务员
            Waiter waier = new Waiter();
            //接收人
            Receiver r = new Receiver();
            //接收命令
            //Command c = new Command(r);
            //waier.SetOrder(c);
            //waier.ExcuteCommand();
        }
    }
}
