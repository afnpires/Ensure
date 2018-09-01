// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "BenchmarkTest", Scope = "member", Target = "~M:Ensure.Benchmarks.EnsureBenchmark.Ensure_Object")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "BenchmarkTest", Scope = "member", Target = "~M:Ensure.Benchmarks.EnsureBenchmark.Ensure_Struct")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "BenchmarkTest", Scope = "member", Target = "~M:Ensure.Benchmarks.EnsureBenchmark.EnsureNotNull_Object")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "BenchmarkTest", Scope = "member", Target = "~M:Ensure.Benchmarks.EnsureBenchmark.EnsureNotNull_Struct")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "BenchmarkTest", Scope = "member", Target = "~M:Ensure.Benchmarks.EnsureBenchmark.EnsureNotNullOrEmpty_String")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "BenchmarkTest", Scope = "member", Target = "~M:Ensure.Benchmarks.EnsureBenchmark.EnsureNotNullOrWhitespace_String")]

[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "Cannot be static do to being the class used to run benchmarks", Scope = "type", Target = "~T:Ensure.Benchmarks.EnsureBenchmark")]