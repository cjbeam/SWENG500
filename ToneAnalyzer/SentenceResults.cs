
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

        public void AddSentence(int sentenceId, string text, Bitmap gauge, float score)
        {

            var row = new DataGridViewRow();
            DataGridViewImageCell gaugeCell = new DataGridViewImageCell();
            gaugeCell.ToolTipText = score.ToString();
            gaugeCell.Tag = score;
            gaugeCell.Value = gauge;
            DataGridViewTextBoxCell sentenceTextCell = new DataGridViewTextBoxCell();
            sentenceTextCell.Value = text;
            DataGridViewTextBoxCell sentenceIdCell = new DataGridViewTextBoxCell();
            sentenceIdCell.Value = sentenceId;
            row.Cells.AddRange(sentenceIdCell, sentenceTextCell, gaugeCell);
            dataGridViewSentences.Rows.Add(row);
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

        private void dataGridViewSentences_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "Gauge")
            {
                var v1 = float.Parse(dataGridViewSentences[e.Column.Index, e.RowIndex1].Tag.ToString());
                var v2 = float.Parse(dataGridViewSentences[e.Column.Index, e.RowIndex2].Tag.ToString());
                e.SortResult = v1 < v2 ? -1 : v1 == v2 ? 0 : 1;
                e.Handled = true;
            }
        }
    }
}
