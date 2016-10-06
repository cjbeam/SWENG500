namespace ToneAnalyzer
{
    partial class SentenceResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentenceResults));
            this.dataGridViewSentences = new System.Windows.Forms.DataGridView();
            this.Sentence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gauge = new System.Windows.Forms.DataGridViewImageColumn();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSentences
            // 
            this.dataGridViewSentences.AllowUserToAddRows = false;
            this.dataGridViewSentences.AllowUserToDeleteRows = false;
            this.dataGridViewSentences.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewSentences.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSentences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSentences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSentences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSentences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSentences.ColumnHeadersVisible = false;
            this.dataGridViewSentences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sentence,
            this.Gauge});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSentences.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSentences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSentences.Location = new System.Drawing.Point(10, 5);
            this.dataGridViewSentences.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewSentences.Name = "dataGridViewSentences";
            this.dataGridViewSentences.ReadOnly = true;
            this.dataGridViewSentences.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSentences.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSentences.Size = new System.Drawing.Size(672, 381);
            this.dataGridViewSentences.TabIndex = 0;
            this.dataGridViewSentences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSentences_CellContentClick);
            // 
            // Sentence
            // 
            this.Sentence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sentence.HeaderText = "Sentence";
            this.Sentence.Name = "Sentence";
            this.Sentence.ReadOnly = true;
            // 
            // Gauge
            // 
            this.Gauge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gauge.HeaderText = "Gauge";
            this.Gauge.Name = "Gauge";
            this.Gauge.ReadOnly = true;
            this.Gauge.Width = 5;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // SentenceResults
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 391);
            this.Controls.Add(this.dataGridViewSentences);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SentenceResults";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SentenceResults";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSentences;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sentence;
        private System.Windows.Forms.DataGridViewImageColumn Gauge;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}