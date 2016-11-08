using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using ToneReader;
using System.Data;
using System.Data.OleDb;

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
                PersistAnalysis(email, emailAnalysis, text);
            }
            catch (Exception ex)
            {
                jsonResult = ex.Message;
            }
            return jsonResult;
       }
        public void PersistAnalysis(string email, EmailAnalysis emailAnalysis, string emailMessage)
        {
           
            PersistResults(emailAnalysis, email, emailMessage);
        }
        public void PersistResults(EmailAnalysis emailAnalysis, string emailAddress, string emailMessage)
        {
            string analysisId = Guid.NewGuid().ToString();
            OleDbConnection conn = new OleDbConnection("Provider=sqloledb;Data Source=tcp:psu.database.windows.net,1433;Initial Catalog=ToneAnalyzer;Persist Security Info=False;User ID=sweng500;Password=sweng!23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (conn)
            {
                conn.Open();
                string strSQL = "dbo.usp_TONAL_INS_Analysis";
                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AnalysisID", analysisId);
                cmd.Parameters.AddWithValue("@EmailAddress", emailAddress);
                cmd.Parameters.AddWithValue("@EmailMessage", emailMessage);

                cmd.ExecuteNonQuery();
            }
            //Debug.WriteLine(String.Format("INSERT INTO ANALYSIS (ANALYSIS_ID, USER_EMAIL, ANALYSIS_DATE) VALUES ({0},\"{1}\",GETDATE())",analysisId, emailAddress));
            PersistBodyResults(analysisId, emailAnalysis.BodyResult);
            PersistSentenceResults(analysisId, emailAnalysis.SentenceResult);
        }
        public void PersistBodyResults(string analysisKey, EmailAnalysis.BodyAnalysis bodyAnalysis)
        {
            foreach (var categoryAnalysis in bodyAnalysis.CategoryAnalyses)
            {
                foreach(var categoryScore in categoryAnalysis.Tones)
                {
                    OleDbConnection conn = new OleDbConnection("Provider=sqloledb;Data Source=tcp:psu.database.windows.net,1433;Initial Catalog=ToneAnalyzer;Persist Security Info=False;User ID=sweng500;Password=sweng!23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    using (conn)
                    {
                        conn.Open();
                        string strSQL = "dbo.usp_TONAL_INS_EmailMessageAnalysis";
                        OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AnalysisID", analysisKey);
                        cmd.Parameters.AddWithValue("@Category", categoryAnalysis.CategoryId);
                        cmd.Parameters.AddWithValue("@ToneName", categoryScore.ToneName.Replace("_big5", ""));
                        cmd.Parameters.AddWithValue("@Score", categoryScore.Score);

                        cmd.ExecuteNonQuery();
                    }
                    //Debug.WriteLine(String.Format("INSERT INTO BODY_ANALYSIS (ANALYSIS_ID, CATEGORY, TONE_NAME, SCORE) VALUES ({0},\"{1}\",\"{2}\",{3})", analysisKey, categoryAnalysis.CategoryId, categoryScore.ToneName.Replace("_big5",""), categoryScore.Score));
                }
            }
        }
        public void PersistSentenceResults(string analysisKey, List<EmailAnalysis.SentenceAnalysis> sentenceAnalysisList)
        {
            foreach (var sentenceAnalysis in sentenceAnalysisList)
            {
                string sentenceKey = Guid.NewGuid().ToString();

                OleDbConnection conn = new OleDbConnection("Provider=sqloledb;Data Source=tcp:psu.database.windows.net,1433;Initial Catalog=ToneAnalyzer;Persist Security Info=False;User ID=sweng500;Password=sweng!23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                using (conn)
                {
                    conn.Open();
                    string strSQL = "dbo.usp_TONAL_INS_EmailSentence";
                    OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AnalysisID", analysisKey);
                    cmd.Parameters.AddWithValue("@SentenceID", sentenceKey);
                    cmd.Parameters.AddWithValue("@SentenceMessage", sentenceAnalysis.Text);

                    cmd.ExecuteNonQuery();
                }
                foreach (var categoryAnalysis in sentenceAnalysis.CategoryAnalyses)
                {
                    foreach (var categoryScore in categoryAnalysis.Tones)
                    {
                        conn = new OleDbConnection("Provider=sqloledb;Data Source=tcp:psu.database.windows.net,1433;Initial Catalog=ToneAnalyzer;Persist Security Info=False;User ID=sweng500;Password=sweng!23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                        using (conn)
                        {
                            conn.Open();
                            string strSQL = "dbo.usp_TONAL_INS_EmailSentenceAnalysis";
                            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@AnalysisID", analysisKey);
                            cmd.Parameters.AddWithValue("@SentenceID", sentenceKey);
                            cmd.Parameters.AddWithValue("@Category", categoryAnalysis.CategoryId);
                            cmd.Parameters.AddWithValue("@ToneName", categoryScore.ToneName.Replace("_big5", ""));
                            cmd.Parameters.AddWithValue("@Score", categoryScore.Score);

                            cmd.ExecuteNonQuery();
                        }
                        //Debug.WriteLine(String.Format("INSERT INTO SENTENCE_ANALYSIS (ANALYSIS_ID, SENTENCE_ID, CATEGORY, TONE_NAME, SCORE) VALUES (\"{0}\",{1},\"{2}\",\"{3}\",{4})", analysisKey, sentenceAnalysis.SentenceId, categoryAnalysis.CategoryId,  categoryScore.ToneName.Replace("_big5", ""), categoryScore.Score));
                    }
                }
            }
        }

    }
}
