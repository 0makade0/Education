
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelFifthDegree = new System.Windows.Forms.Label();
            this.labelFourthDegree = new System.Windows.Forms.Label();
            this.labelThirdDegree = new System.Windows.Forms.Label();
            this.labelSecondDegree = new System.Windows.Forms.Label();
            this.labelThirstDegree = new System.Windows.Forms.Label();
            this.labelEquals = new System.Windows.Forms.Label();
            this.buttonFindRoots = new System.Windows.Forms.Button();
            this.textBoxFindRoots = new System.Windows.Forms.TextBox();
            this.buttonVerification = new System.Windows.Forms.Button();
            this.buttonBuildGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearButton = new System.Windows.Forms.Button();
            this.textBoxLeftSide = new System.Windows.Forms.TextBox();
            this.textBoxRightSide = new System.Windows.Forms.TextBox();
            this.numericFifthDegree = new System.Windows.Forms.NumericUpDown();
            this.numericFourthDegree = new System.Windows.Forms.NumericUpDown();
            this.numericThirdDegree = new System.Windows.Forms.NumericUpDown();
            this.numericSecondDegree = new System.Windows.Forms.NumericUpDown();
            this.numericFirstDegree = new System.Windows.Forms.NumericUpDown();
            this.numericFreeDegree = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFifthDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFourthDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThirdDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecondDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreeDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFifthDegree
            // 
            this.labelFifthDegree.AutoSize = true;
            this.labelFifthDegree.Location = new System.Drawing.Point(58, 6);
            this.labelFifthDegree.Name = "labelFifthDegree";
            this.labelFifthDegree.Size = new System.Drawing.Size(30, 13);
            this.labelFifthDegree.TabIndex = 4;
            this.labelFifthDegree.Text = "x^5+";
            // 
            // labelFourthDegree
            // 
            this.labelFourthDegree.AutoSize = true;
            this.labelFourthDegree.Location = new System.Drawing.Point(142, 6);
            this.labelFourthDegree.Name = "labelFourthDegree";
            this.labelFourthDegree.Size = new System.Drawing.Size(30, 13);
            this.labelFourthDegree.TabIndex = 6;
            this.labelFourthDegree.Text = "x^4+";
            // 
            // labelThirdDegree
            // 
            this.labelThirdDegree.AutoSize = true;
            this.labelThirdDegree.Location = new System.Drawing.Point(226, 5);
            this.labelThirdDegree.Name = "labelThirdDegree";
            this.labelThirdDegree.Size = new System.Drawing.Size(30, 13);
            this.labelThirdDegree.TabIndex = 8;
            this.labelThirdDegree.Text = "x^3+";
            // 
            // labelSecondDegree
            // 
            this.labelSecondDegree.AutoSize = true;
            this.labelSecondDegree.Location = new System.Drawing.Point(310, 6);
            this.labelSecondDegree.Name = "labelSecondDegree";
            this.labelSecondDegree.Size = new System.Drawing.Size(30, 13);
            this.labelSecondDegree.TabIndex = 10;
            this.labelSecondDegree.Text = "x^2+";
            // 
            // labelThirstDegree
            // 
            this.labelThirstDegree.AutoSize = true;
            this.labelThirstDegree.Location = new System.Drawing.Point(394, 6);
            this.labelThirstDegree.Name = "labelThirstDegree";
            this.labelThirstDegree.Size = new System.Drawing.Size(18, 13);
            this.labelThirstDegree.TabIndex = 12;
            this.labelThirstDegree.Text = "x+";
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Location = new System.Drawing.Point(466, 6);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(19, 13);
            this.labelEquals.TabIndex = 14;
            this.labelEquals.Text = "=0";
            // 
            // buttonFindRoots
            // 
            this.buttonFindRoots.Location = new System.Drawing.Point(451, 196);
            this.buttonFindRoots.Name = "buttonFindRoots";
            this.buttonFindRoots.Size = new System.Drawing.Size(122, 23);
            this.buttonFindRoots.TabIndex = 15;
            this.buttonFindRoots.Text = "Найти корни";
            this.buttonFindRoots.UseVisualStyleBackColor = true;
            this.buttonFindRoots.Click += new System.EventHandler(this.buttonFindRoofs_Click);
            // 
            // textBoxFindRoots
            // 
            this.textBoxFindRoots.Location = new System.Drawing.Point(451, 29);
            this.textBoxFindRoots.Multiline = true;
            this.textBoxFindRoots.Name = "textBoxFindRoots";
            this.textBoxFindRoots.Size = new System.Drawing.Size(122, 161);
            this.textBoxFindRoots.TabIndex = 16;
            // 
            // buttonVerification
            // 
            this.buttonVerification.Location = new System.Drawing.Point(451, 225);
            this.buttonVerification.Name = "buttonVerification";
            this.buttonVerification.Size = new System.Drawing.Size(122, 23);
            this.buttonVerification.TabIndex = 17;
            this.buttonVerification.Text = "Проверка";
            this.buttonVerification.UseVisualStyleBackColor = true;
            this.buttonVerification.Click += new System.EventHandler(this.buttonVerification_Click);
            // 
            // buttonBuildGraph
            // 
            this.buttonBuildGraph.Location = new System.Drawing.Point(12, 254);
            this.buttonBuildGraph.Name = "buttonBuildGraph";
            this.buttonBuildGraph.Size = new System.Drawing.Size(433, 23);
            this.buttonBuildGraph.TabIndex = 23;
            this.buttonBuildGraph.Text = "Построить график";
            this.buttonBuildGraph.UseVisualStyleBackColor = true;
            this.buttonBuildGraph.Click += new System.EventHandler(this.buttonBuildGraph_Click);
            // 
            // chart1
            // 
            chartArea7.AxisX.LabelStyle.Format = "{0:0.0}";
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Location = new System.Drawing.Point(12, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(433, 190);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(451, 254);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(122, 23);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // textBoxLeftSide
            // 
            this.textBoxLeftSide.Location = new System.Drawing.Point(12, 225);
            this.textBoxLeftSide.Name = "textBoxLeftSide";
            this.textBoxLeftSide.Size = new System.Drawing.Size(23, 20);
            this.textBoxLeftSide.TabIndex = 28;
            this.textBoxLeftSide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLeftSide_KeyUp);
            // 
            // textBoxRightSide
            // 
            this.textBoxRightSide.Location = new System.Drawing.Point(422, 225);
            this.textBoxRightSide.Name = "textBoxRightSide";
            this.textBoxRightSide.Size = new System.Drawing.Size(23, 20);
            this.textBoxRightSide.TabIndex = 29;
            this.textBoxRightSide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRightSide_KeyUp);
            // 
            // numericFifthDegree
            // 
            this.numericFifthDegree.Location = new System.Drawing.Point(12, 3);
            this.numericFifthDegree.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFifthDegree.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericFifthDegree.Name = "numericFifthDegree";
            this.numericFifthDegree.Size = new System.Drawing.Size(40, 20);
            this.numericFifthDegree.TabIndex = 30;
            this.numericFifthDegree.Enter += new System.EventHandler(this.numericFifthDegree_Enter);
            this.numericFifthDegree.Leave += new System.EventHandler(this.numericFifthDegree_Leave);
            this.numericFifthDegree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericFifthDegree_MouseClick);
            // 
            // numericFourthDegree
            // 
            this.numericFourthDegree.Location = new System.Drawing.Point(94, 3);
            this.numericFourthDegree.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFourthDegree.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericFourthDegree.Name = "numericFourthDegree";
            this.numericFourthDegree.Size = new System.Drawing.Size(42, 20);
            this.numericFourthDegree.TabIndex = 31;
            this.numericFourthDegree.Enter += new System.EventHandler(this.numericFourthDegree_Enter);
            this.numericFourthDegree.Leave += new System.EventHandler(this.numericFourthDegree_Leave);
            this.numericFourthDegree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericFourthDegree_MouseClick);
            // 
            // numericThirdDegree
            // 
            this.numericThirdDegree.Location = new System.Drawing.Point(178, 3);
            this.numericThirdDegree.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericThirdDegree.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericThirdDegree.Name = "numericThirdDegree";
            this.numericThirdDegree.Size = new System.Drawing.Size(42, 20);
            this.numericThirdDegree.TabIndex = 32;
            this.numericThirdDegree.Enter += new System.EventHandler(this.numericThirdDegree_Enter);
            this.numericThirdDegree.Leave += new System.EventHandler(this.numericThirdDegree_Leave);
            this.numericThirdDegree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericThirdDegree_MouseClick);
            // 
            // numericSecondDegree
            // 
            this.numericSecondDegree.Location = new System.Drawing.Point(262, 4);
            this.numericSecondDegree.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericSecondDegree.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericSecondDegree.Name = "numericSecondDegree";
            this.numericSecondDegree.Size = new System.Drawing.Size(42, 20);
            this.numericSecondDegree.TabIndex = 33;
            this.numericSecondDegree.Enter += new System.EventHandler(this.numericSecondDegree_Enter);
            this.numericSecondDegree.Leave += new System.EventHandler(this.numericSecondDegree_Leave);
            this.numericSecondDegree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericSecondDegree_MouseClick);
            // 
            // numericFirstDegree
            // 
            this.numericFirstDegree.Location = new System.Drawing.Point(346, 4);
            this.numericFirstDegree.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFirstDegree.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericFirstDegree.Name = "numericFirstDegree";
            this.numericFirstDegree.Size = new System.Drawing.Size(42, 20);
            this.numericFirstDegree.TabIndex = 34;
            this.numericFirstDegree.Enter += new System.EventHandler(this.numericFirstDegree_Enter);
            this.numericFirstDegree.Leave += new System.EventHandler(this.numericFirstDegree_Leave);
            this.numericFirstDegree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericFirstDegree_MouseClick);
            // 
            // numericFreeDegree
            // 
            this.numericFreeDegree.Location = new System.Drawing.Point(418, 4);
            this.numericFreeDegree.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFreeDegree.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericFreeDegree.Name = "numericFreeDegree";
            this.numericFreeDegree.Size = new System.Drawing.Size(42, 20);
            this.numericFreeDegree.TabIndex = 35;
            this.numericFreeDegree.Enter += new System.EventHandler(this.numericFreeDegree_Enter);
            this.numericFreeDegree.Leave += new System.EventHandler(this.numericFreeDegree_Leave);
            this.numericFreeDegree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericFreeDegree_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 288);
            this.Controls.Add(this.numericFreeDegree);
            this.Controls.Add(this.numericFirstDegree);
            this.Controls.Add(this.numericSecondDegree);
            this.Controls.Add(this.numericThirdDegree);
            this.Controls.Add(this.numericFourthDegree);
            this.Controls.Add(this.numericFifthDegree);
            this.Controls.Add(this.textBoxRightSide);
            this.Controls.Add(this.textBoxLeftSide);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonBuildGraph);
            this.Controls.Add(this.buttonVerification);
            this.Controls.Add(this.textBoxFindRoots);
            this.Controls.Add(this.buttonFindRoots);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.labelThirstDegree);
            this.Controls.Add(this.labelSecondDegree);
            this.Controls.Add(this.labelThirdDegree);
            this.Controls.Add(this.labelFourthDegree);
            this.Controls.Add(this.labelFifthDegree);
            this.Name = "Form1";
            this.Text = "Решение уравнений";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFifthDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFourthDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThirdDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecondDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreeDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFifthDegree;
        private System.Windows.Forms.Label labelFourthDegree;
        private System.Windows.Forms.Label labelThirdDegree;
        private System.Windows.Forms.Label labelSecondDegree;
        private System.Windows.Forms.Label labelThirstDegree;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.Button buttonFindRoots;
        private System.Windows.Forms.TextBox textBoxFindRoots;
        private System.Windows.Forms.Button buttonVerification;
        private System.Windows.Forms.Button buttonBuildGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox textBoxLeftSide;
        private System.Windows.Forms.TextBox textBoxRightSide;
        private System.Windows.Forms.NumericUpDown numericFifthDegree;
        private System.Windows.Forms.NumericUpDown numericFourthDegree;
        private System.Windows.Forms.NumericUpDown numericThirdDegree;
        private System.Windows.Forms.NumericUpDown numericSecondDegree;
        private System.Windows.Forms.NumericUpDown numericFirstDegree;
        private System.Windows.Forms.NumericUpDown numericFreeDegree;
    }
}

