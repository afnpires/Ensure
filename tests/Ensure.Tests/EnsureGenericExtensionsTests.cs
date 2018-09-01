namespace Ensure
{
    using System;
    using FluentAssertions;
    using Xunit;

    public static class EnsureGenericExtensionsTests
    {
        [Fact]
        public static void Ensure_WithFailingCondition_ThrowsArgumentException()
        {
            const string target = "a";
            const string exceptionMessage = "exception message";

            Action testCall = () => target.Ensure(_ => false, exceptionMessage);

            testCall.Should().ThrowExactly<ArgumentException>().WithMessage(exceptionMessage);
        }

        [Theory]
        [InlineData(null, null, "message")]
        [InlineData("a", null, "message")]
        [InlineData(10, null, "message")]
        public static void Ensure_WithMissingParameters_ThrowsArgumentNullExceptio(object target, string message, string expected)
        {
            Action testCall = () => target.Ensure(_ => false, message);

            testCall.ShouldThrowArgumentNullException(expected);
        }

        [Fact]
        public static void Ensure_WithNullValidator_ThrowsArgumentNullException()
        {
            Action testCall = () => "a".Ensure(null, null);

            testCall.ShouldThrowArgumentNullException("validator");
        }

        [Fact]
        public static void Ensure_WithPassingCondition_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.Ensure(_ => true, "test");

            testCall.Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public static void EnsureNotNull_WithInstanceArgument_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.EnsureNotNull();

            testCall.Should().NotThrow<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null, "value")]
        [InlineData("test", "test")]
        public static void EnsureNotNull_WithNullArgument_ThrowsArgumentNullException(string name, string expected)
        {
            const object target = null;

            Action testCall = () => target.EnsureNotNull(name);

            testCall.ShouldThrowArgumentNullException(expected);
        }
    }
}
