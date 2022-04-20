using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Numerics;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private int condition;
        private double freeElement, firstElement, secondElement, thirdElement, fourthElement, fifthElement;
        private int previousPosition= 0;
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
            this.MouseWheel+=Form_MouseWheel;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            textBoxFindRoofs.Enabled = false;

            textBoxFifthDegree.Enabled = false;
            textBoxFourthDegree.Enabled = false;
            textBoxThirdDegree.Enabled = false;
            textBoxSecondDegree.Enabled = false;

            labelFifthDegree.Enabled = false;
            labelFourthDegree.Enabled = false;
            labelThirdDegree.Enabled = false;
            labelSecondDegree.Enabled = false;

            buttonVerification.Enabled = false;

            buttonBuildGraph.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

        }


        //Проверка корней уравнения
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
            switch (condition)
            {
                case 1:
                    {
                        double EquationOfTheFirstDegree = (freeElement * (-1)) / firstElement;
                        eq = EquationOfTheFirstDegree * firstElement + freeElement;
                        if (eq != 0)
                        {
                            stringCondition = "Проверка неверна: ";
                        }
                        MassageBoxWrong(stringCondition, "");
                        break;
                    }
                case 2:
                    {
                        result = Calculation.EquationOfTheSecondDegree(secondElement, firstElement, freeElement);
                        foreach (var item in result)
                        {
                            eq = (Math.Pow(item.Real, 2) - Math.Pow(item.Imaginary, 2)) * secondElement + item.Real * firstElement + freeElement;
                            if (eq != 0)
                            {
                                stringCondition = "Проверка неверна: ";
                                number += eq.ToString() + "\n";
                            }
                        }
                        MassageBoxWrong(stringCondition, number);
                        break;
                    }
                case 3:
                    {
                        result = Calculation.EquationOfTheThirdDegree(thirdElement, secondElement, firstElement, freeElement);
                        foreach (var item in result)
                        {
                            eq = Math.Pow(item.Real, 3) * thirdElement + (Math.Pow(item.Real, 2) - Math.Pow(item.Imaginary, 2)) * secondElement + item.Real * firstElement + freeElement;
                            if (eq != 0)
                            {
                                stringCondition = "Проверка неверна: ";
                                number += eq.ToString() + "\n";
                            }
                        }
                        MassageBoxWrong(stringCondition, number);
                        break;
                    }
                case 4:
                    {
                        result = Calculation.FindingRootsOfHigherDegree(0, fourthElement, thirdElement, secondElement, firstElement, freeElement);
                        foreach (var item in result)
                        {
                            eq = Math.Pow(item.Real, 4) * fourthElement + Math.Pow(item.Real, 3) * thirdElement + (Math.Pow(item.Real, 2) - Math.Pow(item.Imaginary, 2)) * secondElement + item.Real * firstElement + freeElement;
                            if (eq != 0)
                            {
                                stringCondition = "Проверка неверна: ";
                                number += eq.ToString() + "\n";
                            }
                        }
                        MassageBoxWrong(stringCondition, number);
                        break;
                    }
                case 5:
                    {
                        result = Calculation.FindingRootsOfHigherDegree(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);
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
                        break;
                    }
            }
        }

        private void PowButton(int pow)
        {

            textBoxFifthDegree.Enabled = pow > 4;
            textBoxFourthDegree.Enabled = pow > 3;
            textBoxThirdDegree.Enabled = pow > 2;
            textBoxSecondDegree.Enabled = pow > 1;

            labelFifthDegree.Enabled = pow > 4;
            labelFourthDegree.Enabled = pow > 3;
            labelThirdDegree.Enabled = pow > 2;
            labelSecondDegree.Enabled = pow > 1;

            if (pow < 5) textBoxFifthDegree.Text = string.Empty;
            if (pow < 4) textBoxFourthDegree.Text = string.Empty;
            if (pow < 3) textBoxThirdDegree.Text = string.Empty;
            if (pow < 2) textBoxSecondDegree.Text = string.Empty;

            if (pow == 5) textBoxFifthDegree.Focus();
            if (pow == 4) textBoxFourthDegree.Focus();
            if (pow == 3) textBoxThirdDegree.Focus();
            if (pow == 2) textBoxFirstDegree.Focus();
            if (pow == 1) textBoxFreeMember.Focus();
        }

        //Комбо бокс с выбором степени уравнения
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxFindRoofs.Clear();

            textBoxFifthDegree.Clear();
            textBoxFourthDegree.Clear();
            textBoxThirdDegree.Clear();
            textBoxSecondDegree.Clear();
            textBoxFirstDegree.Clear();
            textBoxFreeMember.Clear();

            int.TryParse(comboBox1.Text, out condition);

            switch (condition)
            {
                case 2:
                    {
                        PowButton(condition);
                        break;
                    }
                case 3:
                    {
                        PowButton(condition);
                        break;
                    }
                case 4:
                    {
                        PowButton(condition);
                        break;
                    }
                case 5:
                    {
                        PowButton(condition);
                        break;
                    }
                default:
                    PowButton(condition);
                    break;
            }
        }

        //Нахождение корней уравнения
        private void buttonFindRoofs_Click(object sender, EventArgs e)
        {
            buttonBuildGraph.Enabled = true;

            IEnumerable<Complex> result;
            buttonVerification.Enabled = true;

            textBoxFindRoofs.Clear();

            double.TryParse(textBoxFreeMember.Text, out freeElement);
            double.TryParse(textBoxFirstDegree.Text, out firstElement);
            double.TryParse(textBoxSecondDegree.Text, out secondElement);
            double.TryParse(textBoxThirdDegree.Text, out thirdElement);
            double.TryParse(textBoxFourthDegree.Text, out fourthElement);
            double.TryParse(textBoxFifthDegree.Text, out fifthElement);

            switch (condition)
            {
                case 1:
                    {

                        double EquationOfTheFirstDegree = (freeElement * (-1)) / firstElement;
                        textBoxFindRoofs.Text = textBoxFindRoofs.Text + EquationOfTheFirstDegree.ToString() + Environment.NewLine;
                        break;
                    }
                case 2:
                    {
                        result = Calculation.EquationOfTheSecondDegree(secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + item.ToString() + Environment.NewLine;
                        }


                        break;
                    }
                case 3:
                    {
                        result = Calculation.EquationOfTheThirdDegree(thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + GetString(item) + Environment.NewLine;
                        }
                        break;
                    }
                case 4:
                    {
                        result = Calculation.FindingRootsOfHigherDegree(0,fourthElement, thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + GetString(item) + Environment.NewLine;
                        }
                        break;
                    }
                case 5:
                    {
                        result = Calculation.FindingRootsOfHigherDegree(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + GetString(item) + Environment.NewLine;
                        }
                        break;
                    }
            }
        }

        //Очистка полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxFindRoofs.Clear();
            chart1.Series[0].Points.Clear();

            textBoxFifthDegree.Clear();
            textBoxFourthDegree.Clear();
            textBoxThirdDegree.Clear();
            textBoxSecondDegree.Clear();
            textBoxFirstDegree.Clear();
            textBoxFreeMember.Clear();
        }

        private void buttonBuildGraph_Click(object sender, EventArgs e)
        {
            BuildGraph();
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
    }
}