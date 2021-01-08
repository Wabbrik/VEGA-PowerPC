namespace VegaPowerPC
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
            this.numericUpDownNumberOfGenerations = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfGenerations = new System.Windows.Forms.Label();
            this.labelPopulationSize = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMutationChance = new System.Windows.Forms.Label();
            this.labelCrossoverChance = new System.Windows.Forms.Label();
            this.numericUpDownMutationChance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCrossoverChance = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPowerWight = new System.Windows.Forms.Label();
            this.labelIpcWeight = new System.Windows.Forms.Label();
            this.numericUpDownIpcWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPowerWeight = new System.Windows.Forms.NumericUpDown();
            this.buttonGetLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationSize)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutationChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossoverChance)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIpcWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPowerWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumberOfGenerations
            // 
            this.numericUpDownNumberOfGenerations.Location = new System.Drawing.Point(106, 3);
            this.numericUpDownNumberOfGenerations.Name = "numericUpDownNumberOfGenerations";
            this.numericUpDownNumberOfGenerations.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownNumberOfGenerations.TabIndex = 6;
            this.numericUpDownNumberOfGenerations.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownPopulationSize
            // 
            this.numericUpDownPopulationSize.Location = new System.Drawing.Point(106, 35);
            this.numericUpDownPopulationSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.Name = "numericUpDownPopulationSize";
            this.numericUpDownPopulationSize.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownPopulationSize.TabIndex = 7;
            this.numericUpDownPopulationSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelNumberOfGenerations
            // 
            this.labelNumberOfGenerations.AutoSize = true;
            this.labelNumberOfGenerations.Location = new System.Drawing.Point(3, 0);
            this.labelNumberOfGenerations.Name = "labelNumberOfGenerations";
            this.labelNumberOfGenerations.Size = new System.Drawing.Size(62, 26);
            this.labelNumberOfGenerations.TabIndex = 10;
            this.labelNumberOfGenerations.Text = "Number of generations";
            // 
            // labelPopulationSize
            // 
            this.labelPopulationSize.AutoSize = true;
            this.labelPopulationSize.Location = new System.Drawing.Point(3, 32);
            this.labelPopulationSize.Name = "labelPopulationSize";
            this.labelPopulationSize.Size = new System.Drawing.Size(80, 13);
            this.labelPopulationSize.TabIndex = 11;
            this.labelPopulationSize.Text = "Population Size";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfGenerations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownPopulationSize, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPopulationSize, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownNumberOfGenerations, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 64);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // labelMutationChance
            // 
            this.labelMutationChance.AutoSize = true;
            this.labelMutationChance.Location = new System.Drawing.Point(3, 0);
            this.labelMutationChance.Name = "labelMutationChance";
            this.labelMutationChance.Size = new System.Drawing.Size(57, 26);
            this.labelMutationChance.TabIndex = 15;
            this.labelMutationChance.Text = "Mutation chance(%)";
            // 
            // labelCrossoverChance
            // 
            this.labelCrossoverChance.AutoSize = true;
            this.labelCrossoverChance.Location = new System.Drawing.Point(3, 32);
            this.labelCrossoverChance.Name = "labelCrossoverChance";
            this.labelCrossoverChance.Size = new System.Drawing.Size(57, 26);
            this.labelCrossoverChance.TabIndex = 16;
            this.labelCrossoverChance.Text = "Crossover chance(%)";
            // 
            // numericUpDownMutationChance
            // 
            this.numericUpDownMutationChance.DecimalPlaces = 3;
            this.numericUpDownMutationChance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownMutationChance.Location = new System.Drawing.Point(106, 3);
            this.numericUpDownMutationChance.Name = "numericUpDownMutationChance";
            this.numericUpDownMutationChance.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownMutationChance.TabIndex = 17;
            this.numericUpDownMutationChance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDownCrossoverChance
            // 
            this.numericUpDownCrossoverChance.DecimalPlaces = 3;
            this.numericUpDownCrossoverChance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownCrossoverChance.Location = new System.Drawing.Point(106, 35);
            this.numericUpDownCrossoverChance.Name = "numericUpDownCrossoverChance";
            this.numericUpDownCrossoverChance.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownCrossoverChance.TabIndex = 18;
            this.numericUpDownCrossoverChance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelMutationChance, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownCrossoverChance, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCrossoverChance, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownMutationChance, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 64);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 211);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelPowerWight, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelIpcWeight, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownIpcWeight, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownPowerWeight, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(206, 65);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // labelPowerWight
            // 
            this.labelPowerWight.AutoSize = true;
            this.labelPowerWight.Location = new System.Drawing.Point(3, 32);
            this.labelPowerWight.Name = "labelPowerWight";
            this.labelPowerWight.Size = new System.Drawing.Size(67, 13);
            this.labelPowerWight.TabIndex = 17;
            this.labelPowerWight.Text = "POW weight";
            // 
            // labelIpcWeight
            // 
            this.labelIpcWeight.AutoSize = true;
            this.labelIpcWeight.Location = new System.Drawing.Point(3, 0);
            this.labelIpcWeight.Name = "labelIpcWeight";
            this.labelIpcWeight.Size = new System.Drawing.Size(58, 13);
            this.labelIpcWeight.TabIndex = 16;
            this.labelIpcWeight.Text = "IPC weight";
            // 
            // numericUpDownIpcWeight
            // 
            this.numericUpDownIpcWeight.Location = new System.Drawing.Point(106, 3);
            this.numericUpDownIpcWeight.Name = "numericUpDownIpcWeight";
            this.numericUpDownIpcWeight.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownIpcWeight.TabIndex = 18;
            this.numericUpDownIpcWeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownPowerWeight
            // 
            this.numericUpDownPowerWeight.Location = new System.Drawing.Point(106, 35);
            this.numericUpDownPowerWeight.Name = "numericUpDownPowerWeight";
            this.numericUpDownPowerWeight.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownPowerWeight.TabIndex = 19;
            this.numericUpDownPowerWeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // buttonGetLocation
            // 
            this.buttonGetLocation.Location = new System.Drawing.Point(297, 15);
            this.buttonGetLocation.Name = "buttonGetLocation";
            this.buttonGetLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonGetLocation.TabIndex = 21;
            this.buttonGetLocation.Text = "Get location";
            this.buttonGetLocation.UseVisualStyleBackColor = true;
            this.buttonGetLocation.Click += new System.EventHandler(this.buttonGetLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 264);
            this.Controls.Add(this.buttonGetLocation);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationSize)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutationChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossoverChance)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIpcWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPowerWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGenerations;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulationSize;
        private System.Windows.Forms.Label labelNumberOfGenerations;
        private System.Windows.Forms.Label labelPopulationSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelMutationChance;
        private System.Windows.Forms.Label labelCrossoverChance;
        private System.Windows.Forms.NumericUpDown numericUpDownMutationChance;
        private System.Windows.Forms.NumericUpDown numericUpDownCrossoverChance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonGetLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelPowerWight;
        private System.Windows.Forms.Label labelIpcWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownIpcWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownPowerWeight;
    }
}
