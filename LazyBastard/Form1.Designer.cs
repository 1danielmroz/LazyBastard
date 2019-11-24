namespace LazyBastard
{
    partial class lazyBastard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startButton = new System.Windows.Forms.Button();
            this.targetFolderButton = new System.Windows.Forms.Button();
            this.destinationButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.fileChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logBox = new System.Windows.Forms.TextBox();
            this.startedTimeLabel = new System.Windows.Forms.Label();
            this.numberFilesMaped = new System.Windows.Forms.Label();
            this.movedFilesLabel = new System.Windows.Forms.Label();
            this.finishTimeLabel = new System.Windows.Forms.Label();
            this.timeTakenLabel = new System.Windows.Forms.Label();
            this.specGrup = new System.Windows.Forms.GroupBox();
            this.extensionCheckListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileChart)).BeginInit();
            this.specGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(12, 146);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 45);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // targetFolderButton
            // 
            this.targetFolderButton.Location = new System.Drawing.Point(12, 46);
            this.targetFolderButton.Name = "targetFolderButton";
            this.targetFolderButton.Size = new System.Drawing.Size(166, 44);
            this.targetFolderButton.TabIndex = 1;
            this.targetFolderButton.Text = "Chose Target Directory";
            this.targetFolderButton.UseVisualStyleBackColor = true;
            this.targetFolderButton.Click += new System.EventHandler(this.targetFolderButton_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.Enabled = false;
            this.destinationButton.Location = new System.Drawing.Point(12, 96);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(166, 44);
            this.destinationButton.TabIndex = 2;
            this.destinationButton.Text = "Chose Destination Directory";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(166, 34);
            this.title.TabIndex = 3;
            this.title.Text = "Lazy Bastard";
            // 
            // fileChart
            // 
            this.fileChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.fileChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.fileChart.Legends.Add(legend3);
            this.fileChart.Location = new System.Drawing.Point(197, 12);
            this.fileChart.Name = "fileChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.fileChart.Series.Add(series3);
            this.fileChart.Size = new System.Drawing.Size(755, 444);
            this.fileChart.TabIndex = 4;
            this.fileChart.Text = "chart1";
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(197, 466);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(755, 101);
            this.logBox.TabIndex = 5;
            // 
            // startedTimeLabel
            // 
            this.startedTimeLabel.AutoSize = true;
            this.startedTimeLabel.Location = new System.Drawing.Point(6, 29);
            this.startedTimeLabel.Name = "startedTimeLabel";
            this.startedTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.startedTimeLabel.TabIndex = 6;
            this.startedTimeLabel.Text = "Start Time :";
            // 
            // numberFilesMaped
            // 
            this.numberFilesMaped.AutoSize = true;
            this.numberFilesMaped.Location = new System.Drawing.Point(6, 16);
            this.numberFilesMaped.Name = "numberFilesMaped";
            this.numberFilesMaped.Size = new System.Drawing.Size(70, 13);
            this.numberFilesMaped.TabIndex = 7;
            this.numberFilesMaped.Text = "Files Maped :";
            // 
            // movedFilesLabel
            // 
            this.movedFilesLabel.AutoSize = true;
            this.movedFilesLabel.Location = new System.Drawing.Point(6, 42);
            this.movedFilesLabel.Name = "movedFilesLabel";
            this.movedFilesLabel.Size = new System.Drawing.Size(70, 13);
            this.movedFilesLabel.TabIndex = 8;
            this.movedFilesLabel.Text = "Moved Files :";
            // 
            // finishTimeLabel
            // 
            this.finishTimeLabel.AutoSize = true;
            this.finishTimeLabel.Location = new System.Drawing.Point(6, 55);
            this.finishTimeLabel.Name = "finishTimeLabel";
            this.finishTimeLabel.Size = new System.Drawing.Size(69, 13);
            this.finishTimeLabel.TabIndex = 9;
            this.finishTimeLabel.Text = "Finish Time  :";
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.Location = new System.Drawing.Point(6, 68);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(70, 13);
            this.timeTakenLabel.TabIndex = 10;
            this.timeTakenLabel.Text = "Time Taken :";
            // 
            // specGrup
            // 
            this.specGrup.Controls.Add(this.timeTakenLabel);
            this.specGrup.Controls.Add(this.numberFilesMaped);
            this.specGrup.Controls.Add(this.movedFilesLabel);
            this.specGrup.Controls.Add(this.startedTimeLabel);
            this.specGrup.Controls.Add(this.finishTimeLabel);
            this.specGrup.Location = new System.Drawing.Point(12, 197);
            this.specGrup.Name = "specGrup";
            this.specGrup.Size = new System.Drawing.Size(166, 87);
            this.specGrup.TabIndex = 11;
            this.specGrup.TabStop = false;
            this.specGrup.Text = "Specs";
            // 
            // extensionCheckListBox
            // 
            this.extensionCheckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.extensionCheckListBox.Enabled = false;
            this.extensionCheckListBox.FormattingEnabled = true;
            this.extensionCheckListBox.Location = new System.Drawing.Point(12, 290);
            this.extensionCheckListBox.Name = "extensionCheckListBox";
            this.extensionCheckListBox.Size = new System.Drawing.Size(166, 274);
            this.extensionCheckListBox.TabIndex = 12;
            // 
            // lazyBastard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 579);
            this.Controls.Add(this.extensionCheckListBox);
            this.Controls.Add(this.specGrup);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.fileChart);
            this.Controls.Add(this.title);
            this.Controls.Add(this.destinationButton);
            this.Controls.Add(this.targetFolderButton);
            this.Controls.Add(this.startButton);
            this.Name = "lazyBastard";
            this.Text = "Lazy Bastard Form";
            ((System.ComponentModel.ISupportInitialize)(this.fileChart)).EndInit();
            this.specGrup.ResumeLayout(false);
            this.specGrup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button targetFolderButton;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataVisualization.Charting.Chart fileChart;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label startedTimeLabel;
        private System.Windows.Forms.Label movedFilesLabel;
        private System.Windows.Forms.Label finishTimeLabel;
        private System.Windows.Forms.Label timeTakenLabel;
        private System.Windows.Forms.GroupBox specGrup;
        private System.Windows.Forms.CheckedListBox extensionCheckListBox;
        public System.Windows.Forms.Label numberFilesMaped;
    }
}

