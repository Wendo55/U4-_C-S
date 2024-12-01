using Grpc.Net.Client;
using GrpcServer;
using GrpcServer.Services;

var channel = GrpcChannel.ForAddress("http://localhost:5000");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "Mundo" });

Console.WriteLine("Respuesta del servidor: " + reply.Message);  // Debería imprimir "Holaa Mundo"