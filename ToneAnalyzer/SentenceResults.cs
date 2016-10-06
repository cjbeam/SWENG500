
using System.Drawing;
using System.Windows.Forms;


namespace ToneAnalyzer
{
    public partial class SentenceResults : DevExpress.XtraEditors.XtraForm
    {
        public SentenceResults(string category)
        {
            InitializeComponent();
            this.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(category.ToLower()) + @" Results";
        }

        public void AddSentence(string text, Bitmap gauge)
        {
          dataGridViewSentences.Rows.Add(new object[]{text, gauge})
            ;
        }

        public void Done()
        {
            dataGridViewSentences.AutoResizeColumns();
            dataGridViewSentences.AutoResizeRows();
        }

        private void dataGridViewSentences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
