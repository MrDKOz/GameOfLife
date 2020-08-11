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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.lblSimulationOutput = new System.Windows.Forms.Label();
            this.pnlGenerationSnapshot = new System.Windows.Forms.Panel();
            this.btnDefineStartingGeneration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalGenerations)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(496, 30);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(366, 446);
            this.lstLog.TabIndex = 1;
            // 
            // lblGenerationDetails
            // 
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
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(12, 513);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(35, 13);
            this.lblRows.TabIndex = 3;
            this.lblRows.Text = "Rows";
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(69, 511);
            this.nudRows.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(54, 22);
            this.nudRows.TabIndex = 4;
            this.nudRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(12, 548);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(53, 13);
            this.lblColumns.TabIndex = 5;
            this.lblColumns.Text = "Columns";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(69, 546);
            this.nudColumns.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(54, 22);
            this.nudColumns.TabIndex = 6;
            this.nudColumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFrequency.Location = new System.Drawing.Point(138, 513);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(107, 13);
            this.lblUpdateFrequency.TabIndex = 7;
            this.lblUpdateFrequency.Text = "Update Every (m/s)";
            // 
            // lblTotalGenerations
            // 
            this.lblTotalGenerations.AutoSize = true;
            this.lblTotalGenerations.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGenerations.Location = new System.Drawing.Point(138, 548);
            this.lblTotalGenerations.Name = "lblTotalGenerations";
            this.lblTotalGenerations.Size = new System.Drawing.Size(129, 13);
            this.lblTotalGenerations.TabIndex = 8;
            this.lblTotalGenerations.Text = "Number of generations";
            // 
            // nudFrequency
            // 
            this.nudFrequency.Location = new System.Drawing.Point(275, 511);
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
            this.nudTotalGenerations.Location = new System.Drawing.Point(275, 546);
            this.nudTotalGenerations.Name = "nudTotalGenerations";
            this.nudTotalGenerations.Size = new System.Drawing.Size(54, 22);
            this.nudTotalGenerations.TabIndex = 10;
            this.nudTotalGenerations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(496, 478);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(366, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Location = new System.Drawing.Point(787, 507);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(75, 63);
            this.btnStartSimulation.TabIndex = 12;
            this.btnStartSimulation.Text = "Start Simulation";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
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
            this.pnlGenerationSnapshot.Location = new System.Drawing.Point(15, 30);
            this.pnlGenerationSnapshot.Name = "pnlGenerationSnapshot";
            this.pnlGenerationSnapshot.Size = new System.Drawing.Size(469, 471);
            this.pnlGenerationSnapshot.TabIndex = 15;
            // 
            // btnDefineStartingGeneration
            // 
            this.btnDefineStartingGeneration.Location = new System.Drawing.Point(702, 507);
            this.btnDefineStartingGeneration.Name = "btnDefineStartingGeneration";
            this.btnDefineStartingGeneration.Size = new System.Drawing.Size(79, 61);
            this.btnDefineStartingGeneration.TabIndex = 16;
            this.btnDefineStartingGeneration.Text = "Define Starting Generation";
            this.btnDefineStartingGeneration.UseVisualStyleBackColor = true;
            this.btnDefineStartingGeneration.Click += new System.EventHandler(this.btnDefineStartingGeneration_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 580);
            this.Controls.Add(this.btnDefineStartingGeneration);
            this.Controls.Add(this.pnlGenerationSnapshot);
            this.Controls.Add(this.lblSimulationOutput);
            this.Controls.Add(this.btnStartSimulation);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nudTotalGenerations);
            this.Controls.Add(this.nudFrequency);
            this.Controls.Add(this.lblTotalGenerations);
            this.Controls.Add(this.lblUpdateFrequency);
            this.Controls.Add(this.nudColumns);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.nudRows);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblGenerationDetails);
            this.Controls.Add(this.lstLog);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalGenerations)).EndInit();
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.Label lblSimulationOutput;
        private System.Windows.Forms.Panel pnlGenerationSnapshot;
        private System.Windows.Forms.Button btnDefineStartingGeneration;
    }
}

