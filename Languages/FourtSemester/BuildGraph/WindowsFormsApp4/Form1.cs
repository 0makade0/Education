using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private double freeElement, firstElement, secondElement, thirdElement, fourthElement, fifthElement;
        private int previousPosition = 0;
        private int currentPosition = 0;
        private static double startCoordinat = -10;
        private static double endCoordinat = 10;
        private int mouseWheel = 0;
        private bool mouseChartHover = true;

        private static string GetString(Complex complex)
        {
            if (complex.Imaginary == 0)
                return complex.Real.ToString();
            else
                return complex.Real.ToString() + " + " + complex.Imaginary.ToString() + "i";
        }

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MouseWheel += Form_MouseWheel;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonVerification.Enabled = false;

            buttonBuildGraph.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void buttonFindRoofs_Click(object sender, EventArgs e)
        {
            IEnumerable<Complex> result;

            buttonBuildGraph.Enabled = true;
            buttonVerification.Enabled = true;

            textBoxFindRoots.Clear(); 

            double.TryParse(numericFreeDegree.Text, out freeElement);
            double.TryParse(numericFirstDegree.Text, out firstElement);
            double.TryParse(numericSecondDegree.Text, out secondElement);
            double.TryParse(numericThirdDegree.Text, out thirdElement);
            double.TryParse(numericFourthDegree.Text, out fourthElement);
            double.TryParse(numericFifthDegree.Text, out fifthElement);

            result = Calculation.InputFactors(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);

            foreach (var item in result)
            {
                textBoxFindRoots.Text = textBoxFindRoots.Text + GetString(item) + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(textBoxFindRoots.Text)) textBoxFindRoots.Text = "Нет корней";
        }

        private void buttonVerification_Click(object sender, EventArgs e)
        {
            IEnumerable<Complex> result;
            double eq;
            string stringCondition = "Проверка верна";
            string number = "";
            void MassageBoxWrong(string text1, string text2)
            {
                MessageBox.Show(
                    text1 + text2, "Проверка корней уравнения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }

            result = Calculation.InputFactors(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);
            foreach (var item in result)
            {
                eq = Math.Pow(item.Real, 5) * fifthElement + Math.Pow(item.Real, 4) * fourthElement + Math.Pow(item.Real, 3) * thirdElement + (Math.Pow(item.Real, 2) - Math.Pow(item.Imaginary, 2)) * secondElement + item.Real * firstElement + freeElement;
                if (eq != 0)
                {
                    stringCondition = "Проверка неверна: ";
                    number += eq.ToString() + "\n";
                }
            }
            MassageBoxWrong(stringCondition, number);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numericFifthDegree.Text = "0";
            numericFourthDegree.Text = "0";
            numericThirdDegree.Text = "0";
            numericSecondDegree.Text = "0";
            numericFirstDegree.Text = "0";
            numericFreeDegree.Text = "0";

            textBoxFindRoots.Clear();
            chart1.Series[0].Points.Clear();
        }

        private void textBoxLeftSide_KeyUp(object sender, KeyEventArgs e)
        {
            double newXMin;
            double.TryParse(textBoxLeftSide.Text, out newXMin);
            chart1.ChartAreas[0].AxisX.Minimum = newXMin;
        }

        private void textBoxRightSide_KeyUp(object sender, KeyEventArgs e)
        {
            double newXMax;
            double.TryParse(textBoxRightSide.Text, out newXMax);
            chart1.ChartAreas[0].AxisX.Maximum = newXMax;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentPosition = (Cursor.Position.X - this.Left);

                if (currentPosition > previousPosition)
                {
                    startCoordinat -= 0.5;
                    endCoordinat -= 0.5;
                }
                else
                {
                    startCoordinat += 0.5;
                    endCoordinat += 0.5;
                }

                previousPosition = (Cursor.Position.X - this.Left);
                BuildGraph();
            }
        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            mouseWheel = e.Delta;

            if (mouseChartHover)
            {
                if (mouseWheel < 0)
                {
                    startCoordinat -= 10;
                    endCoordinat += 10;
                }
                else
                {
                    startCoordinat += 10;
                    endCoordinat -= 10;
                }
                Console.WriteLine(mouseWheel);
                BuildGraph();
            }
        }

        private void BuildGraph()
        {
            chart1.Series[0].Points.Clear();

            for (double i = startCoordinat; i <= endCoordinat; i += 0.1)
            {
                double y = fifthElement * Math.Pow(i, 5) + fourthElement * Math.Pow(i, 4) + thirdElement * Math.Pow(i, 3) +
                    secondElement * Math.Pow(i, 2) + firstElement * i + freeElement;
                chart1.Series[0].Points.AddXY(i, y);
            }

            textBoxLeftSide.Text = Math.Round(chart1.ChartAreas[0].AxisX.Minimum, 2).ToString();
            textBoxRightSide.Text = Math.Round(chart1.ChartAreas[0].AxisX.Maximum, 2).ToString();
        }
        private void buttonBuildGraph_Click(object sender, EventArgs e) => BuildGraph();
        private void numericFifthDegree_Leave(object sender, EventArgs e)=>numericFifthDegree.Text = "0";
        private void numericFourthDegree_Leave(object sender, EventArgs e)=> numericFourthDegree.Text = "0";
        private void numericThirdDegree_Leave(object sender, EventArgs e)=> numericThirdDegree.Text = "0";
        private void numericSecondDegree_Leave(object sender, EventArgs e)=> numericSecondDegree.Text = "0";
        private void numericFirstDegree_Leave(object sender, EventArgs e)=> numericFirstDegree.Text = "0";
        private void numericFreeDegree_Leave(object sender, EventArgs e)=> numericFreeDegree.Text = "0";
        private void numericFifthDegree_MouseClick(object sender, MouseEventArgs e) => numericFifthDegree.Select(0, 5);
        private void numericFourthDegree_MouseClick(object sender, MouseEventArgs e) => numericFourthDegree.Select(0, 5);
        private void numericThirdDegree_MouseClick(object sender, MouseEventArgs e) => numericThirdDegree.Select(0, 5);
        private void numericSecondDegree_MouseClick(object sender, MouseEventArgs e) => numericSecondDegree.Select(0, 5);
        private void numericFirstDegree_MouseClick(object sender, MouseEventArgs e) => numericFirstDegree.Select(0, 5);
        private void numericFreeDegree_MouseClick(object sender, MouseEventArgs e) => numericFreeDegree.Select(0, 5);
        private void numericFifthDegree_Enter(object sender, EventArgs e) => numericFifthDegree.Select(0, 5);
        private void numericFourthDegree_Enter(object sender, EventArgs e) => numericFourthDegree.Select(0, 5);
        private void numericThirdDegree_Enter(object sender, EventArgs e) => numericThirdDegree.Select(0, 5);
        private void numericSecondDegree_Enter(object sender, EventArgs e) => numericSecondDegree.Select(0, 5);
        private void numericFirstDegree_Enter(object sender, EventArgs e) => numericFirstDegree.Select(0, 5);
        private void numericFreeDegree_Enter(object sender, EventArgs e) => numericFreeDegree.Select(0, 5);
    }
}