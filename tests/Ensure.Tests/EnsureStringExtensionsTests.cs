using FluentAssertions;
using System;
using Xunit;

namespace Ensure
{
    public class EnsureStringExtensionsTests
    {
        [Fact]
        public void EnsureNotNullOrEmpty_WithValidString_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.EnsureNotNullOrEmpty();

            testCall.Should().NotThrow<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null, null, "value")]
        [InlineData("", null, "value")]
        [InlineData(null, "test", "test")]
        public void EnsureNotNullOrEmpty_WithInvalidString_ThrowsArgumentNullException(string target, string targetName, string expected)
        {
            Action testCall = () => target.EnsureNotNullOrEmpty(targetName);

            testCall.ShouldThrowArgumentNullException(expected);
        }

        [Fact]
        public void EnsureNotNullOrWhitespace_WithValidString_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.EnsureNotNullOrWhitespace();

            testCall.Should().NotThrow<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null, null, "value")]
        [InlineData("", null, "value")]
        [InlineData(" ", null, "value")]
        [InlineData(null, "test", "test")]
        public void EnsureNotNullOrWhitespace_WithInvalidString_ThrowsArgumentNullException(string target, string targetName, string expected)
        {
            Action testCall = () => target.EnsureNotNullOrWhitespace(targetName);

            testCall.ShouldThrowArgumentNullException(expected);
        }
    }
}
