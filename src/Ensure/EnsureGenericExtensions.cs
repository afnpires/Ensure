namespace Ensure
{
    using System;

    public static class EnsureGenericExtensions
    {
        /// <summary>
        ///     Throws a <seealso cref="ArgumentNullException"/> with <paramref name="name"/> as argument,
        /// if the <paramref name="value"/> is null.
        ///     <para />
        ///     If no <paramref name="name"/> is passed, the nameof <paramref name="value"/> is assumed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">
        ///     The value to be verified.
        /// </param>
        /// <param name="name">
        ///     The name that will be passed as argument of the <see cref="ArgumentNullException"/> being thrown.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     Throws when <paramref name="value"/> is null.
        /// </exception>
        public static void EnsureNotNull<T>(this T value, string name = null)
            where T : class
        {
            if (value is null)
            {
                throw new ArgumentNullException(name ?? nameof(value));
            }
        }

        /// <summary>
        ///     Throws a <seealso cref="ArgumentException"/> with <paramref name="message"/> as argument,
        /// if the <paramref name="validator"/> function returns false.
        /// </summary>
        /// <param name="value">
        ///     The value to be verified.
        /// </param>
        /// <param name="validator">
        ///     The function that will perform the <paramref name="value"/> validation.
        /// </param>
        /// <param name="message">
        ///     The message that will be passed as argument to the <seealso cref="ArgumentException"/> being thrown.
        /// </param>
        /// <exception cref="ArgumentException">
        ///     Throws when the <paramref name="validator"/> function returns false.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     Throws when <paramref name="validator"/> is null or <paramref name="message"/> is null or empty.
        /// </exception>
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
