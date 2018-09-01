namespace Ensure
{
    using System;

    public static class EnsureGenericExtensions
    {
        public static void EnsureNotNull<T>(this T value, string name = null)
            where T : class
        {
            if (value is null)
            {
                throw new ArgumentNullException(name ?? nameof(value));
            }
        }

        public static void Ensure<T>(this T value, Func<T, bool> validator, string message)
        {
            validator.EnsureNotNull(nameof(validator));
            message.EnsureNotNullOrEmpty(nameof(message));

            if (!validator(value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
