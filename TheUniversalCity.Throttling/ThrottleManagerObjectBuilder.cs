namespace TheUniversalCity.Throttling
{
    public static class ThrottleManagerObjectBuilder
    {
        public static IThrottleManager Create(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject(loginThresholdInterval, loginThresholdCount);
        }

        public static IThrottleManager<T> Create<T>(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject<T>(loginThresholdInterval, loginThresholdCount);
        }

        public static IThrottleManager<T1, T2> Create<T1, T2>(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject<T1, T2>(loginThresholdInterval, loginThresholdCount);
        }

        public static IThrottleManager<T1, T2, T3> Create<T1, T2, T3>(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject<T1, T2, T3>(loginThresholdInterval, loginThresholdCount);
        }

        public static IThrottleManager<T1, T2, T3, T4> Create<T1, T2, T3, T4>(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject<T1, T2, T3, T4>(loginThresholdInterval, loginThresholdCount);
        }

        public static IThrottleManager<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject<T1, T2, T3, T4, T5>(loginThresholdInterval, loginThresholdCount);
        }

        public static IThrottleManager<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject<T1, T2, T3, T4, T5, T6>(loginThresholdInterval, loginThresholdCount);
        }

        public static IThrottleManager<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(int loginThresholdInterval, int loginThresholdCount)
        {
            return new ThrottleManagerObject<T1, T2, T3, T4, T5, T6, T7>(loginThresholdInterval, loginThresholdCount);
        }

        internal static int CombineHashCodes(int h1, int h2)
        {
            // this is where the magic happens
            return (((h1 << 5) + h1) ^ h2);
        }

        internal static int CombineHashCodes(int h1, int h2, int h3)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2), h3);
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2), CombineHashCodes(h3, h4));
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), h5);
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6));
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7));
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7, h8));
        }
    }
}
