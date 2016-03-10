using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode
{
    #region 适配器模式
    public class Csharp
    {
        public virtual int Respose(int valueA,int valueB)
        {
            Console.WriteLine(valueA+valueB);
            return valueA + valueB;
        }
    }

    public class Adapter : Csharp
    {
        Java ad = new Java();

        public override int Respose(int valueA, int valueB)
        {
            int result = base.Respose(valueA, valueB);
            return  ad.SpecRespose(valueA, valueB);
        }
    }

    public class Java
    {
        public int SpecRespose(int valueA, int valueB)
        {
            Console.WriteLine(valueA*2 + valueB);
            return valueA*2 + valueB;
        }
    }

    #endregion


}
