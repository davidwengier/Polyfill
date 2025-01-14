﻿#if !NET5_0_OR_GREATER

#pragma warning disable
#nullable enable

// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedMember.Global

namespace System.Diagnostics.CodeAnalysis;

using Targets = AttributeTargets;

/// <summary>
/// Indicates that the specified method requires dynamic access to code that is not referenced
/// statically, for example through <see cref="System.Reflection"/>.
/// </summary>
/// <remarks>
/// This allows tools to understand which methods are unsafe to call when removing unreferenced
/// code from an application.
/// </remarks>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    validOn: Targets.Method |
             Targets.Constructor |
             Targets.Class,
    Inherited = false)]
#if PolyPublic
public
#endif
sealed class RequiresUnreferencedCodeAttribute :
    Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RequiresUnreferencedCodeAttribute"/> class
    /// with the specified message.
    /// </summary>
    /// <param name="message">
    /// A message that contains information about the usage of unreferenced code.
    /// </param>
    public RequiresUnreferencedCodeAttribute(string message) =>
        Message = message;

    /// <summary>
    /// Gets a message that contains information about the usage of unreferenced code.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Gets or sets an optional URL that contains more information about the method,
    /// why it requires unreferenced code, and what options a consumer has to deal with it.
    /// </summary>
    public string? Url { get; set; }
}

#endif