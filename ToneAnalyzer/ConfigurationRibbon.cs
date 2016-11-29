using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;

namespace ToneAnalyzer
{
    public partial class ConfigurationRibbon
    {
        DashboardDataAccess _dashboardDatabase;
        Outlook.MAPIFolder mainFolder;
        DashboardProgressForm progressForm;
        private void UserConfigurationRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            checkBoxAngerCategory.Checked = Properties.Settings.Default.AngerIncluded;
            checkBoxDisgustCategory.Checked = Properties.Settings.Default.DisgustIncluded;
            checkBoxFearCategory.Checked = Properties.Settings.Default.FearIncluded;
            checkBoxJoyCategory.Checked = Properties.Settings.Default.JoyIncluded;
            checkBoxSadnessCategory.Checked = Properties.Settings.Default.SadnessIncluded;
            checkBoxAnalyticalCategory.Checked = Properties.Settings.Default.AnalyticalIncluded;
            checkBoxConfidentCategory.Checked = Properties.Settings.Default.ConfidentIncluded;
            checkBoxTentativeCategory.Checked = Properties.Settings.Default.TentativeIncluded;
            checkBoxOpennessCategory.Checked = Properties.Settings.Default.OpennessIncluded;
            checkBoxConscientiousnessrCategory.Checked = Properties.Settings.Default.ConscientiousnessIncluded;
            checkBoxExtraversionCategory.Checked = Properties.Settings.Default.ExtraversionIncluded;
            checkBoxAgreeablenessCategory.Checked = Properties.Settings.Default.AgreeablenessIncluded;
            checkBoxERangeCategory.Checked = Properties.Settings.Default.EmotionalRangeIncluded;

            checkBoxAnger.Checked = Properties.Settings.Default.AngerAlert;
            checkBoxDisgust.Checked = Properties.Settings.Default.DisgustAlert;
            checkBoxFear.Checked = Properties.Settings.Default.FearAlert;
            checkBoxJoy.Checked = Properties.Settings.Default.JoyAlert;
            checkBoxSadness.Checked = Properties.Settings.Default.SadnessAlert;
            checkBoxAnalytical.Checked = Properties.Settings.Default.AnalyticalAlert;
            checkBoxConfident.Checked = Properties.Settings.Default.ConfidentAlert;
            checkBoxTentative.Checked = Properties.Settings.Default.TentativeAlert;
            checkBoxOpenness.Checked = Properties.Settings.Default.OpennessAlert;
            checkBoxConscientiousness.Checked = Properties.Settings.Default.ConscientiousnessAlert;
            checkBoxExtraversion.Checked = Properties.Settings.Default.ExtraversionAlert;
            checkBoxAgreeableness.Checked = Properties.Settings.Default.AgreeablenessAlert;
            checkBoxEmotionalRange.Checked = Properties.Settings.Default.EmotionalRangeAlert;

            comboBoxCategory.Text = "Anger";
            DisplayThreshold(comboBoxCategory.Text);
        }

