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
    public partial class fmObserver : Form
    {
        public fmObserver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat();
            Mouse m1 = new Mouse("白猫", cat);
            Mouse m2 = new Mouse("黑猫", cat);
            People p = new People(cat);
            cat.Cry();
        }
    }
}
