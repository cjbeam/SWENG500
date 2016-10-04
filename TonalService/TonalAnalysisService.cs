using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ToneReader;

namespace TonalService
{
    public class TonalAnalysisService : ITonalAnalysisService
    {
       public string GetAnalysis(string email, string text)
       {
           var provider = new AnalysisProvider();
            provider.Analyze(email,text);
           return provider.EmailAnalysis;
       }


    }
}
