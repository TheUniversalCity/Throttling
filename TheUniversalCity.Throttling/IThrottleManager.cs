namespace TheUniversalCity.Throttling
{
    public interface IThrottleManager
    {
        bool IsThrottle();
        void Reset();
    }

    public interface IThrottleManager<in T>
    {
        bool IsThrottle(T param1, int? hashCode = null);
        void Reset();
    }

    public interface IThrottleManager<in T1, in T2>
    {
        bool IsThrottle(T1 param1, T2 param2, int? hashCode = null);
        void Reset();
    }

    public interface IThrottleManager<in T1, in T2, in T3>
    {
        bool IsThrottle(T1 param1, T2 param2, T3 param3, int? hashCode = null);
        void Reset();
    }

    public interface IThrottleManager<in T1, in T2, in T3, in T4>
    {
        bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, int? hashCode = null);
        void Reset();
    }

    public interface IThrottleManager<in T1, in T2, in T3, in T4, in T5>
    {
        bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, int? hashCode = null);
        void Reset();
    }

    public interface IThrottleManager<in T1, in T2, in T3, in T4, in T5, in T6>
    {
        bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, int? hashCode = null);
        void Reset();
    }

    public interface IThrottleManager<in T1, in T2, in T3, in T4, in T5, in T6, in T7>
    {
        bool IsThrottle(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, int? hashCode = null);
        void Reset();
    }
}
