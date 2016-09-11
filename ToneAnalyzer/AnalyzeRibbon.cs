using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace ToneAnalyzer
{
    public partial class AnalyzeRibbon
    {
        private void AnalyzeRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void AnalyzeTone_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("hi");
        }
    }
}
