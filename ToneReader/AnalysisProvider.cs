using System.Collections.Generic;
using System.Linq;

namespace ToneReader
{
    public class AnalysisProvider
    {
        public string UserName { private get; set; }
        public string Password { private get; set; }
        public string ServiceAddress { private get; set; }
        public string ServiceVersion { private get; set; }
        public string ContentType { private get; set; }
        public string EmailAnalysis { get; private set; }

        private ApiRequest Request { get; set; }

        public void Analyze(string email, string text)
        {
        ServiceAddress = "https://gateway.watsonplatform.net/tone-analyzer/api/v3/tone";
        ServiceVersion = "2016-05-19";
        ContentType = "text/plain";
        UserName = "e3eaa52a-26fe-48b3-972c-8fdb5783776f";
        Password = "0pQUmXFLwrmA";
        Request = new ApiRequest()
            {
                ServiceAddress = ServiceAddress,
                ServiceVersion = ServiceVersion,
                ContentType = ContentType,
                UserName = UserName,
                Password = Password
            };
            EmailAnalysis = Request.MakeRequest(text);
        }


    }
}
