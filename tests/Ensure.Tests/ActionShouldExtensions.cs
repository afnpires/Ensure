namespace Ensure
{
    using System;
    using FluentAssertions;

    internal static class ActionShouldExtensions
    {
        internal static void ShouldThrowArgumentNullException(this Action testCall, string nullFieldName)
        {
            var expectedMessage = $"Value cannot be null.\nParameter name: {nullFieldName}";
            testCall.Should().ThrowExactly<ArgumentNullException>().WithMessage(expectedMessage);
        }
    }
}
