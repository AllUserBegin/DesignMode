using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
    /// <summary>
    /// 状态模式
    /// 每个对象都有其对应的状态，而每个状态又对应一些相应的行为，如果某个对象有多个状态时，
    /// 那么就会对应很多的行为。那么对这些状态的判断和根据状态完成的行为，就会导致多重条件语句，
    /// 并且如果添加一种新的状态时，需要更改之前现有的代码。这样的设计显然违背了开闭原则。
    /// 状态模式正是用来解决这样的问题的。状态模式将每种状态对应的行为抽象出来成为单独新的对象，
    /// 这样状态的变化不再依赖于对象内部的行为。
    /// </summary>
    public class WorkProgram
    {
        public States state=null;
        public WorkProgram()
        {
            state = new ForenoonState();
        }
        double hour=0;
        public double Hour
        {
            get { return hour; }
            set { this.hour = value; }
        }

        bool isCompleteWork = false;
        public bool IsCompleteWork
        {
            get { return isCompleteWork; }
            set { this.isCompleteWork = value; }
        }


        public void SetState(States s)
        {
            state = s;
        }

        public void WriteProgram()
        {
            state.WordProgram(this);
        }

    }

    public abstract class States
    {
        public abstract void WordProgram(WorkProgram w);
    }
    /// <summary>
    /// 上午
    /// </summary>
    public class ForenoonState : States
    {
        public override void WordProgram(WorkProgram w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间：{0}点，上午工作，精神百倍", w.Hour);
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            } 
        }
 
    }
    /// <summary>
    /// 中午
    /// </summary>
    public class NoonState : States
    {
        public override void WordProgram(WorkProgram w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间：{0}点", w.Hour);
            }            
        }
    }
}
