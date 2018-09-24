namespace System
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }

        public override DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}