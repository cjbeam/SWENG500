using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ToneAnalyzer
{
    public partial class DashboardProgressForm : DevExpress.XtraEditors.XtraForm
    {
        int _emailCount;
        public DashboardProgressForm(int emailCount)
        {
            _emailCount = emailCount;
            InitializeComponent();
            progressBarControlDashboard.Properties.Minimum = 0;
            progressBarControlDashboard.Properties.Maximum = _emailCount;

        }
        public void Step()
        {
            progressBarControlDashboard.PerformStep();
            progressBarControlDashboard.Update();
        }
    }
}