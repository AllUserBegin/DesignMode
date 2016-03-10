using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{

    /*
     组成
     * —抽象策略角色： 策略类，通常由一个接口或者抽象类实现。
     * —具体策略角色：包装了相关的算法和行为。
     * —环境角色：持有一个策略类的引用，最终给客户端调用。
     * 
      策略模式的应用场景
     1、 多个类只区别在表现行为不同，可以使用Strategy模式，在运行时动态选择具体要执行的行为。
     2、 需要在不同情况下使用不同的策略(算法)，一般会定义一个接口规范，使用不同的策略方式去实现它
     3、 对客户隐藏具体策略(算法)的实现细节，彼此完全独立。


    2概念

策略模式定义了一系列的算法，并将每一个算法封装起来，而且使它们还可以相互替换。策略模式让算法独立于使用它的客户而独立变化。（原文：The Strategy Pattern defines a family of algorithms,encapsulates each one,and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.）
Context(应用场景):
1、需要使用ConcreteStrategy提供的算法。
2、 内部维护一个Strategy的实例。
3、 负责动态设置运行时Strategy具体的实现算法。
4、负责跟Strategy之间的交互和数据传递。
Strategy(抽象策略类)：
1、 定义了一个公共接口，各种不同的算法以不同的方式实现这个接口，Context使用这个接口调用不同的算法，一般使用接口或抽象类实现。
ConcreteStrategy(具体策略类)：
2、 实现了Strategy定义的接口，提供具体的算法实现。
3应用场景

应用场景：
1、 多个类只区别在表现行为不同，可以使用Strategy模式，在运行时动态选择具体要执行的行为。
2、 需要在不同情况下使用不同的策略(算法)，或者策略还可能在未来用其它方式来实现。
3、 对客户隐藏具体策略(算法)的实现细节，彼此完全独立。
4优缺点

优点：
1、 策略模式提供了管理相关的算法族的办法。策略类的等级结构定义了一个算法或行为族。恰当使用继承可以把公共的代码转移到父类里面，从而避免重复的代码。
2、 策略模式提供了可以替换继承关系的办法。继承可以处理多种算法或行为。如果不是用策略模式，那么使用算法或行为的环境类就可能会有一些子类，每一个子类提供一个不同的算法或行为。但是，这样一来算法或行为的使用者就和算法或行为本身混在一起。决定使用哪一种算法或采取哪一种行为的逻辑就和算法或行为的逻辑混合在一起，从而不可能再独立演化。继承使得动态改变算法或行为变得不可能。
3、 使用策略模式可以避免使用多重条件转移语句。多重转移语句不易维护，它把采取哪一种算法或采取哪一种行为的逻辑与算法或行为的逻辑混合在一起，统统列在一个多重转移语句里面，比使用继承的办法还要原始和落后。
缺点：
1、客户端必须知道所有的策略类，并自行决定使用哪一个策略类。这就意味着客户端必须理解这些算法的区别，以便适时选择恰当的算法类。换言之，策略模式只适用于客户端知道所有的算法或行为的情况。
2、 策略模式造成很多的策略类，每个具体策略类都会产生一个新类。有时候可以通过把依赖于环境的状态保存到客户端里面，而将策略类设计成可共享的，这样策略类实例可以被不同客户端使用。换言之，可以使用享元模式来减少对象的数量。
 */

    /// <summary>
    /// 策略模式
    /// </summary>
    public abstract class CashSuper
    {
        public abstract decimal GetResult(decimal money);

        /// <summary>
        /// 返回优惠的金额
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public abstract decimal GetCouponResult(decimal money);
    }

    /// <summary>
    /// 正常收费
    /// </summary>
    public class CashNormal : CashSuper
    {
        public override decimal GetResult(decimal money)
        {
           return money;
        }

        public override decimal GetCouponResult(decimal money)
        {
            return 0;
        }     
    }

    /// <summary>
    /// 打折促销
    /// </summary>
    public class CashRebate : CashSuper
    {
        private decimal myRebate = 1m;
        public CashRebate(decimal _rebate)
        {
            myRebate = _rebate;
        }

        public override decimal GetResult(decimal money)
        {
            return money * myRebate;
        }

        public override decimal GetCouponResult(decimal money)
        {
            return money * (1m - myRebate);
        }     
    }

    /// <summary>
    /// 满多少送多少
    /// </summary>
    public class CashReturn : CashSuper
    {
        public decimal moneyCondition = 0.0m;
        public decimal moneyReturn = 0.0m;

        public CashReturn(string _condition,string _return)
        {
           moneyCondition=decimal.Parse(_condition);
           moneyReturn = decimal.Parse(_return);
        }

        public override decimal GetResult(decimal money)
        {
            decimal result=money;
            if(money>=moneyCondition)
            {
                result -= moneyReturn; //moneyCondition - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }

        public override decimal GetCouponResult(decimal money)
        {
            if (money >= moneyCondition)
            {
                return moneyReturn;
            }
            return 0;
        }    
    }

    public class CashFactory
    {
        CashSuper cashSuper = null;
        public  CashFactory(CashSuper cs)
        {
            cashSuper = cs;
        }

        public decimal GetResult(decimal money)
        {
            return cashSuper.GetResult(money);
        }

        public  decimal GetCouponResult(decimal money)
        {
            return cashSuper.GetCouponResult(money);
        }    
    }


    
}
