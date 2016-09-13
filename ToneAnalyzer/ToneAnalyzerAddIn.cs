using System;
using System.Windows.Forms;
using ToneReader;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ToneAnalyzer
{
    public partial class ToneAnalyzerAddIn
    {
        private readonly AnalysisProvider _toneReader = new AnalysisProvider()
        {
            ServiceAddress = Configuration.Service.Address,
            ServiceVersion = Configuration.Service.Version,
            ContentType = Configuration.Service.ContentType,
            UserName = Configuration.Service.UserName,
            Password = Configuration.Service.Password
        };

        public Outlook.Inspectors Inspectors { get; private set; }
        Outlook.NameSpace _outlookNameSpace;
        private Outlook.MAPIFolder _inbox;
        Outlook.Items _items;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            Inspectors = Application.Inspectors;
            _outlookNameSpace = Application.GetNamespace("MAPI");
            _inbox = _outlookNameSpace.GetDefaultFolder(
                Outlook.
                    OlDefaultFolders.olFolderInbox);

            _items = _inbox.Items;
            _items.ItemAdd += items_ItemAdd;
            Application.ItemSend += application_itemSend;

        }

        private void application_itemSend(object item, ref bool cancel)
        {
            PerformMessageAnalysis(item);
            Outlook.MailItem mail = (Outlook.MailItem) item;
            foreach (var potentialFail in Configuration.MailCatergory.StopMessageCategories)
                if (mail.Categories.Contains(potentialFail))
                {
                    var dialogResult =
                        MessageBox.Show(
                            @"This is flagged because of its " + potentialFail + @" score.  Would you like to continue?",
                            @"Are You Sure You Want to Send This?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cancel = false;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        cancel = true;
                    }
                }
                else
                {
                    cancel = false;
                }


        }

        private void items_ItemAdd(object item)
        {
            PerformMessageAnalysis(item);

        }

        private void PerformMessageAnalysis(object item)
        {
            try
            {


            Outlook.MailItem mail = (Outlook.MailItem)item;
            if (item != null)
            {
                if (mail.MessageClass == "IPM.Note")
                {
                    _toneReader.Analyze(mail.Body);

                    Outlook.UserProperty serializedAnalysisProperty =
                     mail.UserProperties.Add("Serialized Analysis", Outlook.OlUserPropertyType.olText);
                    string serializedAnalysis = Serialization.Serialize(_toneReader.EmailAnalysis);
                    serializedAnalysisProperty.Value = serializedAnalysis;
                    foreach (var toneScore in _toneReader.DocumentLevelCategoryScores(Configuration.Tone.IncludedCategories))
                    {
                        var mailUserProperty = mail.UserProperties.Add(toneScore.Key, Outlook.OlUserPropertyType.olNumber);
                        mailUserProperty.Value = toneScore.Value;
                        if (!(toneScore.Value >= Configuration.MailCatergory.Threshold)) continue;
                        var customCat = toneScore.Key;
                        if (mail.Categories == null)
                            mail.Categories = customCat;
                        else if (!mail.Categories.Contains(customCat))
                            mail.Categories = $"{customCat}, {mail.Categories}";
                    }
                }
            }
            mail.Save();
            }
            catch (Exception)
            {
                { }
                throw;
            }
        }
        
        private void AddACategory(string categoryTitle, Outlook.OlCategoryColor color)
        {
            var categories =
                Application.Session.Categories;
            if (!CategoryExists(categoryTitle))
            {
                categories.Add(categoryTitle,color);
            }
        }
        
        private bool CategoryExists(string categoryName)
        {
            try
            {
                var category =
                    Application.Session.Categories[categoryName];
                return category != null;
            }
            catch { return false; }
        }
        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }
        
        #endregion
    }
}
