using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignMode.Fuse
{
    public class CircuitBreaker
    {
        public CircuitBreaker(int failedthreshold, int consecutiveSuccessThreshold, TimeSpan timeout)
        {
            if (failedthreshold < 1 || consecutiveSuccessThreshold < 1)
            {
                throw new ArgumentOutOfRangeException("threshold", "Threshold should be greater than 0");
            }

            if (timeout.TotalMilliseconds < 1)
            {
                throw new ArgumentOutOfRangeException("timeout", "Timeout should be greater than 0");
            }

            FailureThreshold = failedthreshold;
            ConsecutiveSuccessThreshold = consecutiveSuccessThreshold;
            Timeout = timeout;
            MoveToClosedState();
        }

        private readonly object monitor = new object();
        private CircuitBreakerState state;
        public int FailureCount { get; private set; }
        public int ConsecutiveSuccessCount { get; private set; }
        public int FailureThreshold { get; private set; }
        public int ConsecutiveSuccessThreshold { get; private set; }
        public TimeSpan Timeout { get; private set; }
        public Exception LastException { get; private set; }

        public bool IsClosed
        {
            get { return state is ClosedState; }
        }

        public bool IsOpen
        {
            get { return state is OpenState; }
        }

        public bool IsHalfOpen
        {
            get { return state is HalfOpenState; }
        }

        internal void MoveToClosedState()
        {
            state = new ClosedState(this);
        }

        internal void MoveToOpenState()
        {
            state = new OpenState(this);
        }

        internal void MoveToHalfOpenState()
        {
            state = new HalfOpenState(this);
        }

        internal void IncreaseFailureCount(Exception ex)
        {
            LastException = ex;
            FailureCount++;
        }

        internal void ResetFailureCount()
        {
            FailureCount = 0;
        }

        internal bool FailureThresholdReached()
        {
            return FailureCount >= FailureThreshold;
        }

        internal void IncreaseSuccessCount()
        {
            ConsecutiveSuccessCount++;
        }

        internal void ResetConsecutiveSuccessCount()
        {
            ConsecutiveSuccessCount = 0;
        }

        internal bool ConsecutiveSuccessThresholdReached()
        {
            return ConsecutiveSuccessCount >= ConsecutiveSuccessThreshold;
        }

    }
}
