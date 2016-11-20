using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace ToneAnalyzer
{
    public class DashboardDataAccess
    {
        SQLiteConnection _dbConnection;
        string _fileName;
        public string FileName
        {
            get
            {
                // Return the actual name if it is not null.
                return this._fileName;
            }
            set
            {
                // Set the employee name field.
                this._fileName = value;
            }
        }
        public DashboardDataAccess()
        {
            FileName = System.IO.Path.GetTempFileName();
            SQLiteConnection.CreateFile(FileName);
            _dbConnection = new SQLiteConnection("Data Source="+ FileName + "; Version=3;");
            _dbConnection.Open();
        }
        private void ExecuteCommand(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
            command.ExecuteNonQuery();
        }
        public void CreateSchema()
        {
            ExecuteCommand(@"CREATE TABLE [Email](
                                [Email_Id] INTEGER PRIMARY KEY NOT NULL UNIQUE, 
                                [Folder] TEXT, 
                                [Subject] TEXT, 
                                [Received] DATETIME, 
                                [Importance] TEXT, 
                                [Read_Receipt] BOOLEAN, 
                                [SenderName] TEXT,
                                [SenderEmailAddress] TEXT
                                )");

            ExecuteCommand(@"CREATE TABLE [Body_Analysis](
                                [Email_Id] INTEGER REFERENCES Email([Email_Id]), 
                                [Category] TEXT, 
                                [Tone_Name] TEXT, 
                                [Score] DOUBLE, 
                                PRIMARY KEY([Email_Id], [Category], [Tone_Name]))");


        }
        public  void AddEmail(int emailId, string folder, EmailAnalysis analysis, string categories, string subject, DateTime receivedTime, string importance, bool readReceipt, string senderName, string senderAddress)
        {
            using (SQLiteTransaction tr = _dbConnection.BeginTransaction())
            {
                using (SQLiteCommand cmd = _dbConnection.CreateCommand())
                {
                    subject = subject ?? "";
            categories = categories ?? "";
            senderName = senderName ?? "";
            senderAddress = senderAddress ?? "";
            int readReceiptForInsert = 0;
            if (readReceipt) { readReceiptForInsert = 1; };
            string receivedTimeForInsert = receivedTime.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.CommandText = String.Format("INSERT INTO [Email] VALUES ({0},'{1}','{2}','{3}','{4}',{5},'{6}','{7}')", emailId, folder.Replace("'", "''"), subject.Replace("'", "''"), receivedTimeForInsert, importance.Replace("olImportance",""), readReceiptForInsert, senderName.Replace("'", "''"), senderAddress.Replace("'", "''"));
            cmd.ExecuteNonQuery();
            try
            {
                foreach (var categoryAnalysis in analysis.BodyResult.CategoryAnalyses)
                {
                    foreach (var categoryScore in categoryAnalysis.Tones)
                    {
                    cmd.CommandText =  String.Format("INSERT INTO BODY_ANALYSIS VALUES ({0},\"{1}\",\"{2}\",{3})", emailId, categoryAnalysis.CategoryId, categoryScore.ToneName.Replace("_big5", ""), categoryScore.Score);
                    cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
                }

                tr.Commit();
            }

        }

        public void Close()
        {
            _dbConnection.Dispose();
        }
    }
}
