
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
            var clients = new SumCalculator.SumCalculatorClient(channel);
           
            var responce = clients.sum(new SumRequest() { A = 30, B = 40 });
            var request = new Google.Protobuf.WellKnownTypes.Empty();
            Console.WriteLine("SUM: " + responce.Result);
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
           

            Console.ReadKey();
        }
    }
}
