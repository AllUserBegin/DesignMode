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
    public partial class fmAdapter : Form
    {
        public fmAdapter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Csharp t = new Adapter();
            this.Text=t.Respose(10,20).ToString();
        }
    }
}
