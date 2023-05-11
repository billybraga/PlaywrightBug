using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightBug.Tests;

[TestFixture]
public class AppTest : PageTest
{
    [Test]
    public async Task Test()
    {
        await Page.GotoAsync("https://google.com");
    }
}