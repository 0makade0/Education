
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelOfEnterEqual = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxFifthDegree = new System.Windows.Forms.TextBox();
            this.labelFifthDegree = new System.Windows.Forms.Label();
            this.labelFourthDegree = new System.Windows.Forms.Label();
            this.textBoxFourthDegree = new System.Windows.Forms.TextBox();
            this.labelThirdDegree = new System.Windows.Forms.Label();
            this.textBoxThirdDegree = new System.Windows.Forms.TextBox();
            this.labelSecondDegree = new System.Windows.Forms.Label();
            this.textBoxSecondDegree = new System.Windows.Forms.TextBox();
            this.labelThirstDegree = new System.Windows.Forms.Label();
            this.textBoxFirstDegree = new System.Windows.Forms.TextBox();
            this.textBoxFreeMember = new System.Windows.Forms.TextBox();
            this.labelEquals = new System.Windows.Forms.Label();
            this.buttonFindRoofs = new System.Windows.Forms.Button();
            this.textBoxFindRoofs = new System.Windows.Forms.TextBox();
            this.buttonVerification = new System.Windows.Forms.Button();
            this.buttonBuildGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOfEnterEqual
            // 
            this.labelOfEnterEqual.AutoSize = true;
            this.labelOfEnterEqual.Location = new System.Drawing.Point(3, 9);
            this.labelOfEnterEqual.Name = "labelOfEnterEqual";
            this.labelOfEnterEqual.Size = new System.Drawing.Size(160, 13);
            this.labelOfEnterEqual.TabIndex = 0;
            this.labelOfEnterEqual.Text = "Выберите степень уравнения:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(169, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // textBoxFifthDegree
            // 
            this.textBoxFifthDegree.Location = new System.Drawing.Point(6, 40);
            this.textBoxFifthDegree.Name = "textBoxFifthDegree";
            this.textBoxFifthDegree.Size = new System.Drawing.Size(23, 20);
            this.textBoxFifthDegree.TabIndex = 3;
            // 
            // labelFifthDegree
            // 
            this.labelFifthDegree.AutoSize = true;
            this.labelFifthDegree.Location = new System.Drawing.Point(35, 43);
            this.labelFifthDegree.Name = "labelFifthDegree";
            this.labelFifthDegree.Size = new System.Drawing.Size(30, 13);
            this.labelFifthDegree.TabIndex = 4;
            this.labelFifthDegree.Text = "x^5+";
            // 
            // labelFourthDegree
            // 
            this.labelFourthDegree.AutoSize = true;
            this.labelFourthDegree.Location = new System.Drawing.Point(93, 43);
            this.labelFourthDegree.Name = "labelFourthDegree";
            this.labelFourthDegree.Size = new System.Drawing.Size(30, 13);
            this.labelFourthDegree.TabIndex = 6;
            this.labelFourthDegree.Text = "x^4+";
            // 
            // textBoxFourthDegree
            // 
            this.textBoxFourthDegree.Location = new System.Drawing.Point(64, 40);
            this.textBoxFourthDegree.Name = "textBoxFourthDegree";
            this.textBoxFourthDegree.Size = new System.Drawing.Size(23, 20);
            this.textBoxFourthDegree.TabIndex = 5;
            // 
            // labelThirdDegree
            // 
            this.labelThirdDegree.AutoSize = true;
            this.labelThirdDegree.Location = new System.Drawing.Point(152, 43);
            this.labelThirdDegree.Name = "labelThirdDegree";
            this.labelThirdDegree.Size = new System.Drawing.Size(30, 13);
            this.labelThirdDegree.TabIndex = 8;
            this.labelThirdDegree.Text = "x^3+";
            // 
            // textBoxThirdDegree
            // 
            this.textBoxThirdDegree.Location = new System.Drawing.Point(123, 40);
            this.textBoxThirdDegree.Name = "textBoxThirdDegree";
            this.textBoxThirdDegree.Size = new System.Drawing.Size(23, 20);
            this.textBoxThirdDegree.TabIndex = 7;
            // 
            // labelSecondDegree
            // 
            this.labelSecondDegree.AutoSize = true;
            this.labelSecondDegree.Location = new System.Drawing.Point(210, 43);
            this.labelSecondDegree.Name = "labelSecondDegree";
            this.labelSecondDegree.Size = new System.Drawing.Size(30, 13);
            this.labelSecondDegree.TabIndex = 10;
            this.labelSecondDegree.Text = "x^2+";
            // 
            // textBoxSecondDegree
            // 
            this.textBoxSecondDegree.Location = new System.Drawing.Point(181, 40);
            this.textBoxSecondDegree.Name = "textBoxSecondDegree";
            this.textBoxSecondDegree.Size = new System.Drawing.Size(23, 20);
            this.textBoxSecondDegree.TabIndex = 9;
            // 
            // labelThirstDegree
            // 
            this.labelThirstDegree.AutoSize = true;
            this.labelThirstDegree.Location = new System.Drawing.Point(269, 43);
            this.labelThirstDegree.Name = "labelThirstDegree";
            this.labelThirstDegree.Size = new System.Drawing.Size(18, 13);
            this.labelThirstDegree.TabIndex = 12;
            this.labelThirstDegree.Text = "x+";
            // 
            // textBoxFirstDegree
            // 
            this.textBoxFirstDegree.Location = new System.Drawing.Point(240, 40);
            this.textBoxFirstDegree.Name = "textBoxFirstDegree";
            this.textBoxFirstDegree.Size = new System.Drawing.Size(23, 20);
            this.textBoxFirstDegree.TabIndex = 11;
            // 
            // textBoxFreeMember
            // 
            this.textBoxFreeMember.Location = new System.Drawing.Point(296, 40);
            this.textBoxFreeMember.Name = "textBoxFreeMember";
            this.textBoxFreeMember.Size = new System.Drawing.Size(23, 20);
            this.textBoxFreeMember.TabIndex = 13;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Location = new System.Drawing.Point(325, 43);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(19, 13);
            this.labelEquals.TabIndex = 14;
            this.labelEquals.Text = "=0";
            // 
            // buttonFindRoofs
            // 
            this.buttonFindRoofs.Location = new System.Drawing.Point(372, 40);
            this.buttonFindRoofs.Name = "buttonFindRoofs";
            this.buttonFindRoofs.Size = new System.Drawing.Size(122, 23);
            this.buttonFindRoofs.TabIndex = 15;
            this.buttonFindRoofs.Text = "Найти корни";
            this.buttonFindRoofs.UseVisualStyleBackColor = true;
            this.buttonFindRoofs.Click += new System.EventHandler(this.buttonFindRoofs_Click);
            // 
            // textBoxFindRoofs
            // 
            this.textBoxFindRoofs.Location = new System.Drawing.Point(372, 69);
            this.textBoxFindRoofs.Multiline = true;
            this.textBoxFindRoofs.Name = "textBoxFindRoofs";
            this.textBoxFindRoofs.Size = new System.Drawing.Size(122, 161);
            this.textBoxFindRoofs.TabIndex = 16;
            // 
            // buttonVerification
            // 
            this.buttonVerification.Location = new System.Drawing.Point(372, 236);
            this.buttonVerification.Name = "buttonVerification";
            this.buttonVerification.Size = new System.Drawing.Size(122, 23);
            this.buttonVerification.TabIndex = 17;
            this.buttonVerification.Text = "Проверка";
            this.buttonVerification.UseVisualStyleBackColor = true;
            this.buttonVerification.Click += new System.EventHandler(this.buttonVerification_Click);
            // 
            // buttonBuildGraph
            // 
            this.buttonBuildGraph.Location = new System.Drawing.Point(38, 291);
            this.buttonBuildGraph.Name = "buttonBuildGraph";
            this.buttonBuildGraph.Size = new System.Drawing.Size(306, 23);
            this.buttonBuildGraph.TabIndex = 23;
            this.buttonBuildGraph.Text = "Построить график";
            this.buttonBuildGraph.UseVisualStyleBackColor = true;
            this.buttonBuildGraph.Click += new System.EventHandler(this.buttonBuildGraph_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(6, 69);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(338, 190);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(372, 291);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(122, 23);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 333);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonBuildGraph);
            this.Controls.Add(this.buttonVerification);
            this.Controls.Add(this.textBoxFindRoofs);
            this.Controls.Add(this.buttonFindRoofs);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.textBoxFreeMember);
            this.Controls.Add(this.labelThirstDegree);
            this.Controls.Add(this.textBoxFirstDegree);
            this.Controls.Add(this.labelSecondDegree);
            this.Controls.Add(this.textBoxSecondDegree);
            this.Controls.Add(this.labelThirdDegree);
            this.Controls.Add(this.textBoxThirdDegree);
            this.Controls.Add(this.labelFourthDegree);
            this.Controls.Add(this.textBoxFourthDegree);
            this.Controls.Add(this.labelFifthDegree);
            this.Controls.Add(this.textBoxFifthDegree);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelOfEnterEqual);
            this.Name = "Form1";
            this.Text = "Решение уравнений";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOfEnterEqual;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxFifthDegree;
        private System.Windows.Forms.Label labelFifthDegree;
        private System.Windows.Forms.Label labelFourthDegree;
        private System.Windows.Forms.TextBox textBoxFourthDegree;
        private System.Windows.Forms.Label labelThirdDegree;
        private System.Windows.Forms.TextBox textBoxThirdDegree;
        private System.Windows.Forms.Label labelSecondDegree;
        private System.Windows.Forms.TextBox textBoxSecondDegree;
        private System.Windows.Forms.Label labelThirstDegree;
        private System.Windows.Forms.TextBox textBoxFirstDegree;
        private System.Windows.Forms.TextBox textBoxFreeMember;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.Button buttonFindRoofs;
        private System.Windows.Forms.TextBox textBoxFindRoofs;
        private System.Windows.Forms.Button buttonVerification;
        private System.Windows.Forms.Button buttonBuildGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ClearButton;
    }
}

