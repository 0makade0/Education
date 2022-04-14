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
        private double startCoordinat = -10;
        private double endCoordinat = 10;

        private static string GetString(Complex complex)
        {
            if (complex.Imaginary == 0)
                return complex.Real.ToString();
            else
                return complex.Real.ToString() + " + " + complex.Imaginary.ToString() + "i";
        }

        private static bool GetNumVerification(Complex complex)
        {
            if (complex.Real + complex.Imaginary == complex.Real)
                return true;
            else
                return false;
        }

        private static double GetNum(Complex complex) => complex.Real + complex.Imaginary;

        //Проверка корней уравнения
        private void buttonVerification_Click(object sender, EventArgs e)
        {
            double[] result = new double[condition];

            double eq;

            string stringCondition = "Проверка верна";

            switch (condition)
            {
                case 1:
                    {
                        double EquationOfTheFirstDegree = (freeElement * (-1)) / firstElement;
                        eq = EquationOfTheFirstDegree * firstElement + freeElement;
                        Console.WriteLine(eq);
                        if(eq==0)
                        {
                            MessageBox.Show(
                                stringCondition,
                                "Проверка корней уравнения",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.None,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show(
                               $"Проверка не верна:{eq}",
                               "Проверка корней уравнения",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
                        }
                        break;
                    }
                case 2:
                    {
                        result = Calculation.EquationOfTheSecondDegree(secondElement, firstElement, freeElement);
                        for (int i = 0; i < result.Length; i++)
                        {
                            eq = Math.Pow(result[i],2)*secondElement+result[i] * firstElement + freeElement;
                            if(eq!=0)
                            {
                                stringCondition = $"Проверка неверна: {eq}";
                            }
                        }
                        MessageBox.Show(
                               stringCondition,
                               "Проверка корней уравнения",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
                        break;
                    }
                case 3:
                    {

                        var result1 = Calculation.EquationOfTheThirdDegree(thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result1)
                        {
                            if (GetNumVerification(item)==true)
                            {
                                eq = Math.Pow(GetNum(item), 3) * thirdElement + Math.Pow(GetNum(item), 2) * secondElement + GetNum(item) * firstElement + freeElement;
                                if (eq > 1)
                                {
                                    stringCondition = $"Проверка верна: {eq}";
                                }
                                else
                                {
                                    stringCondition = "Проверка корней с комплексными числами находится в разработке";
                                }
                            }
                        }
                        MessageBox.Show(
                               stringCondition,
                               "Проверка корней уравнения",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
                        break;
                    }
                case 4:
                    {

                        List<string> res = Calculation.EquationOfTheFourthDegree(fourthElement, thirdElement, secondElement, firstElement, freeElement);

                        for (int i = 0; i < result.Length; i++)
                        {
                            eq = Math.Pow(result[i], 4) * fourthElement+ Math.Pow(result[i], 3) * thirdElement + Math.Pow(result[i], 2) * secondElement + result[i] * firstElement + freeElement;
                            if (eq != 0)
                            {
                                stringCondition = $"Проверка неверна: {eq}";
                            }
                        }
                        MessageBox.Show(
                               stringCondition,
                               "Проверка корней уравнения",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
                        break;
                    }
                case 5:
                    {

                        List<string> res = Calculation.EquationOfTheFifthDegree(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);


                        for (int i = 0; i < result.Length; i++)
                        {
                            eq = Math.Pow(result[i], 4) *fifthElement + Math.Pow(result[i], 4) * fourthElement + Math.Pow(result[i], 3) * thirdElement + Math.Pow(result[i], 2) * secondElement + result[i] * firstElement + freeElement;
                            if (eq != 0)
                            {
                                stringCondition = $"Проверка неверна: {eq}";
                            }
                        }
                        MessageBox.Show(
                               stringCondition,
                               "Проверка корней уравнения",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
                        break;
                    }
                default:
                    {
                        double EquationOfTheFirstDegree = (freeElement * (-1)) / firstElement;
                        eq = EquationOfTheFirstDegree * firstElement + freeElement;
                        Console.WriteLine(eq);
                        if (eq == 0)
                        {
                            MessageBox.Show(
                                "Проверка верна",
                                "Проверка корней уравнения",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.None,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show(
                               $"Проверка не верна:{eq}",
                               "Проверка корней уравнения",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
                        }
                        break;
                    }
            }
        }

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                        textBoxSecondDegree.Enabled = true;
                        labelSecondDegree.Enabled = true;

                        textBoxFourthDegree.Enabled = false;
                        labelFourthDegree.Enabled = false;
                        textBoxFifthDegree.Enabled = false;
                        labelFifthDegree.Enabled = false;
                        textBoxThirdDegree.Enabled = false;
                        labelThirdDegree.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        textBoxSecondDegree.Enabled = true;
                        labelSecondDegree.Enabled = true;
                        textBoxThirdDegree.Enabled = true;
                        labelThirdDegree.Enabled = true;

                        textBoxFourthDegree.Enabled = false;
                        labelFourthDegree.Enabled = false;
                        textBoxFifthDegree.Enabled = false;
                        labelFifthDegree.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        textBoxSecondDegree.Enabled = true;
                        labelSecondDegree.Enabled = true;
                        textBoxThirdDegree.Enabled = true;
                        labelThirdDegree.Enabled = true;
                        textBoxFourthDegree.Enabled = true;
                        labelFourthDegree.Enabled = true;

                        textBoxFifthDegree.Enabled = false;
                        labelFifthDegree.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        textBoxSecondDegree.Enabled = true;
                        labelSecondDegree.Enabled = true;
                        textBoxThirdDegree.Enabled = true;
                        labelThirdDegree.Enabled = true;
                        textBoxFourthDegree.Enabled = true;
                        labelFourthDegree.Enabled = true;
                        textBoxFifthDegree.Enabled = true;
                        labelFifthDegree.Enabled = true;
                        break;
                    }
                default:
                    textBoxSecondDegree.Enabled = false;
                    labelSecondDegree.Enabled = false;
                    textBoxFourthDegree.Enabled = false;
                    labelFourthDegree.Enabled = false;
                    textBoxFifthDegree.Enabled = false;
                    labelFifthDegree.Enabled = false;
                    textBoxThirdDegree.Enabled = false;
                    labelThirdDegree.Enabled = false;
                    break;
            }
        }


        //Нахождение корней уравнения
        private void buttonFindRoofs_Click(object sender, EventArgs e)
        {
            buttonBuildGraph.Enabled = true;

            double[] result = new double[condition];
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
                        var result1 = Calculation.EquationOfTheThirdDegree(thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result1)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + GetString(item) + Environment.NewLine;
                        }
                        break;
                    }
                case 4:
                    {
                       List<string> res= Calculation.EquationOfTheFourthDegree(fourthElement, thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in res)   
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + item.ToString() + Environment.NewLine;
                        }
                        break;
                    }
                case 5:
                    {
                        List<string> res = Calculation.EquationOfTheFifthDegree(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in res)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + item.ToString() + Environment.NewLine;
                        }
                        break;
                    }
                default:
                    {
                        double EquationOfTheFirstDegree = (freeElement * (-1)) / firstElement;

                        textBoxFindRoofs.Text = textBoxFindRoofs.Text + EquationOfTheFirstDegree.ToString() + Environment.NewLine;
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
            chart1.Series[0].Points.Clear();

            BuildGraph();
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
        private void BuildGraph()
        {
            chart1.Series[0].Points.Clear();

            for (double i = startCoordinat; i <= endCoordinat; i += 0.1)
            {
                double y = fifthElement * Math.Pow(i, 5) + fourthElement * Math.Pow(i, 4) + thirdElement * Math.Pow(i, 3) + secondElement * Math.Pow(i, 2) + firstElement * i + freeElement;
                chart1.Series[0].Points.AddXY(i, y);
            }
        }
    }
}
