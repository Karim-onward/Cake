#load "./../utilities/xunit.cake"

//////////////////////////////////////////////////////////////////////////////

Task("Cake.Common.ArgumentAliases.HasArgument")
    .Does(() =>
{
    // Given, When
    var arg = HasArgument("customarg");

    // Then
    Assert.True(arg);
});

Task("Cake.Common.ArgumentAliases.HasArgument.ThatDoNotExist")
    .Does(() =>
{
    // Given, When
    var arg = HasArgument("nonexisting");

    // Then
    Assert.False(arg);
});

Task("Cake.Common.ArgumentAliases.Argument")
    .Does(() =>
{
    // Given, When
    var arg = Argument<string>("customarg");

    // Then
    Assert.Equal("hello", arg);
});

Task("Cake.Common.ArgumentAliases.Argument.WithDefaultValue")
    .Does(() =>
{
    // Given, When
    var arg = Argument<string>("nonexisting", "foo");

    // Then
    Assert.Equal("foo", arg);
});

Task("Cake.Common.ArgumentAliases.Argument.MultipleArguments.GetsLastValue")
    .Does(() =>
{
    // Given, When
    var arg = Argument<string>("multipleargs");

    // Then
    Assert.Equal("b", arg);
});


Task("Cake.Common.ArgumentAliases.Arguments.MultipleArguments")
    .Does(() =>
{

    // Given, When
    var arg = Arguments<string>("multipleargs");

    // Then
    Assert.Equal(new[] { "a", "b" }, arg);
});

Task("Cake.Common.ArgumentAliases.Arguments.MultipleArguments.WithSingleDefaultValue")
    .Does(() =>
{
    // Given
    var expect = new[] { "a" };

    // When
    var arg = Arguments<string>("nonexistingmultipleargs", expect[0]);

    // Then
    Assert.Equal(expect, arg);
});

Task("Cake.Common.ArgumentAliases.Arguments.MultipleArguments.WithMultipleDefaultValue")
    .Does(() =>
{
    // Given
    var expect = new[] { "a", "b" };

    // When
    var arg = Arguments<string>("nonexistingmultipleargs", expect);

    // Then
    Assert.Equal(expect, arg);
});

Task("Cake.Common.ArgumentAliases.Arguments.MultipleArguments.WithLazyDefaultValue")
    .Does(() =>
{
    // Given
    var expect = new[] { "a", "b" };

    // When
    var arg = Arguments<string>("nonexistingmultipleargs", _ => expect);

    // Then
    Assert.Equal(expect, arg);
});

Task("Cake.Common.ArgumentAliases.Argument.DirectoryPathArgument")
    .Does(() =>
{
    // Given, When
    var arg = Argument<DirectoryPath>("testAssemblyDirectoryPath");

    // Then
    Assert.Equal(Context.Environment.ApplicationRoot.FullPath, arg.FullPath);
});

Task("Cake.Common.ArgumentAliases.Argument.FilePathArgument")
    .Does(() =>
{
    // Given
    var testAssemblyPath = Context
                            .Environment
                            .ApplicationRoot
                            .CombineWithFilePath("Cake.dll");

    // When
    var arg = Argument<FilePath>("testAssemblyFilePath");

    // Then
    Assert.Equal(testAssemblyPath.FullPath, arg.FullPath);
});

Task("Cake.Common.ArgumentAliases.Argument.DotNetVerbosityArgument")
    .Does(() =>
{
    // Given, When
    var arg = Argument<DotNetVerbosity>("testDotNetVerbosity");

    // Then
    Assert.Equal(DotNetVerbosity.Diagnostic, arg);
});

Task("Cake.Common.ArgumentAliases.Argument.DotNetRollForwardArgument")
    .Does(() =>
{
    // Given, When
    var arg = Argument<DotNetRollForward>("testDotNetRollForward");

    // Then
    Assert.Equal(DotNetRollForward.LatestMajor, arg);
});

//////////////////////////////////////////////////////////////////////////////

Task("Cake.Common.ArgumentAliases")
  .IsDependentOn("Cake.Common.ArgumentAliases.HasArgument")
  .IsDependentOn("Cake.Common.ArgumentAliases.HasArgument.ThatDoNotExist")
  .IsDependentOn("Cake.Common.ArgumentAliases.Argument")
  .IsDependentOn("Cake.Common.ArgumentAliases.Argument.WithDefaultValue")
  .IsDependentOn("Cake.Common.ArgumentAliases.Argument.MultipleArguments.GetsLastValue")
  .IsDependentOn("Cake.Common.ArgumentAliases.Arguments.MultipleArguments")
  .IsDependentOn("Cake.Common.ArgumentAliases.Arguments.MultipleArguments.WithSingleDefaultValue")
  .IsDependentOn("Cake.Common.ArgumentAliases.Arguments.MultipleArguments.WithMultipleDefaultValue")
  .IsDependentOn("Cake.Common.ArgumentAliases.Arguments.MultipleArguments.WithLazyDefaultValue")
  .IsDependentOn("Cake.Common.ArgumentAliases.Argument.DirectoryPathArgument")
  .IsDependentOn("Cake.Common.ArgumentAliases.Argument.FilePathArgument")
  .IsDependentOn("Cake.Common.ArgumentAliases.Argument.DotNetVerbosityArgument")
  .IsDependentOn("Cake.Common.ArgumentAliases.Argument.DotNetRollForwardArgument")
;
