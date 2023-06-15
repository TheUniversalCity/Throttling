using System.Collections.Concurrent;

namespace TheUniversalCity.Throttling
{
    internal class ThrottleManagerObject : IThrottleManager
    {
        public ConcurrentDictionary<int, ConcurrentDictionary<int, long>> RequestDatetimeTickList { get; set; } = new ConcurrentDictionary<int, ConcurrentDictionary<int, long>>();
        public int LoginThresholdInterval { get; set; }
        public int LoginThresholdCount { get; set; }

        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount)
        {
            this.LoginThresholdCount = loginThresholdCount;
            this.LoginThresholdInterval = loginThresholdInterval;
        }

        protected bool IsThrottle(int hashCode, int hasCode2)
        {
            var requestDatetimeTickList = RequestDatetimeTickList.GetOrAdd(hashCode, new ConcurrentDictionary<int, long>());

            lock (requestDatetimeTickList)
            {
                var now = DateTime.Now.Ticks;
                var tmpFirst = default(KeyValuePair<int, long>);

                while (requestDatetimeTickList.Any() && (now - (tmpFirst = requestDatetimeTickList.OrderBy(c => c.Value).First()).Value) / 10000.0 >= LoginThresholdInterval)
                {
                    requestDatetimeTickList.TryRemove(tmpFirst.Key, out _);
                }

                var isBlocked = !requestDatetimeTickList.ContainsKey(hasCode2) && requestDatetimeTickList.Count >= LoginThresholdCount;

                if (!isBlocked)
                {
                    requestDatetimeTickList.GetOrAdd(hasCode2, now);
                }

                return isBlocked;
            }
        }

        public bool IsThrottle()
        {
            return this.IsThrottle(0, Guid.NewGuid().GetHashCode());
        }

        public void Reset()
        {
            lock (RequestDatetimeTickList)
            {
                RequestDatetimeTickList.Clear();
            }
        }
    }


    internal class ThrottleManagerObject<T> : ThrottleManagerObject, IThrottleManager<T>
    {
        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount) : base(loginThresholdInterval, loginThresholdCount)
        {
        }

        public bool IsThrottle(T param1, int? hashCode2 = null)
        {
            return base.IsThrottle(param1.GetHashCode(), hashCode2 ?? Guid.NewGuid().GetHashCode());
        }
    }

    internal class ThrottleManagerObject<T1, T2> : ThrottleManagerObject, IThrottleManager<T1, T2>
    {
        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount) : base(loginThresholdInterval, loginThresholdCount)
        {
        }

        public bool IsThrottle(T1 param1, T2 param2, int? hashCode2 = null)
        {
            var hashCode = ThrottleManagerObjectBuilder.CombineHashCodes(
                param1.GetHashCode(),
                param2.GetHashCode()
                );
            return base.IsThrottle(hashCode, hashCode2 ?? Guid.NewGuid().GetHashCode());
        }
    }

    internal class ThrottleManagerObject<T1, T2, T3> : ThrottleManagerObject, IThrottleManager<T1, T2, T3>
    {
        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount) : base(loginThresholdInterval, loginThresholdCount)
        {
        }

        public bool IsThrottle(T1 param1, T2 param2, T3 param3, int? hashCode2 = null)
        {
            var hashCode = ThrottleManagerObjectBuilder.CombineHashCodes(
                param1.GetHashCode(),
                param2.GetHashCode(),
                param3.GetHashCode()
                );
            return base.IsThrottle(hashCode, hashCode2 ?? Guid.NewGuid().GetHashCode());
        }
    }

    internal class ThrottleManagerObject<T1, T2, T3, T4> : ThrottleManagerObject, IThrottleManager<T1, T2, T3, T4>
    {
        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount) : base(loginThresholdInterval, loginThresholdCount)
        {
        }

        public bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, int? hashCode2 = null)
        {
            var hashCode = ThrottleManagerObjectBuilder.CombineHashCodes(
                param1.GetHashCode(),
                param2.GetHashCode(),
                param3.GetHashCode(),
                param4.GetHashCode()
                );
            return base.IsThrottle(hashCode, hashCode2 ?? Guid.NewGuid().GetHashCode());
        }
    }

    internal class ThrottleManagerObject<T1, T2, T3, T4, T5> : ThrottleManagerObject, IThrottleManager<T1, T2, T3, T4, T5>
    {
        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount) : base(loginThresholdInterval, loginThresholdCount)
        {
        }

        public bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, int? hashCode2 = null)
        {
            var hashCode = ThrottleManagerObjectBuilder.CombineHashCodes(
                param1.GetHashCode(),
                param2.GetHashCode(),
                param3.GetHashCode(),
                param4.GetHashCode(),
                param5.GetHashCode()
                );
            return base.IsThrottle(hashCode, hashCode2 ?? Guid.NewGuid().GetHashCode());
        }
    }

    internal class ThrottleManagerObject<T1, T2, T3, T4, T5, T6> : ThrottleManagerObject, IThrottleManager<T1, T2, T3, T4, T5, T6>
    {
        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount) : base(loginThresholdInterval, loginThresholdCount)
        {
        }

        public bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, int? hashCode2 = null)
        {
            var hashCode = ThrottleManagerObjectBuilder.CombineHashCodes(
                param1.GetHashCode(),
                param2.GetHashCode(),
                param3.GetHashCode(),
                param4.GetHashCode(),
                param5.GetHashCode(),
                param2.GetHashCode()
                );
            return base.IsThrottle(hashCode, hashCode2 ?? Guid.NewGuid().GetHashCode());
        }
    }

    internal class ThrottleManagerObject<T1, T2, T3, T4, T5, T6, T7> : ThrottleManagerObject, IThrottleManager<T1, T2, T3, T4, T5, T6, T7>
    {
        public ThrottleManagerObject(int loginThresholdInterval, int loginThresholdCount) : base(loginThresholdInterval, loginThresholdCount)
        {
        }

        public bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, int? hashCode2 = null)
        {
            var hashCode = ThrottleManagerObjectBuilder.CombineHashCodes(
                param1.GetHashCode(),
                param2.GetHashCode(),
                param3.GetHashCode(),
                param4.GetHashCode(),
                param5.GetHashCode(),
                param6.GetHashCode(),
                param7.GetHashCode()
                );
            return base.IsThrottle(hashCode, hashCode2 ?? Guid.NewGuid().GetHashCode());
        }
    }
}
