using System.ServiceModel;

namespace CallbackService.Server
{
    public interface IMyServiceCallback
    {
        [OperationContract]
        void OnCallback();
    }
}
