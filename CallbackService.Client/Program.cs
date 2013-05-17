using System;
using System.ServiceModel;

namespace CallbackService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to continue once service is hosted.");
            Console.ReadLine();

            var callback = new MyServiceCallback();
            var instanceContext = new InstanceContext(callback);
            var client = new MyServiceReference.MyServiceClient(instanceContext);
            client.OpenSession();

            Console.ReadLine();
        }
    }
}
