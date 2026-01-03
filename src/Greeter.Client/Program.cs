using Greeter;

using Grpc.Net.Client;
using static Greeter.Greeter;

using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "Renato" });

Console.WriteLine("Greeting: " + reply.Message);