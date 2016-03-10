using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
    //模版方法模式的应用场景
    //1、多个类区别在于主流程中的某个细节
    //2、客户可以自已实现模版里的抽象方法
    //3、对客户隐藏具体的实现流程（方法的组合的顺序）

    /// <summary>
    /// 模版核心类
    /// </summary>
    abstract class OrderGenerator
    {
        /// <summary>
        /// 核心处理流程
        /// </summary>
        public void Excute()
        {
            InsertData();
            ProcessException();
            InsertLog();
        }
        void InsertData()
        {
            Console.WriteLine("写数据对外面隐藏");
        }
        void InsertLog()
        {
            Console.WriteLine("写日志对外面隐藏");
        }
        /// <summary>
        /// 异常处理逻辑，对外面开放，可以自己建立自己的异常规范
        /// </summary>
        protected abstract void ProcessException();
    }

    /// <summary>
    /// b2c项目业务处理方法
    /// </summary>
    class B2COrderGenerator : OrderGenerator
    {
        protected override void ProcessException()
        {
            Console.WriteLine("b2c项目中订单的异常处理方式");
        }
    }
    /// <summary>
    /// c2c项目业务处理方法
    /// </summary>
    class C2COrderGenerator : OrderGenerator
    {
        protected override void ProcessException()
        {
            Console.WriteLine("c2c项目中订单的异常处理方法");
        }
    }
}
