[![](https://img.shields.io/nuget/v/soenneker.extensions.stripe.customer.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.stripe.customer/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.stripe.customer/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.stripe.customer/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.stripe.customer.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.stripe.customer/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.stripe.customer/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.stripe.customer/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Stripe.Customer
Retrieve the application user ID stored in a Stripe customer's metadata.

## Installation

```bash
dotnet add package Soenneker.Extensions.Stripe.Customer
```

## Usage

```csharp
using Soenneker.Extensions.Stripe.Customer;

Stripe.Customer customer = await customerService.GetAsync(customerId);
string? userId = customer.GetUserId();
```

`GetUserId()` reads the exact, case-sensitive metadata key `userId`. It returns `null` when the customer, metadata dictionary, or key is missing. The stored value is returned unchanged, including an empty or whitespace-only string.

This package only reads the local `Stripe.Customer` object; it does not call Stripe, create metadata, validate the identifier, or confirm that the referenced application user exists. Store the value when creating or updating the customer:

```csharp
var options = new CustomerCreateOptions
{
    Email = "ada@example.com",
    Metadata = new Dictionary<string, string>
    {
        ["userId"] = applicationUserId
    }
};
```
