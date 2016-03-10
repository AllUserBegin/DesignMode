using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    public  class Operation
    {
        public  double valueA;
        public  double valueB;

        public virtual double GetResult()
        {
            double result = 0.0;
            return result;        
        }
    }

    public class OperationAdd:Operation
    {
        public override double GetResult()
        {
            return valueA + valueB;
        }
    }
    public class OperationSubtraction : Operation
    {
        public override double GetResult()
        {
            return valueA - valueB;
        }
    }

    public class OperationMultiplication : Operation
    {
        public override double GetResult()
        {
            return valueA * valueB;
        }
    }

    public class OperationDivision : Operation
    {
        public override double GetResult()
        {
            if (valueB == 0)
                throw new Exception("被除数不能等于0");
            return valueA / valueB;
        }
    }


    public static class SimpleFactory
    {
        /// <summary>
       /// 加
       /// </summary>
       private const string Add = "+";
       /// <summary>
       /// 减
       /// </summary>
       private const string Sub = "-";
       /// <summary>
       /// 乘
       /// </summary>
       private const string Mul = "*";
       /// <summary>
       /// 除
       /// </summary>
       private const string Div = "/";

       public static Operation GetOperation(string operationType)
        {          
            Operation oper=null;
            switch(operationType)
            {
                case Add:
                    oper = new OperationAdd(); 
                    break;
                case Sub:
                    oper = new OperationSubtraction();
                    break;
                case Mul:
                    oper = new OperationMultiplication();
                    break;
                case Div:
                    oper = new OperationDivision();
                    break;
                default:
                    throw new Exception("超出计算表达式范围！");
            }
            return oper;
        }
    }
}
