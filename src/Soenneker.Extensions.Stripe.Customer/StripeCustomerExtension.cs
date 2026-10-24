using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.Stripe.Customer;

/// <summary>
/// A collection of helpful Stripe Customer extension methods
/// </summary>
public static class StripeCustomerExtension
{
    private const string _userIdKey = "userId";

    /// <summary>
    /// Retrieves the user identifier associated with the specified Stripe customer, if available.
    /// </summary>
    /// <param name="value">The Stripe customer from which to retrieve the user identifier. Can be null.</param>
    /// <returns>The user identifier if present in the customer's metadata; otherwise, null.</returns>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? GetUserId(this global::Soenneker.Stripe.OpenApiClient.Models.Customer? value)
    {
        if (value?.Metadata is null)
            return null;

        return value.Metadata.AdditionalData.TryGetValue(_userIdKey, out object? userId)
            ? userId?.ToString()
            : null;
    }
}
