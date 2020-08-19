namespace GameOfLife
{
    partial class frmMain
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
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblGenerationDetails = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.lblUpdateFrequency = new System.Windows.Forms.Label();
            this.lblTotalGenerations = new System.Windows.Forms.Label();
            this.nudFrequency = new System.Windows.Forms.NumericUpDown();
            this.nudTotalGenerations = new System.Windows.Forms.NumericUpDown();
            this.prgTotal = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSimulationOutput = new System.Windows.Forms.Label();
            this.pnlGenerationSnapshot = new System.Windows.Forms.Panel();
            this.btnDefineStartingGeneration = new System.Windows.Forms.Button();
            this.grpSeedAndSimulationControls = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalGenerations)).BeginInit();
            this.grpSeedAndSimulationControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(496, 30);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(366, 446);
            this.lstLog.TabIndex = 1;
            // 
            // lblGenerationDetails
            // 
            this.lblGenerationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenerationDetails.AutoSize = true;
            this.lblGenerationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerationDetails.Location = new System.Drawing.Point(493, 9);
            this.lblGenerationDetails.Name = "lblGenerationDetails";
            this.lblGenerationDetails.Size = new System.Drawing.Size(148, 18);
            this.lblGenerationDetails.TabIndex = 2;
            this.lblGenerationDetails.Text = "Generation Details";
            // 
            // lblRows
            // 
            this.lblRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(6, 20);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(35, 13);
            this.lblRows.TabIndex = 3;
            this.lblRows.Text = "Rows";
            // 
            // nudRows
            // 
            this.nudRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRows.Location = new System.Drawing.Point(63, 18);
            this.nudRows.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(54, 22);
            this.nudRows.TabIndex = 4;
            this.nudRows.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRows.Validated += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // lblColumns
            // 
            this.lblColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(6, 44);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(53, 13);
            this.lblColumns.TabIndex = 5;
            this.lblColumns.Text = "Columns";
            // 
            // nudColumns
            // 
            this.nudColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudColumns.Location = new System.Drawing.Point(63, 42);
            this.nudColumns.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(54, 22);
            this.nudColumns.TabIndex = 6;
            this.nudColumns.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudColumns.Leave += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFrequency.Location = new System.Drawing.Point(132, 20);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(107, 13);
            this.lblUpdateFrequency.TabIndex = 7;
            this.lblUpdateFrequency.Text = "Update Every (m/s)";
            // 
            // lblTotalGenerations
            // 
            this.lblTotalGenerations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalGenerations.AutoSize = true;
            this.lblTotalGenerations.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGenerations.Location = new System.Drawing.Point(132, 44);
            this.lblTotalGenerations.Name = "lblTotalGenerations";
            this.lblTotalGenerations.Size = new System.Drawing.Size(129, 13);
            this.lblTotalGenerations.TabIndex = 8;
            this.lblTotalGenerations.Text = "Number of generations";
            // 
            // nudFrequency
            // 
            this.nudFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudFrequency.Location = new System.Drawing.Point(269, 18);
            this.nudFrequency.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFrequency.Name = "nudFrequency";
            this.nudFrequency.Size = new System.Drawing.Size(54, 22);
            this.nudFrequency.TabIndex = 9;
            this.nudFrequency.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudTotalGenerations
            // 
            this.nudTotalGenerations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudTotalGenerations.Location = new System.Drawing.Point(269, 42);
            this.nudTotalGenerations.Name = "nudTotalGenerations";
            this.nudTotalGenerations.Size = new System.Drawing.Size(54, 22);
            this.nudTotalGenerations.TabIndex = 10;
            this.nudTotalGenerations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // prgTotal
            // 
            this.prgTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prgTotal.Location = new System.Drawing.Point(496, 479);
            this.prgTotal.Name = "prgTotal";
            this.prgTotal.Size = new System.Drawing.Size(366, 23);
            this.prgTotal.Step = 1;
            this.prgTotal.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(787, 508);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 31);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // lblSimulationOutput
            // 
            this.lblSimulationOutput.AutoSize = true;
            this.lblSimulationOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulationOutput.Location = new System.Drawing.Point(12, 9);
            this.lblSimulationOutput.Name = "lblSimulationOutput";
            this.lblSimulationOutput.Size = new System.Drawing.Size(152, 18);
            this.lblSimulationOutput.TabIndex = 14;
            this.lblSimulationOutput.Text = "Current Generation";
            // 
            // pnlGenerationSnapshot
            // 
            this.pnlGenerationSnapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGenerationSnapshot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGenerationSnapshot.Location = new System.Drawing.Point(15, 30);
            this.pnlGenerationSnapshot.Name = "pnlGenerationSnapshot";
            this.pnlGenerationSnapshot.Size = new System.Drawing.Size(469, 472);
            this.pnlGenerationSnapshot.TabIndex = 15;
            // 
            // btnDefineStartingGeneration
            // 
            this.btnDefineStartingGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefineStartingGeneration.Location = new System.Drawing.Point(352, 508);
            this.btnDefineStartingGeneration.Name = "btnDefineStartingGeneration";
            this.btnDefineStartingGeneration.Size = new System.Drawing.Size(79, 63);
            this.btnDefineStartingGeneration.TabIndex = 16;
            this.btnDefineStartingGeneration.Text = "Define Starting Generation";
            this.btnDefineStartingGeneration.UseVisualStyleBackColor = true;
            this.btnDefineStartingGeneration.Click += new System.EventHandler(this.btnDefineStartingGeneration_Click);
            // 
            // grpSeedAndSimulationControls
            // 
            this.grpSeedAndSimulationControls.Controls.Add(this.lblRows);
            this.grpSeedAndSimulationControls.Controls.Add(this.nudRows);
            this.grpSeedAndSimulationControls.Controls.Add(this.lblUpdateFrequency);
            this.grpSeedAndSimulationControls.Controls.Add(this.nudFrequency);
            this.grpSeedAndSimulationControls.Controls.Add(this.nudColumns);
            this.grpSeedAndSimulationControls.Controls.Add(this.lblColumns);
            this.grpSeedAndSimulationControls.Controls.Add(this.nudTotalGenerations);
            this.grpSeedAndSimulationControls.Controls.Add(this.lblTotalGenerations);
            this.grpSeedAndSimulationControls.Location = new System.Drawing.Point(15, 502);
            this.grpSeedAndSimulationControls.Name = "grpSeedAndSimulationControls";
            this.grpSeedAndSimulationControls.Size = new System.Drawing.Size(331, 69);
            this.grpSeedAndSimulationControls.TabIndex = 17;
            this.grpSeedAndSimulationControls.TabStop = false;
            this.grpSeedAndSimulationControls.Text = "Seed/Simulation Controls";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(787, 540);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 581);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpSeedAndSimulationControls);
            this.Controls.Add(this.btnDefineStartingGeneration);
            this.Controls.Add(this.pnlGenerationSnapshot);
            this.Controls.Add(this.lblSimulationOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.prgTotal);
            this.Controls.Add(this.lblGenerationDetails);
            this.Controls.Add(this.lstLog);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(890, 620);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalGenerations)).EndInit();
            this.grpSeedAndSimulationControls.ResumeLayout(false);
            this.grpSeedAndSimulationControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label lblGenerationDetails;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label lblUpdateFrequency;
        private System.Windows.Forms.Label lblTotalGenerations;
        private System.Windows.Forms.NumericUpDown nudFrequency;
        private System.Windows.Forms.NumericUpDown nudTotalGenerations;
        private System.Windows.Forms.ProgressBar prgTotal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSimulationOutput;
        private System.Windows.Forms.Panel pnlGenerationSnapshot;
        private System.Windows.Forms.Button btnDefineStartingGeneration;
        private System.Windows.Forms.GroupBox grpSeedAndSimulationControls;
        private System.Windows.Forms.Button btnReset;
    }
}

