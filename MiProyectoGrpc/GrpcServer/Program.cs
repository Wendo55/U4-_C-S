using GrpcServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios a la colección
builder.Services.AddGrpc();

var app = builder.Build();

// Configurar la tubería de solicitudes HTTP
app.MapGrpcService<GreeterService>();  // Mapea el servicio gRPC
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client.");

app.Run();