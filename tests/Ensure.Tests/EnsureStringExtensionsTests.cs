namespace Ensure
{
    using System;
    using FluentAssertions;
    using Xunit;

    public static class EnsureStringExtensionsTests
    {
        [Theory]
        [InlineData(null, null, "value")]
        [InlineData("", null, "value")]
        [InlineData(null, "test", "test")]
        public static void EnsureNotNullOrEmpty_WithInvalidString_ThrowsArgumentNullException(string target, string targetName, string expected)
        {
            Action testCall = () => target.EnsureNotNullOrEmpty(targetName);

            testCall.ShouldThrowArgumentNullException(expected);
        }

        [Fact]
        public static void EnsureNotNullOrEmpty_WithValidString_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.EnsureNotNullOrEmpty();

            testCall.Should().NotThrow<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null, null, "value")]
        [InlineData("", null, "value")]
        [InlineData(" ", null, "value")]
        [InlineData(null, "test", "test")]
        public static void EnsureNotNullOrWhitespace_WithInvalidString_ThrowsArgumentNullException(string target, string targetName, string expected)
        {
            Action testCall = () => target.EnsureNotNullOrWhitespace(targetName);

            testCall.ShouldThrowArgumentNullException(expected);
        }

        [Fact]
        public static void EnsureNotNullOrWhitespace_WithValidString_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.EnsureNotNullOrWhitespace();

            testCall.Should().NotThrow<ArgumentNullException>();
        }
    }
}
