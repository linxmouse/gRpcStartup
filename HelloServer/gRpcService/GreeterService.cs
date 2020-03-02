using System.Threading.Tasks;
using greeter.hello;
using Grpc.Core;

namespace HelloServer.gRpcService
{
    class GreeterService: Greeter.GreeterBase
    {
        public override Task<HelloResponse> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloResponse() {Message = "server responsed: " + "hello " + request.Name});
        }

        public override Task<HelloResponse> SayWorld(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloResponse() {Message = "server responsed: " + request.Name + " world"});
        }
    }
}
