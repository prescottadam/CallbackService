using System.ServiceModel;

namespace CallbackService.Server
{
    [ServiceContract(CallbackContract = typeof(IMyServiceCallback))]
    public interface IMyService
    {
        [OperationContract]
        void OpenSession();
    }
}
