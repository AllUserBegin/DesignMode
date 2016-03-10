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
    public partial class fmState : Form
    {
        public fmState()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkProgram w = new WorkProgram();
            w.Hour = 9;
            w.WriteProgram();
            w.Hour = 12.5;
            w.WriteProgram();
        }
    }
}
