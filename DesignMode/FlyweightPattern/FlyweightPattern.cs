using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DesignMode
{
    public class User
    {
        string userId = string.Empty;
        string userName = string.Empty;

        public User(string  _name,string _id)
        {
            userId = _id;
            userName = _name;
        }

        public string UserName
        {
            get
            { return this.userName; }
        }

        public string UserId
        {
            get
            { return this.userId; }
        }

    }

    public abstract class WebSite
    {
        public abstract void Use(User u);
    }

    public class CreateWebSite : WebSite
    {
        private string name = string.Empty;
        public CreateWebSite(string _name)
        {
            name = _name;
        }

        public override void Use(User u)
        {
            Console.WriteLine("网站类型：" + name + "用户ID：" + u.UserId + "用户名" + u.UserName);
        }
    }
    /// <summary>
    /// 享元模式
    /// </summary>
   public  class WebSiteFactory
    {
       private Dictionary<string, WebSite> list = new Dictionary<string, WebSite>();

       public WebSite GetWebSiteCategory(string key)
       {
           if (!list.ContainsKey(key))
               list.Add(key, new CreateWebSite(key));
           return (WebSite)list[key];
       }

       public int SiteCount
       {
           get
           { return list.Count; }
       }

    }
}
