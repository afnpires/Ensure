// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "Namespace", Target = "~M:Ensure.EnsureGenericExtensionsTests.Ensure_WithFailingCondition_ThrowsArgumentException")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureGenericExtensionsTests.Ensure_WithMissingParameters_ThrowsArgumentNullExceptio(System.Object,System.String,System.String)")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureStringExtensionsTests.EnsureNotNullOrEmpty_WithInvalidString_ThrowsArgumentNullException(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureStringExtensionsTests.EnsureNotNullOrEmpty_WithValidString_DoesNothing")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureStringExtensionsTests.EnsureNotNullOrWhitespace_WithInvalidString_ThrowsArgumentNullException(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureStringExtensionsTests.EnsureNotNullOrWhitespace_WithValidString_DoesNothing")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureGenericExtensionsTests.EnsureNotNull_WithNullArgument_ThrowsArgumentNullException(System.String,System.String)")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureGenericExtensionsTests.Ensure_WithNullValidator_ThrowsArgumentNullException")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureGenericExtensionsTests.Ensure_WithPassingCondition_DoesNothing")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method", Scope = "member", Target = "~M:Ensure.EnsureGenericExtensionsTests.EnsureNotNull_WithInstanceArgument_DoesNothing")]
