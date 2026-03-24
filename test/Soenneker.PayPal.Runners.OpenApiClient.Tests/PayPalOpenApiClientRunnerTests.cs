using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.PayPal.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PayPalOpenApiClientRunnerTests : FixturedUnitTest
{
    public PayPalOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
