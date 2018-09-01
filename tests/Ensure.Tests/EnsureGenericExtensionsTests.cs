namespace Ensure
{
    using FluentAssertions;
    using System;
    using Xunit;

    public class EnsureGenericExtensionsTests
    {
        [Theory]
        [InlineData(null, "value")]
        [InlineData("test", "test")]
        public void EnsureNotNull_WithNullArgument_ThrowsArgumentNullException(string name, string expected)
        {
            const object target = null;

            Action testCall = () => target.EnsureNotNull(name);

            testCall.ShouldThrowArgumentNullException(expected);
        }

        [Fact]
        public void EnsureNotNull_WithInstanceArgument_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.EnsureNotNull();

            testCall.Should().NotThrow<ArgumentNullException>();
        }

        [Fact]
        public void Ensure_WithFailingCondition_ThrowsArgumentException()
        {
            const string target = "a";
            const string exceptionMessage = "exception message";

            Action testCall = () => target.Ensure(s => false, exceptionMessage);

            testCall.Should().ThrowExactly<ArgumentException>().WithMessage(exceptionMessage);
        }

        [Fact]
        public void Ensure_WithPassingCondition_DoesNothing()
        {
            const string target = "a";

            Action testCall = () => target.Ensure(s => true, "test");

            testCall.Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public void Ensure_WithNullValidator_ThrowsArgumentNullException()
        {
            Action testCall = () => "a".Ensure(null, null);

            testCall.ShouldThrowArgumentNullException("validator");
        }

        [Theory]
        [InlineData(null, null, "message")]
        [InlineData("a", null, "message")]
        [InlineData(10, null, "message")]
        public void Ensure_WithMissingParameters_ThrowsArgumentNullExceptio(object target, string message, string expected)
        {
            Action testCall = () => target.Ensure(s => false, message);

            testCall.ShouldThrowArgumentNullException(expected);
        }
    }
}
