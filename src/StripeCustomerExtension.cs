namespace Soenneker.Extensions.Stripe.Customer;

/// <summary>
/// A collection of helpful Stripe Customer extension methods
/// </summary>
public static class StripeCustomerExtension
{
    public static string? GetUserId(this global::Stripe.Customer? value)
    {
        if (value == null)
            return null;

        bool success = value.Metadata.TryGetValue("userId", out string? userId);

        return success ? userId! : null;
    }
}