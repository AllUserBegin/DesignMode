using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
   
#region 猫大叫一声，所有的老鼠都开始逃跑，主人被惊醒,主人到底是被猫吵醒还是被老鼠吵醒啊

    /*
     * 利用事件和委托来实现Observer模式我认为更加的简单和优雅
     * 效果及实现要点
　　1．使用面向对象的抽象，Observer模式使得我们可以独立地改变目标与观察者，从而使二者之间的依赖关系达到松耦合。
　　2．目标发送通知时，无需指定观察者，通知（可以携带通知信息作为参数）会自动传播。观察者自己决定是否需要订阅通知。目标对象对此一无所知。
　　3．在C#中的Event。委托充当了抽象的Observer接口，而提供事件的对象充当了目标对象，委托是比抽象Observer接口更为松耦合的设计。
　　适用性
　　1．当一个抽象模型有两个方面, 其中一个方面依赖于另一方面。将这二者封装在独立的对象中以使它们可以各自独立地改变和复用。
　　2．当对一个对象的改变需要同时改变其它对象, 而不知道具体有多少对象有待改变。
　　3．当一个对象必须通知其它对象，而它又不能假定其它对象是谁。换言之, 你不希望这些对象是紧密耦合的。
　　总结
　　通过Observer模式，把一对多对象之间的通知依赖关系的变得更为松散，大大地提高了程序的可维护性和可扩展性，也很好的符合了开放-封闭原则。
    
     推模式，拉模式 http://kb.cnblogs.com/page/49989/
     * * */

    public delegate void SubjectEventHandler();
    public abstract class Anmial
    {
        public event SubjectEventHandler baseEvent;

        public void Raise()
        {
            if(baseEvent!=null)
                baseEvent();
        }
        
    }

    public class Cat:Anmial
    {
        public void Cry()
        {
           Console.WriteLine("Cry");
            base.Raise();
        }     
    }
    public abstract class Observer
    {
        public Observer(Anmial am)
        {
            am.baseEvent += new SubjectEventHandler(Response);
        }
        public abstract void Response();
    }

    public class People : Observer
    {
        public People(Anmial a):base(a)
        {
 
        }
        public override void Response()
        {
            Console.WriteLine("主人被惊醒");
        }
    }

    public class Mouse : Observer
    {
        string name = string.Empty;
        public Mouse(string mouseName, Anmial a)
            : base(a)
        {
            name = mouseName;
        }
        public override void Response()
        {
            Console.WriteLine(string.Format("{0}开始逃跑",name));
        }
    }

#endregion
     
}
