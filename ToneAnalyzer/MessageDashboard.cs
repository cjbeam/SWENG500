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
using DevExpress.DashboardCommon;
using System.IO;

namespace ToneAnalyzer
{
    public partial class MessageDashboard : DevExpress.XtraEditors.XtraForm
    {
        public MessageDashboard(string fileName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmailDashboard.xml");
            string xml = File.ReadAllText(path);
            xml = xml.Replace("[Dashboard Location]", fileName);
            Stream xmlStream = new MemoryStream(Encoding.UTF8.GetBytes(xml ?? ""));
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(xmlStream);
            dashboardViewerTonal.Dashboard = dashboard;
        }
    }
}