
using GrpcServiceCore;
using System;
using System.Threading.Tasks;
namespace grpcClientCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = Grpc.Net.Client.GrpcChannel.ForAddress("https://localhost:5001/");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            // var client = new ToDoProtos.ToDoService.ToDoServiceClient(channel);
            var request = new Google.Protobuf.WellKnownTypes.Empty();

            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            //Console.WriteLine(result.Description);
            //Console.WriteLine(result.Status);
            //Console.WriteLine(result.Title);

            Console.ReadKey();
        }
    }
}
