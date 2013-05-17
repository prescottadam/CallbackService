using System;
using CallbackService.Client.MyServiceReference;

namespace CallbackService.Client
{
    public class MyServiceCallback : IMyServiceCallback
    {
        public void OnCallback()
        {
            Console.WriteLine("> Received callback at {0}", DateTime.Now);
        }
    }
}
