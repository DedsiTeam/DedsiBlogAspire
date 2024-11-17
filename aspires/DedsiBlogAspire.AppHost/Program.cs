var builder = DistributedApplication.CreateBuilder(args);

var identityConnectionString = builder.AddConnectionString("IdentityDB");
var articleDBConnectionString = builder.AddConnectionString("ArticleDB");

builder
    .AddProject<Projects.DBA_Identity>("dba-identity")
    .WithReference(identityConnectionString);

builder
    .AddProject<Projects.DBA_AuthorizationCenter>("dba-authorizationcenter")
    .WithReference(identityConnectionString);

builder
    .AddProject<Projects.DBA_Article>("dba-article")
    .WithReference(articleDBConnectionString);

builder.Build().Run();
