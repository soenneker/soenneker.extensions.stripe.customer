[![](https://img.shields.io/nuget/v/soenneker.extensions.stripe.customer.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.stripe.customer/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.stripe.customer/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.stripe.customer/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.stripe.customer.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.stripe.customer/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.stripe.customer/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.stripe.customer/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Stripe.Customer
A collection of helpful Stripe Customer extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.Stripe.Customer
```

## Quick start

```csharp
using Soenneker.Extensions.Stripe.Customer;

// Given an existing global::Stripe.Customer? named value:
var result = value.GetUserId();
```

## Common operations

- `GetUserId()` - Retrieves the user identifier associated with the specified Stripe customer, if available. Returns the user identifier if present in the customer's metadata; otherwise, null.
