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
        Tonal.Model.Member Read(string email);

        [OperationContract]
        bool Create(Tonal.Model.Member member);
    }
}
