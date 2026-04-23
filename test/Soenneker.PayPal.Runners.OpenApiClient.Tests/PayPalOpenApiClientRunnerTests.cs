using Soenneker.Tests.HostedUnit;

namespace Soenneker.PayPal.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PayPalOpenApiClientRunnerTests : HostedUnitTest
{
    public PayPalOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
