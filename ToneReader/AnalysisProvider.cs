using System.Collections.Generic;
using System.Linq;

namespace ToneReader
{
    public class AnalysisProvider
    {
        public string EmailAnalysis { get; private set; }


        public void Analyze(string email, string text)
        {
            EmailAnalysis = ApiRequest.MakeRequest(text);
        }


    }
}
