#if NETSTANDARD2_0 || NETFRAMEWORK || NETCOREAPP2X

#pragma warning disable

// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedMember.Global

namespace System.Diagnostics.CodeAnalysis;

/// <summary>
///   Specifies that the method will not return if the associated <see cref="Boolean"/>
///   parameter is passed the specified value.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(AttributeTargets.Parameter)]
#if PolyPublic
public
#endif
sealed class DoesNotReturnIfAttribute :
    Attribute
{
    /// <summary>
    ///   Gets the condition parameter value.
    ///   Code after the method is considered unreachable by diagnostics if the argument
    ///   to the associated parameter matches this value.
    /// </summary>
    public bool ParameterValue { get; }

    /// <summary>
    ///   Initializes a new instance of the <see cref="DoesNotReturnIfAttribute"/>
    ///   class with the specified parameter value.
    /// </summary>
    /// <param name="parameterValue">
    ///   The condition parameter value.
    ///   Code after the method is considered unreachable by diagnostics if the argument
    ///   to the associated parameter matches this value.
    /// </param>
    public DoesNotReturnIfAttribute(bool parameterValue) =>
        ParameterValue = parameterValue;
}

#endif