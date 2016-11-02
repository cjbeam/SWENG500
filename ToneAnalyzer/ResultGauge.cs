using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win.Gauges.Circular;

namespace ToneAnalyzer
{
    public partial class ResultGauge : UserControl
    {
        public ResultGauge(string category, float score)
        {
            InitializeComponent();
            labelResult.Text = category;
            circularGauge1.Scales[0].Value = score;
        }
    }
}
