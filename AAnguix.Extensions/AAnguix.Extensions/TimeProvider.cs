namespace System
{
    /// <summary>
    /// Implementation of an static time provider whose implementation can be replaced for testing purposes.
    /// </summary>
    public abstract class TimeProvider
    {
        private static TimeProvider _current;

        static TimeProvider()
        {
            _current = new DefaultTimeProvider();
        }

        public static TimeProvider Current
        {
            get { return _current; }
            set
            {
                _current = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public abstract DateTime UtcNow { get; }

        public abstract DateTime Now { get; }

        public static void ResetToDefault()
        {
            _current = new DefaultTimeProvider();
        }
    }
}