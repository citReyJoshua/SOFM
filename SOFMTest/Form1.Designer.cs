namespace SOFMTest
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.btnLoadSingle = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.gbKohonen = new System.Windows.Forms.GroupBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.sofmVisualizer = new SOFMTest.SOFMVisualizer();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbKohonen.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelLegend);
            this.splitContainer1.Panel1.Controls.Add(this.lblResult);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadSingle);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadData);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbKohonen);
            this.splitContainer1.Size = new System.Drawing.Size(1468, 1117);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelLegend
            // 
            this.panelLegend.AutoSize = true;
            this.panelLegend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLegend.Location = new System.Drawing.Point(32, 807);
            this.panelLegend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(2, 2);
            this.panelLegend.TabIndex = 5;
            this.panelLegend.Visible = false;
            // 
            // btnLoadSingle
            // 
            this.btnLoadSingle.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSingle.Location = new System.Drawing.Point(75, 189);
            this.btnLoadSingle.Name = "btnLoadSingle";
            this.btnLoadSingle.Size = new System.Drawing.Size(255, 56);
            this.btnLoadSingle.TabIndex = 12;
            this.btnLoadSingle.Text = "Load Single Data";
            this.btnLoadSingle.UseVisualStyleBackColor = false;
            this.btnLoadSingle.Click += new System.EventHandler(this.btnLoadWeight_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Location = new System.Drawing.Point(75, 96);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(255, 54);
            this.btnLoadData.TabIndex = 11;
            this.btnLoadData.Text = "Load new dataset";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadDataAndCreateNetwork_Click);
            // 
            // gbKohonen
            // 
            this.gbKohonen.AutoSize = true;
            this.gbKohonen.Controls.Add(this.panelStatus);
            this.gbKohonen.Controls.Add(this.sofmVisualizer);
            this.gbKohonen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKohonen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbKohonen.Location = new System.Drawing.Point(0, 0);
            this.gbKohonen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbKohonen.Name = "gbKohonen";
            this.gbKohonen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbKohonen.Size = new System.Drawing.Size(1025, 1117);
            this.gbKohonen.TabIndex = 0;
            this.gbKohonen.TabStop = false;
            this.gbKohonen.Text = "Kohonen map";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.SystemColors.MenuText;
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.lblTime);
            this.panelStatus.Location = new System.Drawing.Point(-18, 1056);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1043, 62);
            this.panelStatus.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(351, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(186, 20);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time Elapsed: 0 seconds";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Location = new System.Drawing.Point(71, 610);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // sofmVisualizer
            // 
            this.sofmVisualizer.Location = new System.Drawing.Point(4, 32);
            this.sofmVisualizer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sofmVisualizer.Matrix = null;
            this.sofmVisualizer.Name = "sofmVisualizer";
            this.sofmVisualizer.Size = new System.Drawing.Size(1021, 1016);
            this.sofmVisualizer.TabIndex = 3;
            this.sofmVisualizer.ZoomFactor = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 1117);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SOFM Demo Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbKohonen.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbKohonen;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ToolTip toolTip;
        private SOFMVisualizer sofmVisualizer;
        private System.Windows.Forms.Panel panelLegend;
        private System.Windows.Forms.Button btnLoadSingle;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTime;
    }
}

