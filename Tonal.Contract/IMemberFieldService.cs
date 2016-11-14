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
        [WebGet(UriTemplate = "/GetEducationLevels",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        string GetEducationLevels();
        
        [OperationContract]
        [WebGet(UriTemplate = "/GetGenderOptions",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        string GetGenderOptions();
    
        [OperationContract]
        [WebGet(UriTemplate = "/GetStatesList",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        string GetStatesList();
    }
}
