using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace TonalService
{
    [ServiceContract]
    public interface ITonalAnalysisService
    {
        [OperationContract]
        string GetAnalysis(string email, string text);

    }

}
