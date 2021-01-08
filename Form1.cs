using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegaPowerPC
{
    public partial class Form1 : Form
    {
        Vega vega;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetLocation_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = folderBrowserDialog.SelectedPath;
            }

            UInt32 populationSize = (uint)numericUpDownPopulationSize.Value;
            UInt32 maxIt = (uint)numericUpDownNumberOfGenerations.Value;
            UInt32 ipcW = (uint)numericUpDownIpcWeight.Value;
            UInt32 powW = (uint)numericUpDownPowerWeight.Value;
            double mutate = (double)numericUpDownMutationChance.Value;
            double xover = (double)numericUpDownCrossoverChance.Value;
            vega = new Vega(filePath, populationSize, maxIt, ipcW, powW, mutate, xover, "compress.tra", 8);
            vega.StartSimulation();
            UIupdateSimulationResults();
        }

        private void UIupdateSimulationResults()
        {
            var best = vega.bestChromosome;
            SuperScalarFactorLabel.Text += " : " + best.SuperScalarFactor;
            RenameSizeLabel.Text += " : " + best.RenameSize;
            ReorderSizeLabel.Text += " : " + best.ReorderSize;
            if (best.SeparateDecodeDispatch == 1)
            {
                SeparateDecodeDispatchLabel.Text += " : true";
            }
            else
            {
                SeparateDecodeDispatchLabel.Text += " : false";
            }
            ReservationArchitectureLabel.Text += " : " + best.ReservationArchitecture;
            ResStationsPerBufferLabel.Text += " : " + best.ResStationsPerBuffer;
            IntegerExecutionUnitsLabel.Text += " : " + best.IntegerEU;
            FloatingPointEULabel.Text += " : " + best.FloatingPointEU;
            BranchEULabel.Text += " : " + best.BranchEU;
            MemoryEULabel.Text += " : " + best.MemEU;
            ipcLabel.Text += " : " + best.ipcValue;
            powerLabel.Text += " : " + best.powerValue;
        }
    }
}