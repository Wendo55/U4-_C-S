using Grpc.Core;
using GrpcServer; 

namespace GrpcServer.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        // Este método maneja las solicitudes gRPC del cliente
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Holaa Mundo"  
            });
        }
    }
}
