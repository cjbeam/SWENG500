namespace ToneAnalyzer
{
    partial class AnalyzeRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AnalyzeRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzeRibbon));
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupToneAnalyzer = this.Factory.CreateRibbonGroup();
            this.resultsGroup = this.Factory.CreateRibbonGroup();
            this.separator3 = this.Factory.CreateRibbonSeparator();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.backgroundWorkerAnalyze = new System.ComponentModel.BackgroundWorker();
            this.buttonAnalyzeMessage = this.Factory.CreateRibbonButton();
            this.socialResultsgallery = this.Factory.CreateRibbonGallery();
            this.languageResultsgallery = this.Factory.CreateRibbonGallery();
            this.emotionResultsGallery = this.Factory.CreateRibbonGallery();
            this.tab1.SuspendLayout();
            this.groupToneAnalyzer.SuspendLayout();
            this.resultsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupToneAnalyzer);
            this.tab1.Groups.Add(this.resultsGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupToneAnalyzer
            // 
            this.groupToneAnalyzer.Items.Add(this.buttonAnalyzeMessage);
            this.groupToneAnalyzer.Label = "Tone Analyzer";
            this.groupToneAnalyzer.Name = "groupToneAnalyzer";
            // 
            // resultsGroup
            // 
            this.resultsGroup.Items.Add(this.socialResultsgallery);
            this.resultsGroup.Items.Add(this.separator3);
            this.resultsGroup.Items.Add(this.languageResultsgallery);
            this.resultsGroup.Items.Add(this.separator2);
            this.resultsGroup.Items.Add(this.emotionResultsGallery);
            this.resultsGroup.Label = "Tonal Results";
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Visible = false;
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // backgroundWorkerAnalyze
            // 
            this.backgroundWorkerAnalyze.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAnalyze_DoWork);
            this.backgroundWorkerAnalyze.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAnalyze_RunWorkerCompleted);
            // 
            // buttonAnalyzeMessage
            // 
            this.buttonAnalyzeMessage.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonAnalyzeMessage.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnalyzeMessage.Image")));
            this.buttonAnalyzeMessage.Label = "Analyze";
            this.buttonAnalyzeMessage.Name = "buttonAnalyzeMessage";
            this.buttonAnalyzeMessage.ShowImage = true;
            this.buttonAnalyzeMessage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AnalyzeTone_Click);
            // 
            // socialResultsgallery
            // 
            this.socialResultsgallery.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.socialResultsgallery.Image = ((System.Drawing.Image)(resources.GetObject("socialResultsgallery.Image")));
            this.socialResultsgallery.Label = "Social Tendencies";
            this.socialResultsgallery.Name = "socialResultsgallery";
            this.socialResultsgallery.ShowImage = true;
            this.socialResultsgallery.ShowItemLabel = false;
            this.socialResultsgallery.Tag = "social_tone";
            this.socialResultsgallery.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.socialResultsgallery_Click);
            // 
            // languageResultsgallery
            // 
            this.languageResultsgallery.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.languageResultsgallery.Image = ((System.Drawing.Image)(resources.GetObject("languageResultsgallery.Image")));
            this.languageResultsgallery.Label = "Language";
            this.languageResultsgallery.Name = "languageResultsgallery";
            this.languageResultsgallery.ShowImage = true;
            this.languageResultsgallery.ShowItemLabel = false;
            this.languageResultsgallery.Tag = "language_tone";
            this.languageResultsgallery.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.languageResultsgallery_Click);
            // 
            // emotionResultsGallery
            // 
            this.emotionResultsGallery.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.emotionResultsGallery.Image = ((System.Drawing.Image)(resources.GetObject("emotionResultsGallery.Image")));
            ribbonDropDownItemImpl1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDropDownItemImpl1.Image")));
            ribbonDropDownItemImpl1.Label = "Item0";
            this.emotionResultsGallery.Items.Add(ribbonDropDownItemImpl1);
            this.emotionResultsGallery.Label = "Emotion";
            this.emotionResultsGallery.Name = "emotionResultsGallery";
            this.emotionResultsGallery.ShowImage = true;
            this.emotionResultsGallery.ShowItemLabel = false;
            this.emotionResultsGallery.Tag = "emotion_tone";
            this.emotionResultsGallery.ButtonClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.emotionResultsGallery_ButtonClick);
            this.emotionResultsGallery.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.emotionResultsGallery_Click);
            // 
            // AnalyzeRibbon
            // 
            this.Name = "AnalyzeRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AnalyzeRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupToneAnalyzer.ResumeLayout(false);
            this.groupToneAnalyzer.PerformLayout();
            this.resultsGroup.ResumeLayout(false);
            this.resultsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupToneAnalyzer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAnalyzeMessage;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery emotionResultsGallery;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery languageResultsgallery;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery socialResultsgallery;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup resultsGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAnalyze;
    }

    partial class ThisRibbonCollection
    {
        internal AnalyzeRibbon AnalyzeRibbon
        {
            get { return this.GetRibbon<AnalyzeRibbon>(); }
        }
    }
}
