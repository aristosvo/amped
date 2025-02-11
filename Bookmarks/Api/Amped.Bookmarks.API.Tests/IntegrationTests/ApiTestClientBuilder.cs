﻿using System.Net.Http;

namespace Amped.Bookmarks.API.Tests.IntegrationTests;

public class ApiTestClientBuilder
{
    public HttpClient Build()
    {   
        var factory = new TestWebApplicationFactory();
        return factory.CreateClient();
    }
}