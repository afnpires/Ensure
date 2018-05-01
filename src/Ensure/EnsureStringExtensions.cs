namespace Ensure
{
    using System;

    public static class EnsureStringExtensions
    {
        public static void EnsureNotNullOrEmpty(this string value, string name = null)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(name ?? nameof(value));
            }
        }

        public static void EnsureNotNullOrWhitespace(this string value, string name = null)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(name ?? nameof(value));
            }
        }
    }
}
