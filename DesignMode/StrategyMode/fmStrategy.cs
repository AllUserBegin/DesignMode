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
    public partial class fmStrategy : Form
    {
        public fmStrategy()
        {
            InitializeComponent();
            this.Text = "策略模式";
        }
        CashFactory cf = null;
        CashSuper cs = null;
        private void btn正常收费_Click(object sender, EventArgs e)
        {
            cs= new CashNormal(); 
            cf = new CashFactory(cs);
            MessageBox.Show(cf.GetResult(300).ToString());
            //((CashNormal)cs).Test();       
        }

        private void btn满300返100_Click(object sender, EventArgs e)
        {
            cs = new CashReturn("300","100");
            cf = new CashFactory(cs);
            MessageBox.Show(cf.GetResult(501).ToString());  
        }

        private void btn打8折_Click(object sender, EventArgs e)
        {
            cs = new CashRebate(0.8m);
            cf = new CashFactory(cs);
            MessageBox.Show(cf.GetResult(300).ToString());
            MessageBox.Show(cf.GetCouponResult(300).ToString()); 
        }

     
    }
}
