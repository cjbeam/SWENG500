using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Newtonsoft.Json;

namespace ToneAnalyzer
{
    public partial class AnalyzeRibbon
    {
        private EmailAnalysis _emailAnalysis;
        private string _messageHtml;
        private Microsoft.Office.Interop.Outlook.MailItem _currentMailItem;
        private void AnalyzeRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void AnalyzeTone_Click(object sender, RibbonControlEventArgs e)
        {
            var currentInspector =
                  this.Context as Microsoft.Office.Interop.Outlook.Inspector;
            if (currentInspector == null)
            {
                return;
            }
            _currentMailItem = currentInspector.CurrentItem as Microsoft.Office.Interop.Outlook.MailItem;
            _messageHtml = _currentMailItem.HTMLBody;

            resultsGroup.Visible = true;
            var service = new RemoteTonalService.TonalAnalysisServiceClient();
            if (_currentMailItem == null) return;
            var json = service.GetAnalysis(_currentMailItem.SenderEmailAddress, _currentMailItem.Body);
            _emailAnalysis = JsonConvert.DeserializeObject<EmailAnalysis>(json);
            RenderGauges(_emailAnalysis);
        }

        private void RenderGauges(EmailAnalysis analysis)
        {
            foreach (var result in analysis.BodyResult.CategoryAnalyses)
            {
                switch (result.CategoryId)
                {
                    case "emotion_tone":
                        RenderCategoryGauges(emotionResultsGallery, result.Tones);
                        break;
                    case "language_tone":
                        RenderCategoryGauges(languageResultsgallery, result.Tones);
                        break;
                    case "social_tone":
                        RenderCategoryGauges(socialResultsgallery, result.Tones);
                        break;

                }
            }

        }

        private void RenderCategoryGauges(RibbonGallery gallery, List<EmailAnalysis.Tone> tones)
        {
            gallery.Items.Clear();
            foreach (var tone in tones)
            {
                ResultGauge rg = new ResultGauge(tone.ToneName, (float)tone.Score*100);
                Bitmap b = new Bitmap(rg.Width, rg.Height);
                rg.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));

                RibbonDropDownItem item
          = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                item.Label = tone.ToneId;
                item.Image = b;
                gallery.Items.Add(item);
            }
        }
        private void emotionResultsGallery_Click(object sender, RibbonControlEventArgs e)
        {

            ViewSentences(sender);
        }

        private void ViewSentences(object sender)
        {

            string results = "";
            // _currentMailItem.HTMLBody = "";
            var dropdown = (RibbonGallery)sender;
            SentenceResults sr = new SentenceResults(dropdown.SelectedItem.Label);
            foreach (var sentence in _emailAnalysis.SentenceResult)
            {
                foreach (var categoryAnalysis in sentence.CategoryAnalyses)
                {
                    if (categoryAnalysis.CategoryId == dropdown.Tag.ToString())
                    {
                        foreach (var tone in categoryAnalysis.Tones)
                        {
                            if (tone.ToneId == dropdown.SelectedItem.Label)
                            {
                                results = results + sentence.Text + " " + tone.Score + System.Environment.NewLine;
                                SentenceGauge sg = new SentenceGauge((float)tone.Score * 100);
                                Bitmap b = new Bitmap(sg.Width, sg.Height);
                                sg.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));
                               sr.AddSentence(sentence.Text,b);
                            }
                        }
                    }
                }

            }
            sr.Done();
            sr.ShowDialog();
           
        }
        private void emotionResultsGallery_ButtonClick(object sender, RibbonControlEventArgs e)
        {
        }

        private void languageResultsgallery_Click(object sender, RibbonControlEventArgs e)
        {
            ViewSentences(sender);
        }

        private void socialResultsgallery_Click(object sender, RibbonControlEventArgs e)
        {
            ViewSentences(sender);
        }
    }
}
