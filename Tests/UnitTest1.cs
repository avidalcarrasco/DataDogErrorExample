using DataDogErrorExample;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var factory = new WebApplicationFactory<Startup>();

        using var client = factory.WithWebHostBuilder(config => { }).CreateClient();
    }

    [Fact]
    public void Test2()
    {
        var factory = new WebApplicationFactory<Startup>();

        using var client = factory.WithWebHostBuilder(config => { }).CreateClient();
    }
}