        private void checkBoxAngerCategory_Click(object sender, RibbonControlEventArgs e)
        {
        Properties.Settings.Default.AngerIncluded = checkBoxAngerCategory.Checked;
            if(!checkBoxAngerCategory.Checked)
            {
                Properties.Settings.Default.AngerAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxDisgustCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.DisgustIncluded = checkBoxDisgustCategory.Checked;

            if (!checkBoxDisgustCategory.Checked)
            {
                Properties.Settings.Default.DisgustAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxFearCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.FearIncluded = checkBoxFearCategory.Checked;


            if (!checkBoxFearCategory.Checked)
            {
                Properties.Settings.Default.FearAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxJoyCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.JoyIncluded = checkBoxJoyCategory.Checked;

            if (!checkBoxJoyCategory.Checked)
            {
                Properties.Settings.Default.JoyAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxSadnessCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.SadnessIncluded = checkBoxSadnessCategory.Checked;

            if (!checkBoxSadnessCategory.Checked)
            {
                Properties.Settings.Default.SadnessAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxAnalyticalCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.AnalyticalIncluded = checkBoxAnalyticalCategory.Checked;

            if (!checkBoxAnalyticalCategory.Checked)
            {
                Properties.Settings.Default.AnalyticalAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxConfidentCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.ConfidentIncluded = checkBoxConfidentCategory.Checked;
            if (!checkBoxConfidentCategory.Checked)
            {
                Properties.Settings.Default.ConfidentAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxTentativeCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.TentativeIncluded = checkBoxTentativeCategory.Checked;
            if (!checkBoxTentativeCategory.Checked)
            {
                Properties.Settings.Default.TentativeAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxOpennessCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.OpennessIncluded = checkBoxOpennessCategory.Checked;
            if (!checkBoxOpennessCategory.Checked)
            {
                Properties.Settings.Default.OpennessAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxConscientiousnessrCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.ConscientiousnessIncluded = checkBoxConscientiousnessrCategory.Checked;
            if (!checkBoxConscientiousnessrCategory.Checked)
            {
                Properties.Settings.Default.ConscientiousnessAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxExtraversionCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.ExtraversionIncluded = checkBoxExtraversionCategory.Checked;
            if (!checkBoxExtraversionCategory.Checked)
            {
                Properties.Settings.Default.ExtraversionAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxAgreeablenessCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.AgreeablenessIncluded = checkBoxAgreeablenessCategory.Checked;
            if (!checkBoxAgreeablenessCategory.Checked)
            {
                Properties.Settings.Default.AgreeablenessAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxERangeCategory_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.EmotionalRangeIncluded = checkBoxERangeCategory.Checked;
            if (!checkBoxERangeCategory.Checked)
            {
                Properties.Settings.Default.EmotionalRangeAlert = false;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }
        ///
        private void checkBoxAnger_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.AngerAlert = checkBoxAnger.Checked;
            if (checkBoxAnger.Checked)
            {
                Properties.Settings.Default.AngerIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxDisgust_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.DisgustAlert = checkBoxDisgust.Checked;
            if (checkBoxDisgust.Checked)
            {
                Properties.Settings.Default.DisgustIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxFear_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.FearAlert = checkBoxFear.Checked;
            if (checkBoxFear.Checked)
            {
                Properties.Settings.Default.FearIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxJoy_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.JoyAlert = checkBoxJoy.Checked;
            if (checkBoxJoy.Checked)
            {
                Properties.Settings.Default.JoyIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxSadness_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.SadnessAlert = checkBoxSadness.Checked;
            if (checkBoxSadness.Checked)
            {
                Properties.Settings.Default.SadnessIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxAnalytical_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.AnalyticalAlert = checkBoxAnalytical.Checked;
            if (checkBoxAnalytical.Checked)
            {
                Properties.Settings.Default.AnalyticalIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxConfident_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.ConfidentAlert = checkBoxConfident.Checked;
            if (checkBoxConfident.Checked)
            {
                Properties.Settings.Default.ConfidentIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxTentative_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.TentativeAlert = checkBoxTentative.Checked;
            if (checkBoxTentative.Checked)
            {
                Properties.Settings.Default.TentativeIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxOpenness_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.OpennessAlert = checkBoxOpenness.Checked;

            if (checkBoxOpenness.Checked)
            {
                Properties.Settings.Default.OpennessIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxConscientiousness_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.ConscientiousnessAlert  = checkBoxConscientiousness.Checked;

            if (checkBoxConscientiousness.Checked)
            {
                Properties.Settings.Default.ConscientiousnessIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }

            Properties.Settings.Default.Save();
        }

        private void checkBoxExtraversion_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.ExtraversionAlert = checkBoxExtraversion.Checked;
            if (checkBoxExtraversion.Checked)
            {
                Properties.Settings.Default.ExtraversionIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxAgreeableness_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.AgreeablenessAlert = checkBoxAgreeableness.Checked;
            if (checkBoxAgreeableness.Checked)
            {
                Properties.Settings.Default.AgreeablenessIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxEmotionalRange_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.EmotionalRangeAlert = checkBoxEmotionalRange.Checked;
            if (checkBoxEmotionalRange.Checked)
            {
                Properties.Settings.Default.EmotionalRangeIncluded = true;
                UserConfigurationRibbon_Load(null, null);
            }
            Properties.Settings.Default.Save();
        }
        private void SetThreshold(string label, double thresholdValue)
        {
            switch (label)
            {
                case "Anger":
                    Properties.Settings.Default.AngerThreshold = thresholdValue;
                    break;
                case "Disgust":
                    Properties.Settings.Default.DisgustThreshold = thresholdValue;
                    break;
                case "Fear":
                    Properties.Settings.Default.FearThreshold = thresholdValue;
                    break;
                case "Joy":
                    Properties.Settings.Default.JoyThreshold = thresholdValue;
                    break;
                case "Sadness":
                    Properties.Settings.Default.SadnessThreshold = thresholdValue;
                    break;
                case "Analytical":
                    Properties.Settings.Default.AnalyticalThreshold = thresholdValue;
                    break;
                case "Confident":
                    Properties.Settings.Default.ConfidentThreshold = thresholdValue;
                    break;
                case "Tentative":
                    Properties.Settings.Default.TentativeThreshold = thresholdValue;
                    break;
                case "Openness":
                    Properties.Settings.Default.OpennessThreshold = thresholdValue;
                    break;
                case "Conscientiousness":
                    Properties.Settings.Default.ConscientiousnessThreshold = thresholdValue;
                    break;
                case "Agreeableness":
                    Properties.Settings.Default.AgreeablenessThreshold = thresholdValue;
                    break;
                case "Emotional Range":
                    Properties.Settings.Default.EmotionalRangeThreshold = thresholdValue;
                    break;
                case "Extraversion":
                    Properties.Settings.Default.ExtraversionThreshold = thresholdValue;
                    break;

            }
        }
        private void DisplayThreshold(string label)
        {
            switch (label)
            {
                case "Anger":
                    labelThresholdValue.Label = Properties.Settings.Default.AngerThreshold.ToString("N3");
                    break;
                case "Disgust":
                    labelThresholdValue.Label = Properties.Settings.Default.DisgustThreshold.ToString("N3");
                    break;
                case "Fear":
                    labelThresholdValue.Label = Properties.Settings.Default.FearThreshold.ToString("N3");
                    break;
                case "Joy":
                    labelThresholdValue.Label = Properties.Settings.Default.JoyThreshold.ToString("N3");
                    break;
                case "Sadness":
                    labelThresholdValue.Label = Properties.Settings.Default.SadnessThreshold.ToString("N3");
                    break;
                case "Analytical":
                    labelThresholdValue.Label = Properties.Settings.Default.AnalyticalThreshold.ToString("N3");
                    break;
                case "Confident":
                    labelThresholdValue.Label = Properties.Settings.Default.ConfidentThreshold.ToString("N3");
                    break;
                case "Tentative":
                    labelThresholdValue.Label = Properties.Settings.Default.TentativeThreshold.ToString("N3");
                    break;
                case "Openness":
                    labelThresholdValue.Label = Properties.Settings.Default.OpennessThreshold.ToString("N3");
                    break;
                case "Conscientiousness":
                    labelThresholdValue.Label = Properties.Settings.Default.ConscientiousnessThreshold.ToString("N3");
                    break;
                case "Agreeableness":
                    labelThresholdValue.Label = Properties.Settings.Default.AgreeablenessThreshold.ToString("N3");
                    break;
                case "Emotional Range":
                    labelThresholdValue.Label = Properties.Settings.Default.EmotionalRangeThreshold.ToString("N3");
                    break;
                case "Extraversion":
                    labelThresholdValue.Label = Properties.Settings.Default.ExtraversionThreshold.ToString("N3");
                    break;

            }
        }
        private void buttonThresholdUp_Click(object sender, RibbonControlEventArgs e)
        {
            double currentValue = double.Parse(labelThresholdValue.Label);
            currentValue = currentValue + .025;
            if (currentValue <= 1)
            {
                labelThresholdValue.Label = currentValue.ToString("N3");
                SetThreshold(comboBoxCategory.Text, currentValue);
            }
        }

        private void buttonThresholdDown_Click(object sender, RibbonControlEventArgs e)
        {
            double currentValue = double.Parse(labelThresholdValue.Label);
            currentValue = currentValue - .025;
            if (currentValue >= 0)
            {
                labelThresholdValue.Label = currentValue.ToString("N3");
                SetThreshold(comboBoxCategory.Text, currentValue);
            }
        }

        private void comboBoxCategory_TextChanged(object sender, RibbonControlEventArgs e)
        {
            DisplayThreshold(comboBoxCategory.Text);
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Set a category from the dropdown box.  Set the minimum score a message should have to be considered part of that category.", "Thresholds");
        }

        private void buttonHelp_Click(object sender, RibbonControlEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Select which categories should be applied to incoming/outgoing messages in your inbox.", "Categories");
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("If an outgoing email belongs to one of the checked categories, an alert will fire before the message is sent allowing you to cancel the message.", "Alerts");
        }
        private EmailAnalysis GetAnalysis(Outlook.MailItem mail)
        {
            Outlook.UserProperties mailUserProperties = null;
            Outlook.UserProperty mailUserProperty = null;
            StringBuilder builder = new StringBuilder();
            mailUserProperties = mail.UserProperties;
            try
            {
                for (int i = 1; i <= mailUserProperties.Count; i++)
                {
                    mailUserProperty = mailUserProperties[i];
                    if (mailUserProperty != null && mailUserProperty.Name == "Serialized Analysis")
                    {
                   string serializedAnalysis = mailUserProperty.Value;
                        return Deserialize(serializedAnalysis);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                if (mailUserProperties != null)
                    Marshal.ReleaseComObject(mailUserProperties);
            }
            return new EmailAnalysis();
        }
        private void AddItemToDashboard(string folder,  Outlook.MailItem mailItem, int emailId)
        {

            EmailAnalysis analysis = GetAnalysis(mailItem);
            string categories = mailItem.Categories;
            string subject = mailItem.Subject;
            DateTime receivedTime = mailItem.ReceivedTime;
            string importance = mailItem.Importance.ToString();
            bool readReceipt = mailItem.ReadReceiptRequested;
            string senderAddress = mailItem.SenderEmailAddress;
            string senderName = mailItem.SenderName;
            _dashboardDatabase.AddEmail(emailId, folder, analysis, categories, subject, receivedTime, importance, readReceipt, senderName, senderAddress);
        }
        private static EmailAnalysis Deserialize(string analysisSerialized)
        {
            EmailAnalysis analysisDeserialized;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(EmailAnalysis));
            using (var reader = new StringReader(analysisSerialized))
            {
                analysisDeserialized = (EmailAnalysis)serializer.Deserialize(reader);
            }

            return analysisDeserialized;
        }

        private void buttonTonalDashboard_Click(object sender, RibbonControlEventArgs e)
        {

           _dashboardDatabase = new DashboardDataAccess();
            _dashboardDatabase.CreateSchema();
            Outlook.Application oApp;
            Outlook._NameSpace oNS;
            oApp = new Outlook.Application();
            oNS = (Outlook._NameSpace)oApp.GetNamespace("MAPI");
            Outlook.MAPIFolder mailsFromThisFolder;
            oNS.Logon(Missing.Value, Missing.Value, false, true);

            mainFolder = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);

            int countEmails = 0;
            foreach (Object item in mainFolder.Items)
            {
                countEmails++;
            }

            foreach (Outlook.MAPIFolder folder in mainFolder.Folders)
            {
                foreach (Object item in folder.Items)
                {
                    countEmails++;
                }

            }
            progressForm = new DashboardProgressForm(countEmails);
            progressForm.Show();
            backgroundWorkerDashboard.RunWorkerAsync();


        }

        private void backgroundWorkerDashboard_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int emailId = 1;
            foreach (Object item in mainFolder.Items)
            {
                Outlook.MailItem mailItem = (Outlook.MailItem)item;
                AddItemToDashboard("Inbox", mailItem, emailId);
                emailId++;
                backgroundWorkerDashboard.ReportProgress(1);
            }

            foreach (Outlook.MAPIFolder folder in mainFolder.Folders)
            {
                foreach (Object item in folder.Items)
                {
                    Outlook.MailItem mailItem = (Outlook.MailItem)item;
                    AddItemToDashboard(folder.Name, mailItem, emailId);
                    emailId++;
                    backgroundWorkerDashboard.ReportProgress(1);
                }

            }

        }

        private void backgroundWorkerDashboard_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            _dashboardDatabase.Close();
            MessageDashboard dashboard = new MessageDashboard(_dashboardDatabase.FileName);
            progressForm.Close();
            dashboard.ShowDialog();
        }

        private void backgroundWorkerDashboard_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressForm.Step();
        }
    }
    }
