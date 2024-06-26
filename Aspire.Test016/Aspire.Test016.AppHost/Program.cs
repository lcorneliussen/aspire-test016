var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Aspire_Test016_ApiService>("apiservice");

builder.AddProject<Projects.Aspire_Test016_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

Console.WriteLine("Endpoint is: " + apiService.GetEndpoint("http").Url);

builder.Build().Run();