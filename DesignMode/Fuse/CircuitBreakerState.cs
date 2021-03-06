﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode.Fuse
{
    public abstract class CircuitBreakerState
    {
        protected CircuitBreakerState(CircuitBreaker circuitBreaker)
        {
            this.circuitBreaker = circuitBreaker;
        }

        /// <summary>
        /// 调用受保护方法之前处理的操作
        /// </summary>
        public virtual void ProtectedCodeIsAboutToBeCalled()
        {
            //如果是断开状态，直接返回
            //然后坐等超时转换到半断开状态
            if (circuitBreaker.IsOpen)
            {
                throw new OpenCircuitException();
            }
        }

        /// <summary>
        /// 受熔断器保护的方法调用成功之后的操作
        /// </summary>
        public virtual void ProtectedCodeHasBeenCalled()
        {
            circuitBreaker.IncreaseSuccessCount();
        }

        /// <summary>
        ///受熔断器保护的方法调用发生异常操作后的操作
        /// </summary>
        /// <param name="e"></param>
        public virtual void ActUponException(Exception e)
        {
            //增加失败次数计数器，并且保存错误信息
            circuitBreaker.IncreaseFailureCount(e);
            //重置连续成功次数
            circuitBreaker.ResetConsecutiveSuccessCount();
        }

        protected readonly CircuitBreaker circuitBreaker;
    }
}
