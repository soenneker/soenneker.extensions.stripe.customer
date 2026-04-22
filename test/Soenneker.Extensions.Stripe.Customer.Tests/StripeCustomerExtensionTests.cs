using Soenneker.Tests.HostedUnit;

namespace Soenneker.Extensions.Stripe.Customer.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class StripeCustomerExtensionTests : HostedUnitTest
{

    public StripeCustomerExtensionTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
