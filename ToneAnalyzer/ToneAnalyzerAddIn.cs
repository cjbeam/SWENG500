using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Newtonsoft.Json;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ToneAnalyzer
{
    public partial class ToneAnalyzerAddIn
    {
        public Outlook.Inspectors Inspectors { get; private set; }
        Outlook.NameSpace _outlookNameSpace;
        private Outlook.MAPIFolder _inbox;
        private Outlook.Items _items;

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
        private void application_contextMenu()
        {
            MessageBox.Show("");
        }
        private void application_itemSend(object item, ref bool cancel)
        {
            PerformMessageAnalysis(item);
            var mail = (Outlook.MailItem) item;
            foreach (var potentialFail in Configuration.MailCatergory.StopMessageCategories())
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
                RemoteTonalService.TonalAnalysisServiceClient service = new RemoteTonalService.TonalAnalysisServiceClient();
          if (mail.MessageClass == "IPM.Note")
          {
              string json = service.GetAnalysis(_outlookNameSpace.CurrentUser.Address, mail.Body);
              EmailAnalysis emailAnalysis = JsonConvert.DeserializeObject<EmailAnalysis>(json);
                    Outlook.UserProperty serializedAnalysisProperty =
                     mail.UserProperties.Add("Serialized Analysis", Outlook.OlUserPropertyType.olText);
                    string serializedAnalysis =  Serialize(emailAnalysis);
                    serializedAnalysisProperty.Value = serializedAnalysis;
                    foreach (var toneScore in  Helper.DocumentLevelCategoryScores(emailAnalysis, Configuration.Tone.IncludedCategories))
                    {

                        var mailUserProperty = mail.UserProperties.Add(toneScore.Key, Outlook.OlUserPropertyType.olNumber);
                        mailUserProperty.Value = toneScore.Value;
                        if (!Configuration.MailCatergory.IncludeCategories().Contains(toneScore.Key)) continue;
                            if (!(toneScore.Value >= Configuration.MailCatergory.Threshold(toneScore.Key))) continue;
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
        private static string Serialize(EmailAnalysis analysis)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(EmailAnalysis));
            using (var serialized = new StringWriter())
            {
                serializer.Serialize(serialized, analysis);
                return serialized.ToString();
            }
        }
        #endregion
    }
}
