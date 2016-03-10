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
    public partial class fmFlyweightPattern : Form
    {
        public fmFlyweightPattern()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebSiteFactory f = new WebSiteFactory();

            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use(new User("AAA","111"));

            WebSite fy = f.GetWebSiteCategory("博客");
            fy.Use(new User("BBB", "222"));

            WebSite fz = f.GetWebSiteCategory("产品展示");
            fz.Use(new User("CCC", "333"));

            WebSite fk = f.GetWebSiteCategory("博客");
            fk.Use(new User("DDD", "444"));

            WebSite ft = f.GetWebSiteCategory("产品展示");
            ft.Use(new User("EEE", "555"));

            WebSite fa = f.GetWebSiteCategory("博客");
            fa.Use(new User("FFF", "666"));

            this.Text = f.SiteCount.ToString();
        }
    }
}
