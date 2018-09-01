namespace Ensure
{
    using System;

    public static class EnsureStringExtensions
    {
        /// <summary>
        ///     Throws a <seealso cref="ArgumentNullException"/> if <paramref name="value"/> is null or empty.
        /// </summary>
        /// <param name="value">
        ///     The value to be verified.
        /// </param>
        /// <param name="name">
        ///     The name that will be passed as argument of the <see cref="ArgumentNullException"/> being thrown.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     Throws when <paramref name="name"/> is null or empty.
        /// </exception>
        public static void EnsureNotNullOrEmpty(this string value, string name = null)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(name ?? nameof(value));
            }
        }

        /// <summary>
        ///     Throws a <seealso cref="ArgumentNullException"/> if <paramref name="value"/> is null, empty, or whitespace.
        /// </summary>
        /// <param name="value">
        ///     The value to be verified.
        /// </param>
        /// <param name="name">
        ///     The name that will be passed as argument of the <see cref="ArgumentNullException"/> being thrown.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     Throws when <paramref name="value"/> is null, empty or whitespace.
        /// </exception>
        public static void EnsureNotNullOrWhitespace(this string value, string name = null)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(name ?? nameof(value));
            }
        }
    }
}
