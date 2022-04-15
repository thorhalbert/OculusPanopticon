using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestGrpcInvoker : MonoBehaviour
{
    void Awake()
    {
     
    }

    // Start is called before the first frame update
    void Start()
    {
        ////var option = new GrpcChannelOptions { Credentials = ChannelCredentials.Insecure };
        ////var channel = new GrpcChannel("10.0.52.245:10080", option);

        //var channel = new Grpc.Core.Channel("10.0.52.245:10080", ChannelCredentials.Insecure);
        //var client = new PanopticonService.Greeter.GreeterClient(channel);  

        //// YOUR CODE GOES HERE

        //var task = client.SayHelloAsync(new PanopticonService.HelloRequest { Name = "testname" });
        //var answer = task.GetAwaiter().GetResult();

        ////Console.WriteLine($"SayHello Returns: {answer.Message}");

        //channel.ShutdownAsync().Wait();

        //GrpcInterfaces.TestCall.Try();



        // Try to publish to a kafka topic

        //EventPlane.TestSend.Send(); // So far, this is in the foreground

       // UnitySystemConsoleRedirector.Redirect();

        // Start EventPlane singleton thread
        //var thr = new EventPlane.StartPlaneThread();
        //thr.Start();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
