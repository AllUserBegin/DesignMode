using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode.Fuse
{
    public class ClosedState : CircuitBreakerState
    {
        public ClosedState(CircuitBreaker circuitBreaker)
            : base(circuitBreaker)
        {
            //重置失败计数器
            circuitBreaker.ResetFailureCount();
        }

        public override void ActUponException(Exception e)
        {
            base.ActUponException(e);
            //如果失败次数达到阈值，则切换到断开状态
            if (circuitBreaker.FailureThresholdReached())
            {
                circuitBreaker.MoveToOpenState();
            }
        }
    }
}
