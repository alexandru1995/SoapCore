using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Models
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Ping(string s);

        [OperationContract]
        ComplexModelResponse PingComplexModel(ComplexModelInput inputModel);

        [OperationContract]
        List<KeyValuePair<string, object>> VoidMethod();

        [OperationContract]
        object Test();

        [OperationContract]
        Task<int> AsyncMethod();

        [OperationContract]
        KeyValuePair<int, object> NullableMethod(bool? arg);

        [OperationContract]
        object XmlMethod();
    }
}