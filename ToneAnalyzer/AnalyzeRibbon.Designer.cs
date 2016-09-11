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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupToneAnalyzer = this.Factory.CreateRibbonGroup();
            this.buttonAnalyzeMessage = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupToneAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupToneAnalyzer);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupToneAnalyzer
            // 
            this.groupToneAnalyzer.Items.Add(this.buttonAnalyzeMessage);
            this.groupToneAnalyzer.Label = "Tone Analyzer";
            this.groupToneAnalyzer.Name = "groupToneAnalyzer";
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
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupToneAnalyzer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAnalyzeMessage;
    }

    partial class ThisRibbonCollection
    {
        internal AnalyzeRibbon AnalyzeRibbon
        {
            get { return this.GetRibbon<AnalyzeRibbon>(); }
        }
    }
}
