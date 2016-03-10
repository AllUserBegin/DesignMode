using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
    #region
    /// <summary>
    /// 命令模式
    /// </summary>
    #endregion
    

    //命令接口
    public abstract  class Command
    {
        protected Receiver receiver;

        public Command(Receiver receive)
        {
            receiver = receive;
        }

        abstract public void Execute();
    }

    /// <summary>
    /// 实现接口
    /// </summary>
    public class ConcertCommand : Command
    {
        public ConcertCommand(Receiver r)
            : base(r)
        {
 
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }

    /// <summary>
    /// 接收者
    /// </summary>
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求！");
        }
    }
    /// <summary>
    /// 服务员
    /// </summary>
    public class Waiter
    {
        public List<Command> list = new List<Command>();

        public void SetOrder(Command com)
        {
            list.Add(com);
        }

        public void ExcuteCommand()
        {
            foreach(Command c in list)
            {
                c.Execute();
            }
        }

    }


  
}
