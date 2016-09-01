using Oscilloscope.Controllers;
using Oscilloscope.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope.Views
{
    public partial class AnalysisForm : Form
    {
        private Sample currentSample;
        private int sampleRate;

        AnalysisController acontroller = null;

        public AnalysisForm(Sample currentSample, int sampleRate)
        {
            InitializeComponent();

            this.currentSample = currentSample;
            this.sampleRate = sampleRate;

            acontroller = new AnalysisController(currentSample, sampleRate);
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            comboBoxNbHarmonics.SelectedIndex = 2;
        }

        private void fftButton_Click(object sender, EventArgs e)
        {
            int noOfHarmonics = Int32.Parse(comboBoxNbHarmonics.SelectedItem.ToString());

            string harmonicsTable;
            int fundamentalFrequency;
            var harmonics = acontroller.CalculateHarmonics(noOfHarmonics, out harmonicsTable, out fundamentalFrequency);

            chartAnalysis.Series[0].Points.Clear();
            for (int i = 0; i < harmonics.Count(); i++)
            {
                chartAnalysis.Series[0].Points.AddXY(i, harmonics[i]);
            }

            harmonicsTableTextBox.Text = harmonicsTable;
            labelFundamentalFrequency.Text = fundamentalFrequency.ToString() + " Hz";
        }

        private void idftButton_Click(object sender, EventArgs e)
        {
            int noOfHarmonics = Int32.Parse(comboBoxNbHarmonics.SelectedItem.ToString());

            string harmonicsTable;
            int fundamentalFrequency;
            var idftSignal = acontroller.CalculateIDFT(noOfHarmonics, out harmonicsTable, out fundamentalFrequency);

            chartAnalysis.Series[0].Points.Clear();
            for (int i = 0; i < idftSignal.Count(); i++)
            {
                //chart1.Series[0].Points.AddXY(i, CalcMagnitude(FFT_transform.y[i].real, FFT_transform.y[i].imag));

                chartAnalysis.Series[0].Points.AddXY(i, idftSignal[i]);
                //
            }

            labelFundamentalFrequency.Text = fundamentalFrequency.ToString() + " Hz";
        }
    }
}

