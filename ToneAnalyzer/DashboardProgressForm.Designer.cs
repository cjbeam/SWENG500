namespace ToneAnalyzer
{
    partial class DashboardProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardProgressForm));
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarControlDashboard = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressPanelDashboard = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlDashboard.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.progressBarControlDashboard, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressPanelDashboard, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.13044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.86956F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 115);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressBarControlDashboard
            // 
            this.progressBarControlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarControlDashboard.Location = new System.Drawing.Point(3, 71);
            this.progressBarControlDashboard.Name = "progressBarControlDashboard";
            this.progressBarControlDashboard.Size = new System.Drawing.Size(278, 41);
            this.progressBarControlDashboard.TabIndex = 0;
            // 
            // progressPanelDashboard
            // 
            this.progressPanelDashboard.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanelDashboard.Appearance.Options.UseBackColor = true;
            this.progressPanelDashboard.Description = "Processing Emails...";
            this.progressPanelDashboard.Location = new System.Drawing.Point(3, 3);
            this.progressPanelDashboard.Name = "progressPanelDashboard";
            this.progressPanelDashboard.Size = new System.Drawing.Size(278, 62);
            this.progressPanelDashboard.TabIndex = 1;
            this.progressPanelDashboard.Text = "progressPanel1";
            // 
            // DashboardProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 115);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlDashboard.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControlDashboard;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanelDashboard;
    }
}