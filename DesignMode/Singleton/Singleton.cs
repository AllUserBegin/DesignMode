using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
    /// <summary>
    /// 单例模式
    /// </summary>
   public class Singleton
    {
        public static object locked = new object();
        public static  Singleton intance=null;

        public static Singleton GetIntance()
        {
            if (intance == null)
            {
                lock (locked)
                {
                    if (intance == null)
                    {
                        intance = new Singleton();
                    }
                }
            }
            return intance;
        }
   }

   public class SingletonStatic
   {
       
       public static SingletonStatic intance = null;
       public SingletonStatic()
       {       }
       public SingletonStatic GetIntance()
       {
           if (intance == null)
               intance = new SingletonStatic();
           return intance;
       }
   }

   public class SingletonEx
   {
       //在自己内部定义自己的一个实例，只供内部调用
       public static SingletonEx intance = new SingletonEx();

       public SingletonEx()
       { }
       //这里提供了一个供外部访问本class的静态方法，可以直接访问
       public static SingletonEx GetIntance()
       {
           return intance;
       }
   }


   public class SingletonSync
   {
       private static SingletonSync intance = null;
       public SingletonSync()
       { }

       public static SingletonSync GetIntance()
       {
           if (intance == null)
           {
              
           }

           return intance;
       }
   }
}
