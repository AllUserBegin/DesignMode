using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
    //http://www.cnblogs.com/lori/p/3953879.html
    //何时能用到它?
    //1、客户只需要使用某个复杂系统的子集，或者需要以一种特殊的方式与系统交互时，使用门面模式。
    //2、当需要跟踪原系统的使用情况时 ，使用门面模面模式。因为所有对系统的访问都经过FACADE,所以可以很容易地监视系统的使用 。
    //3、希望封装和隐藏原系统时。
    //4、编写新类的成本小于所有人使用和维护原系统使用所需的成本时

    #region 门面
    public interface IFacade
    {
        void Implement();
    }
    public class FacadeFactory
    {
        int _subtype;
        public FacadeFactory()
            : this(1)
        {

        }
        public FacadeFactory(int subType)
        {
            _subtype = subType;
        }
        public void Action()
        {
            //情况1,子类型的组合
            new Sub1().Implement();
            new Sub2().Implement();

            //情况2,子类型的选择
            switch (_subtype)
            {
                case 1:
                    new Sub1().Implement();
                    break;
                case 2:
                    new Sub2().Implement();
                    break;
                default:
                    throw new ArgumentException("子系统参数有误");
            }
        }
    }
    internal class Sub1 : IFacade
    {

        public void Implement()
        {
            Console.WriteLine("这是子系统1");
        }
    }
    internal class Sub2 : IFacade
    {

        public void Implement()
        {
            Console.WriteLine("这是子系统2");
        }
    }
    #endregion
}
