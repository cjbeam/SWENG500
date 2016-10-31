using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using ToneReader;

namespace TonalService
{
    public class TonalAnalysisService : ITonalAnalysisService
    {
       public string GetAnalysis(string email, string text)
       {
            string jsonResult = "";
            try
            {
                var provider = new AnalysisProvider();
                provider.Analyze(email, text);
                jsonResult = provider.EmailAnalysis;
                EmailAnalysis emailAnalysis = JsonConvert.DeserializeObject<EmailAnalysis>(jsonResult);
                if (emailAnalysis.SentenceResult == null)
                    throw new Exception("Body is not large enough to perform analysis.");
                PersistAnalysis(email, emailAnalysis);
            }
            catch (Exception ex)
            {
                jsonResult = ex.Message;
            }
            return jsonResult;
       }
        public void PersistAnalysis(string email, EmailAnalysis emailAnalysis)
        {
           
            PersistResults(emailAnalysis, email);
        }
        public void PersistResults(EmailAnalysis emailAnalysis, string emailAddress)
        {
            int analysisId = 1; //Get unique value from sequence in SQL Server?
            Debug.WriteLine(String.Format("INSERT INTO ANALYSIS (ANALYSIS_ID, USER_EMAIL, ANALYSIS_DATE) VALUES ({0},\"{1}\",GETDATE())",analysisId, emailAddress));
            PersistBodyResults(analysisId, emailAnalysis.BodyResult);
            PersistSentenceResults(analysisId, emailAnalysis.SentenceResult);
        }
        public void PersistBodyResults(int analysisKey, EmailAnalysis.BodyAnalysis bodyAnalysis)
        {
            foreach (var categoryAnalysis in bodyAnalysis.CategoryAnalyses)
            {
                foreach(var categoryScore in categoryAnalysis.Tones)
                {
                    Debug.WriteLine(String.Format("INSERT INTO BODY_ANALYSIS (ANALYSIS_ID, CATEGORY, TONE_NAME, SCORE) VALUES ({0},\"{1}\",\"{2}\",{3})", analysisKey, categoryAnalysis.CategoryId, categoryScore.ToneName.Replace("_big5",""), categoryScore.Score));
                }
            }
        }
        public void PersistSentenceResults(int analysisKey, List<EmailAnalysis.SentenceAnalysis> sentenceAnalysisList)
        {
            foreach (var sentenceAnalysis in sentenceAnalysisList)
            {
                foreach (var categoryAnalysis in sentenceAnalysis.CategoryAnalyses)
                {
                    foreach (var categoryScore in categoryAnalysis.Tones)
                    {
                        Debug.WriteLine(String.Format("INSERT INTO SENTENCE_ANALYSIS (ANALYSIS_ID, SENTENCE_ID, CATEGORY, TONE_NAME, SCORE) VALUES (\"{0}\",{1},\"{2}\",\"{3}\",{4})", analysisKey, sentenceAnalysis.SentenceId, categoryAnalysis.CategoryId,  categoryScore.ToneName.Replace("_big5", ""), categoryScore.Score));
                    }
                }
            }
        }

    }
}
