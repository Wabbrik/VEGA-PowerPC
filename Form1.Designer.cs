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
            this.SuperScalarFactorLabel = new System.Windows.Forms.Label();
            this.RenameSizeLabel = new System.Windows.Forms.Label();
            this.SeparateDecodeDispatchLabel = new System.Windows.Forms.Label();
            this.ReservationArchitectureLabel = new System.Windows.Forms.Label();
            this.ResStationsPerBufferLabel = new System.Windows.Forms.Label();
            this.IntegerExecutionUnitsLabel = new System.Windows.Forms.Label();
            this.FloatingPointEULabel = new System.Windows.Forms.Label();
            this.BranchEULabel = new System.Windows.Forms.Label();
            this.MemoryEULabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ipcLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.ReorderSizeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownNumberOfGenerations
            // 
            this.numericUpDownNumberOfGenerations.Location = new System.Drawing.Point(127, 3);
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
            this.numericUpDownPopulationSize.Location = new System.Drawing.Point(127, 45);
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
            this.labelNumberOfGenerations.Size = new System.Drawing.Size(114, 13);
            this.labelNumberOfGenerations.TabIndex = 10;
            this.labelNumberOfGenerations.Text = "Number of generations";
            // 
            // labelPopulationSize
            // 
            this.labelPopulationSize.AutoSize = true;
            this.labelPopulationSize.Location = new System.Drawing.Point(3, 42);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 85);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // labelMutationChance
            // 
            this.labelMutationChance.AutoSize = true;
            this.labelMutationChance.Location = new System.Drawing.Point(3, 0);
            this.labelMutationChance.Name = "labelMutationChance";
            this.labelMutationChance.Size = new System.Drawing.Size(101, 13);
            this.labelMutationChance.TabIndex = 15;
            this.labelMutationChance.Text = "Mutation chance(%)";
            // 
            // labelCrossoverChance
            // 
            this.labelCrossoverChance.AutoSize = true;
            this.labelCrossoverChance.Location = new System.Drawing.Point(3, 42);
            this.labelCrossoverChance.Name = "labelCrossoverChance";
            this.labelCrossoverChance.Size = new System.Drawing.Size(107, 13);
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
            this.numericUpDownMutationChance.Location = new System.Drawing.Point(127, 3);
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
            this.numericUpDownCrossoverChance.Location = new System.Drawing.Point(127, 45);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 85);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(273, 328);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 221);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(248, 86);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // labelPowerWight
            // 
            this.labelPowerWight.AutoSize = true;
            this.labelPowerWight.Location = new System.Drawing.Point(3, 43);
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
            this.numericUpDownIpcWeight.Location = new System.Drawing.Point(127, 3);
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
            this.numericUpDownPowerWeight.Location = new System.Drawing.Point(127, 46);
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
            this.buttonGetLocation.Location = new System.Drawing.Point(3, 3);
            this.buttonGetLocation.Name = "buttonGetLocation";
            this.buttonGetLocation.Size = new System.Drawing.Size(249, 46);
            this.buttonGetLocation.TabIndex = 21;
            this.buttonGetLocation.Text = "Start Simulation";
            this.buttonGetLocation.UseVisualStyleBackColor = true;
            this.buttonGetLocation.Click += new System.EventHandler(this.buttonGetLocation_Click);
            // 
            // SuperScalarFactorLabel
            // 
            this.SuperScalarFactorLabel.AutoSize = true;
            this.SuperScalarFactorLabel.Location = new System.Drawing.Point(3, 0);
            this.SuperScalarFactorLabel.Name = "SuperScalarFactorLabel";
            this.SuperScalarFactorLabel.Size = new System.Drawing.Size(95, 13);
            this.SuperScalarFactorLabel.TabIndex = 22;
            this.SuperScalarFactorLabel.Text = "SuperScalarFactor";
            // 
            // RenameSizeLabel
            // 
            this.RenameSizeLabel.AutoSize = true;
            this.RenameSizeLabel.Location = new System.Drawing.Point(3, 23);
            this.RenameSizeLabel.Name = "RenameSizeLabel";
            this.RenameSizeLabel.Size = new System.Drawing.Size(95, 13);
            this.RenameSizeLabel.TabIndex = 23;
            this.RenameSizeLabel.Text = "RenameBufferSize";
            // 
            // SeparateDecodeDispatchLabel
            // 
            this.SeparateDecodeDispatchLabel.AutoSize = true;
            this.SeparateDecodeDispatchLabel.Location = new System.Drawing.Point(3, 69);
            this.SeparateDecodeDispatchLabel.Name = "SeparateDecodeDispatchLabel";
            this.SeparateDecodeDispatchLabel.Size = new System.Drawing.Size(87, 13);
            this.SeparateDecodeDispatchLabel.TabIndex = 25;
            this.SeparateDecodeDispatchLabel.Text = "DecodeDispatch";
            // 
            // ReservationArchitectureLabel
            // 
            this.ReservationArchitectureLabel.AutoSize = true;
            this.ReservationArchitectureLabel.Location = new System.Drawing.Point(3, 92);
            this.ReservationArchitectureLabel.Name = "ReservationArchitectureLabel";
            this.ReservationArchitectureLabel.Size = new System.Drawing.Size(121, 13);
            this.ReservationArchitectureLabel.TabIndex = 26;
            this.ReservationArchitectureLabel.Text = "ReservationArchitecture";
            // 
            // ResStationsPerBufferLabel
            // 
            this.ResStationsPerBufferLabel.AutoSize = true;
            this.ResStationsPerBufferLabel.Location = new System.Drawing.Point(3, 115);
            this.ResStationsPerBufferLabel.Name = "ResStationsPerBufferLabel";
            this.ResStationsPerBufferLabel.Size = new System.Drawing.Size(134, 13);
            this.ResStationsPerBufferLabel.TabIndex = 27;
            this.ResStationsPerBufferLabel.Text = "ReservationStations/buffer";
            // 
            // IntegerExecutionUnitsLabel
            // 
            this.IntegerExecutionUnitsLabel.AutoSize = true;
            this.IntegerExecutionUnitsLabel.Location = new System.Drawing.Point(3, 138);
            this.IntegerExecutionUnitsLabel.Name = "IntegerExecutionUnitsLabel";
            this.IntegerExecutionUnitsLabel.Size = new System.Drawing.Size(55, 13);
            this.IntegerExecutionUnitsLabel.TabIndex = 28;
            this.IntegerExecutionUnitsLabel.Text = "IntegerEU";
            // 
            // FloatingPointEULabel
            // 
            this.FloatingPointEULabel.AutoSize = true;
            this.FloatingPointEULabel.Location = new System.Drawing.Point(3, 161);
            this.FloatingPointEULabel.Name = "FloatingPointEULabel";
            this.FloatingPointEULabel.Size = new System.Drawing.Size(83, 13);
            this.FloatingPointEULabel.TabIndex = 29;
            this.FloatingPointEULabel.Text = "FloatingPointEU";
            // 
            // BranchEULabel
            // 
            this.BranchEULabel.AutoSize = true;
            this.BranchEULabel.Location = new System.Drawing.Point(3, 184);
            this.BranchEULabel.Name = "BranchEULabel";
            this.BranchEULabel.Size = new System.Drawing.Size(56, 13);
            this.BranchEULabel.TabIndex = 30;
            this.BranchEULabel.Text = "BranchEU";
            // 
            // MemoryEULabel
            // 
            this.MemoryEULabel.AutoSize = true;
            this.MemoryEULabel.Location = new System.Drawing.Point(3, 207);
            this.MemoryEULabel.Name = "MemoryEULabel";
            this.MemoryEULabel.Size = new System.Drawing.Size(59, 13);
            this.MemoryEULabel.TabIndex = 31;
            this.MemoryEULabel.Text = "MemoryEU";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.SuperScalarFactorLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.MemoryEULabel, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.RenameSizeLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.BranchEULabel, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.FloatingPointEULabel, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.SeparateDecodeDispatchLabel, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.IntegerExecutionUnitsLabel, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.ReservationArchitectureLabel, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.ResStationsPerBufferLabel, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.ReorderSizeLabel, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 11;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(268, 260);
            this.tableLayoutPanel5.TabIndex = 32;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.ipcLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.powerLabel, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 233);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(262, 24);
            this.tableLayoutPanel8.TabIndex = 36;
            // 
            // ipcLabel
            // 
            this.ipcLabel.AutoSize = true;
            this.ipcLabel.Location = new System.Drawing.Point(3, 0);
            this.ipcLabel.Name = "ipcLabel";
            this.ipcLabel.Size = new System.Drawing.Size(21, 13);
            this.ipcLabel.TabIndex = 33;
            this.ipcLabel.Text = "ipc";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(134, 0);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(36, 13);
            this.powerLabel.TabIndex = 35;
            this.powerLabel.Text = "power";
            // 
            // ReorderSizeLabel
            // 
            this.ReorderSizeLabel.AutoSize = true;
            this.ReorderSizeLabel.Location = new System.Drawing.Point(3, 46);
            this.ReorderSizeLabel.Name = "ReorderSizeLabel";
            this.ReorderSizeLabel.Size = new System.Drawing.Size(65, 13);
            this.ReorderSizeLabel.TabIndex = 32;
            this.ReorderSizeLabel.Text = "ReorderSize";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonGetLocation, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(282, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.14074F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.85926F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(274, 328);
            this.tableLayoutPanel6.TabIndex = 33;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(559, 334);
            this.tableLayoutPanel7.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 338);
            this.Controls.Add(this.tableLayoutPanel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PowerPC Automatic Design Space Explorer";
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
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
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
        private System.Windows.Forms.Label SuperScalarFactorLabel;
        private System.Windows.Forms.Label RenameSizeLabel;
        private System.Windows.Forms.Label SeparateDecodeDispatchLabelReorderSizeLabel;
        private System.Windows.Forms.Label SeparateDecodeDispatchLabel;
        private System.Windows.Forms.Label ReservationArchitectureLabel;
        private System.Windows.Forms.Label ResStationsPerBufferLabel;
        private System.Windows.Forms.Label IntegerExecutionUnitsLabel;
        private System.Windows.Forms.Label FloatingPointEULabel;
        private System.Windows.Forms.Label BranchEULabel;
        private System.Windows.Forms.Label MemoryEULabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label ipcLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label ReorderSizeLabel;
    }
}
