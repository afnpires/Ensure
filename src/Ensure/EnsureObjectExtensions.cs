namespace Ensure
{
    using System;

    public static class EnsureObjectExtensions
    {
        public static void EnsureNotNull(this object value, string name = null)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name ?? nameof(value));
            }
        }

        public static void Ensure<T>(this T value, Func<T, bool> validator, string message)
        {
            value.EnsureNotNull(nameof(value));
            validator.EnsureNotNull(nameof(validator));
            message.EnsureNotNullOrEmpty(nameof(message));

            if (!validator(value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
