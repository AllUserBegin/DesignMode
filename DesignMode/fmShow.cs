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
    public partial class fmShow : Form
    {
        public fmShow()
        {
            InitializeComponent();
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        { 
            fmAdapter fm = new fmAdapter();
            fm.ShowDialog();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
          
            fmCommand fm = new fmCommand();
            fm.ShowDialog();
        }

        private void btnFacade_Click(object sender, EventArgs e)
        {
            fmFacade fm = new fmFacade();
            fm.ShowDialog();
        }

        private void btnFlyweightPattern_Click(object sender, EventArgs e)
        {
            fmFlyweightPattern fm = new fmFlyweightPattern();
            fm.ShowDialog();
        }

        private void btnObserver_Click(object sender, EventArgs e)
        {
            fmObserver fm = new fmObserver();
            fm.ShowDialog();
        }

        private void btnSimpleFactory_Click(object sender, EventArgs e)
        {
            fmSimpleFactory fm = new fmSimpleFactory();
            fm.ShowDialog();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            fmState fm = new fmState();
            fm.ShowDialog();
        }

        private void btnStrategy_Click(object sender, EventArgs e)
        {
            fmStrategy fm = new fmStrategy();
            fm.ShowDialog();
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            fmTemplate fm = new fmTemplate();
            fm.ShowDialog();
        }

       

    }
}
