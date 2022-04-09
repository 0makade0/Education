using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
        

        //Проверка корней уравнения
        private void buttonVerification_Click(object sender, EventArgs e)
        {
            double[] result = new double[condition];

            double eq;

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
                case 2:
                    {
                        string stringCondition = "Проверка верна";
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
                        string stringCondition = "Проверка верна";

                        result = Calculation.EquationOfTheThirdDegree(thirdElement, secondElement, firstElement, freeElement);

                        for (int i = 0; i < result.Length; i++)
                        {
                            eq = Math.Pow(result[i], 3) * thirdElement+ Math.Pow(result[i], 2) * secondElement + result[i] * firstElement + freeElement;
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
                case 4:
                    {
                        string stringCondition = "Проверка верна";

                        result = Calculation.EquationOfTheFourthDegree(fourthElement, thirdElement, secondElement, firstElement, freeElement);

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
                        string stringCondition = "Проверка верна";

                        result = Calculation.EquationOfTheFifthDegree(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);


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
            this.MouseClick += new MouseEventHandler(chart1_MouseClick);
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
                        if (firstElement == 0)
                            throw new DivideByZeroException();

                        double EquationOfTheFirstDegree = (freeElement * (-1)) / firstElement;
                        textBoxFindRoofs.Text = textBoxFindRoofs.Text + EquationOfTheFirstDegree.ToString() + Environment.NewLine;
                        break;
                    }
                case 2:
                    {
                        if (firstElement == 0)
                            throw new DivideByZeroException();

                        result = Calculation.EquationOfTheSecondDegree(secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + item.ToString() + Environment.NewLine;
                        }


                        break;
                    }
                case 3:
                    {
                        if (firstElement == 0)
                            throw new DivideByZeroException();

                        result = Calculation.EquationOfTheThirdDegree(thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + item.ToString() + Environment.NewLine;
                        }
                        break;
                    }
                case 4:
                    {
                        if (firstElement == 0)
                            throw new DivideByZeroException();

                        result = Calculation.EquationOfTheFourthDegree(fourthElement, thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + item.ToString() + Environment.NewLine;
                        }
                        break;
                    }
                case 5:
                    {
                        if (firstElement == 0)
                            throw new DivideByZeroException();

                        result = Calculation.EquationOfTheFifthDegree(fifthElement, fourthElement, thirdElement, secondElement, firstElement, freeElement);

                        foreach (var item in result)
                        {
                            textBoxFindRoofs.Text = textBoxFindRoofs.Text + item.ToString() + Environment.NewLine;
                        }
                        break;
                    }
                default:
                    {
                        if (firstElement == 0)
                            throw new DivideByZeroException();

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

        private void chart1_MouseClick(object sender, MouseEventArgs e)
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
