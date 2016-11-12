using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFMemberServiceWebRole
{
    [ServiceContract]
    public interface IMemberService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Read/{email}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Tonal.Model.Member Read(string email);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        bool Create(Tonal.Model.Member member);
    }
}
