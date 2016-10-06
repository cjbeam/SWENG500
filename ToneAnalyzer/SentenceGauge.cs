using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToneAnalyzer
{
    public partial class SentenceGauge : UserControl
    {
        public SentenceGauge(float score)
        {
            InitializeComponent();
            circularGauge1.Scales[0].Value = score;
        }
    }
}
