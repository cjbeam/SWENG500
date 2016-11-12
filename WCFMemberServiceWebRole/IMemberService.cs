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
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Read/")]
        Tonal.Model.Member Read(string email);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Create", RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json, BodyStyle =  WebMessageBodyStyle.Bare)]
        bool Create(Tonal.Model.Member member);
    }
}
