
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
        public EmailAnalysis EmailAnalysis { get; private set; }

        public void Analyze(string text)
        {
            var request = new ApiRequest()
            {
                ServiceAddress = ServiceAddress,
                ServiceVersion = ServiceVersion,
                ContentType = ContentType,
                UserName = UserName,
                Password = Password
            };
            EmailAnalysis = Newtonsoft.Json.JsonConvert.DeserializeObject<EmailAnalysis>(request.MakeRequest(text));
        }
        public Dictionary<string, double> DocumentLevelCategoryScores(List<string> includedCategories)
        {
            var categoryTones = new List<EmailAnalysis.Tone>();
            foreach (var tc in EmailAnalysis.BodyResult.CategoryAnalyses)
            {
                if (includedCategories.Contains(tc.CategoryId))
                {
                    categoryTones.AddRange(tc.Tones);
                }
            }
            var categoryScores = categoryTones.ToDictionary(tone => tone.ToneName, tone => tone.Score);
            return categoryScores;
        }
    }
}
