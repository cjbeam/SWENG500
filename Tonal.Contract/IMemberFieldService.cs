using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Tonal.Contract
{
    [ServiceContract]
    public interface IMemberFieldService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetEducationLevels")]
        string GetEducationLevels();
        
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetGenderOptions")]
        string GetGenderOptions();
    
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetStatesList")]
        string GetStatesList();
    }
}
