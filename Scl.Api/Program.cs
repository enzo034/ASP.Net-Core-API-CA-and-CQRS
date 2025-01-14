using Scl.Api.Extension;



var builder = WebApplication.CreateBuilder(args);

builder.RegisterServicesExtensions(typeof(Program));

var app = builder.Build();

app.RegisterPipelineComponentsExtensions(typeof(Program));

app.Run();
