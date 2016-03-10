using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode.Fuse
{
    public class HalfOpenState : CircuitBreakerState
    {
        public HalfOpenState(CircuitBreaker circuitBreaker)
            : base(circuitBreaker)
        {
            //重置连续成功计数
            circuitBreaker.ResetConsecutiveSuccessCount();
        }

        public override void ActUponException(Exception e)
        {
            base.ActUponException(e);
            //只要有失败，立即切换到断开模式
            circuitBreaker.MoveToOpenState();
        }

        public override void ProtectedCodeHasBeenCalled()
        {
            base.ProtectedCodeHasBeenCalled();
            //如果连续成功次数达到阈值，切换到闭合状态
            if (circuitBreaker.ConsecutiveSuccessThresholdReached())
            {
                circuitBreaker.MoveToClosedState();
            }
        }
    }
}
