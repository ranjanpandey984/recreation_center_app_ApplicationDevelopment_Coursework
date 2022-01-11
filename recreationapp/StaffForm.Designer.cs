namespace recreationapp
{
    partial class StaffForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ShowTicketDetailsBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.priceTxtField = new System.Windows.Forms.NumericUpDown();
            this.visitorsCountError = new System.Windows.Forms.Label();
            this.durationError = new System.Windows.Forms.Label();
            this.customerTypeError = new System.Windows.Forms.Label();
            this.ageError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.dateTxtField = new System.Windows.Forms.TextBox();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.visitorsCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuyTicketBtn = new System.Windows.Forms.Button();
            this.startTimeTxtField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayTxtField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GenerateWeeklyReportBtn = new System.Windows.Forms.Button();
            this.GenerateDailyReport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.weeklyReportGrid = new System.Windows.Forms.DataGridView();
            this.dailyReportGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DisplayChartBtn = new System.Windows.Forms.Button();
            this.EarningBarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VisitorsBarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTxtField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EarningBarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsBarChart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 723);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShowTicketDetailsBtn);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.priceTxtField);
            this.tabPage1.Controls.Add(this.visitorsCountError);
            this.tabPage1.Controls.Add(this.durationError);
            this.tabPage1.Controls.Add(this.customerTypeError);
            this.tabPage1.Controls.Add(this.ageError);
            this.tabPage1.Controls.Add(this.nameError);
            this.tabPage1.Controls.Add(this.ClearBtn);
            this.tabPage1.Controls.Add(this.dateTxtField);
            this.tabPage1.Controls.Add(this.customerTypeComboBox);
            this.tabPage1.Controls.Add(this.durationComboBox);
            this.tabPage1.Controls.Add(this.visitorsCount);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.BuyTicketBtn);
            this.tabPage1.Controls.Add(this.startTimeTxtField);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dayTxtField);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nameTxtField);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Ticket";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ShowTicketDetailsBtn
            // 
            this.ShowTicketDetailsBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ShowTicketDetailsBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ShowTicketDetailsBtn.Location = new System.Drawing.Point(574, 274);
            this.ShowTicketDetailsBtn.Name = "ShowTicketDetailsBtn";
            this.ShowTicketDetailsBtn.Size = new System.Drawing.Size(208, 40);
            this.ShowTicketDetailsBtn.TabIndex = 37;
            this.ShowTicketDetailsBtn.Text = "Show Visitor Ticket Details";
            this.ShowTicketDetailsBtn.UseVisualStyleBackColor = false;
            this.ShowTicketDetailsBtn.Click += new System.EventHandler(this.ShowTicketDetailsBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(314, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 36);
            this.label11.TabIndex = 36;
            this.label11.Text = "Visitor Ticket Details";
            // 
            // priceTxtField
            // 
            this.priceTxtField.Location = new System.Drawing.Point(628, 196);
            this.priceTxtField.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.priceTxtField.Name = "priceTxtField";
            this.priceTxtField.ReadOnly = true;
            this.priceTxtField.Size = new System.Drawing.Size(257, 22);
            this.priceTxtField.TabIndex = 34;
            // 
            // visitorsCountError
            // 
            this.visitorsCountError.AutoSize = true;
            this.visitorsCountError.Location = new System.Drawing.Point(626, 169);
            this.visitorsCountError.Name = "visitorsCountError";
            this.visitorsCountError.Size = new System.Drawing.Size(0, 16);
            this.visitorsCountError.TabIndex = 33;
            // 
            // durationError
            // 
            this.durationError.AutoSize = true;
            this.durationError.Location = new System.Drawing.Point(154, 224);
            this.durationError.Name = "durationError";
            this.durationError.Size = new System.Drawing.Size(0, 16);
            this.durationError.TabIndex = 32;
            // 
            // customerTypeError
            // 
            this.customerTypeError.AutoSize = true;
            this.customerTypeError.Location = new System.Drawing.Point(154, 172);
            this.customerTypeError.Name = "customerTypeError";
            this.customerTypeError.Size = new System.Drawing.Size(0, 16);
            this.customerTypeError.TabIndex = 31;
            // 
            // ageError
            // 
            this.ageError.AutoSize = true;
            this.ageError.Location = new System.Drawing.Point(154, 162);
            this.ageError.Name = "ageError";
            this.ageError.Size = new System.Drawing.Size(0, 16);
            this.ageError.TabIndex = 30;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Location = new System.Drawing.Point(154, 64);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 16);
            this.nameError.TabIndex = 29;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Silver;
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ClearBtn.Location = new System.Drawing.Point(436, 274);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(123, 40);
            this.ClearBtn.TabIndex = 26;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // dateTxtField
            // 
            this.dateTxtField.Location = new System.Drawing.Point(629, 37);
            this.dateTxtField.Name = "dateTxtField";
            this.dateTxtField.ReadOnly = true;
            this.dateTxtField.Size = new System.Drawing.Size(255, 22);
            this.dateTxtField.TabIndex = 23;
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Select Type"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(157, 142);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(256, 24);
            this.customerTypeComboBox.TabIndex = 22;
            // 
            // durationComboBox
            // 
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "Select Duration"});
            this.durationComboBox.Location = new System.Drawing.Point(157, 196);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(256, 24);
            this.durationComboBox.TabIndex = 21;
            // 
            // visitorsCount
            // 
            this.visitorsCount.Location = new System.Drawing.Point(629, 144);
            this.visitorsCount.Name = "visitorsCount";
            this.visitorsCount.Size = new System.Drawing.Size(256, 22);
            this.visitorsCount.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total Visitors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Duration";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(879, 273);
            this.dataGridView1.TabIndex = 15;
            // 
            // BuyTicketBtn
            // 
            this.BuyTicketBtn.BackColor = System.Drawing.Color.Firebrick;
            this.BuyTicketBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BuyTicketBtn.Location = new System.Drawing.Point(265, 271);
            this.BuyTicketBtn.Name = "BuyTicketBtn";
            this.BuyTicketBtn.Size = new System.Drawing.Size(141, 43);
            this.BuyTicketBtn.TabIndex = 14;
            this.BuyTicketBtn.Text = "Buy Ticket";
            this.BuyTicketBtn.UseVisualStyleBackColor = false;
            this.BuyTicketBtn.Click += new System.EventHandler(this.BuyTicketBtn_Click);
            // 
            // startTimeTxtField
            // 
            this.startTimeTxtField.Location = new System.Drawing.Point(157, 88);
            this.startTimeTxtField.Multiline = true;
            this.startTimeTxtField.Name = "startTimeTxtField";
            this.startTimeTxtField.ReadOnly = true;
            this.startTimeTxtField.Size = new System.Drawing.Size(256, 24);
            this.startTimeTxtField.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customer Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Price";
            // 
            // dayTxtField
            // 
            this.dayTxtField.Location = new System.Drawing.Point(629, 80);
            this.dayTxtField.Multiline = true;
            this.dayTxtField.Name = "dayTxtField";
            this.dayTxtField.ReadOnly = true;
            this.dayTxtField.Size = new System.Drawing.Size(256, 24);
            this.dayTxtField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // nameTxtField
            // 
            this.nameTxtField.Location = new System.Drawing.Point(157, 37);
            this.nameTxtField.Multiline = true;
            this.nameTxtField.Name = "nameTxtField";
            this.nameTxtField.Size = new System.Drawing.Size(256, 24);
            this.nameTxtField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GenerateWeeklyReportBtn);
            this.tabPage2.Controls.Add(this.GenerateDailyReport);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.weeklyReportGrid);
            this.tabPage2.Controls.Add(this.dailyReportGrid);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GenerateWeeklyReportBtn
            // 
            this.GenerateWeeklyReportBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.GenerateWeeklyReportBtn.Location = new System.Drawing.Point(542, 532);
            this.GenerateWeeklyReportBtn.Name = "GenerateWeeklyReportBtn";
            this.GenerateWeeklyReportBtn.Size = new System.Drawing.Size(251, 57);
            this.GenerateWeeklyReportBtn.TabIndex = 6;
            this.GenerateWeeklyReportBtn.Text = "Generate Weekly Report";
            this.GenerateWeeklyReportBtn.UseVisualStyleBackColor = false;
            this.GenerateWeeklyReportBtn.Click += new System.EventHandler(this.GenerateWeeklyReportBtn_Click);
            // 
            // GenerateDailyReport
            // 
            this.GenerateDailyReport.BackColor = System.Drawing.Color.LightCoral;
            this.GenerateDailyReport.Location = new System.Drawing.Point(87, 532);
            this.GenerateDailyReport.Name = "GenerateDailyReport";
            this.GenerateDailyReport.Size = new System.Drawing.Size(251, 57);
            this.GenerateDailyReport.TabIndex = 5;
            this.GenerateDailyReport.Text = "Generate Daily Report";
            this.GenerateDailyReport.UseVisualStyleBackColor = false;
            this.GenerateDailyReport.Click += new System.EventHandler(this.GenerateDailyReport_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(82, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = " Daily Reports Panel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(558, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "Weekly Reports Panel";
            // 
            // weeklyReportGrid
            // 
            this.weeklyReportGrid.AllowUserToAddRows = false;
            this.weeklyReportGrid.AllowUserToDeleteRows = false;
            this.weeklyReportGrid.AllowUserToResizeColumns = false;
            this.weeklyReportGrid.AllowUserToResizeRows = false;
            this.weeklyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportGrid.Location = new System.Drawing.Point(448, 128);
            this.weeklyReportGrid.Name = "weeklyReportGrid";
            this.weeklyReportGrid.ReadOnly = true;
            this.weeklyReportGrid.RowHeadersWidth = 51;
            this.weeklyReportGrid.RowTemplate.Height = 24;
            this.weeklyReportGrid.Size = new System.Drawing.Size(460, 367);
            this.weeklyReportGrid.TabIndex = 2;
            // 
            // dailyReportGrid
            // 
            this.dailyReportGrid.AllowUserToAddRows = false;
            this.dailyReportGrid.AllowUserToDeleteRows = false;
            this.dailyReportGrid.AllowUserToResizeColumns = false;
            this.dailyReportGrid.AllowUserToResizeRows = false;
            this.dailyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportGrid.Location = new System.Drawing.Point(33, 128);
            this.dailyReportGrid.Name = "dailyReportGrid";
            this.dailyReportGrid.ReadOnly = true;
            this.dailyReportGrid.RowHeadersWidth = 51;
            this.dailyReportGrid.RowTemplate.Height = 24;
            this.dailyReportGrid.Size = new System.Drawing.Size(331, 367);
            this.dailyReportGrid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reports Panel";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DisplayChartBtn);
            this.tabPage3.Controls.Add(this.EarningBarChart);
            this.tabPage3.Controls.Add(this.VisitorsBarChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 694);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Charts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DisplayChartBtn
            // 
            this.DisplayChartBtn.Location = new System.Drawing.Point(18, 75);
            this.DisplayChartBtn.Name = "DisplayChartBtn";
            this.DisplayChartBtn.Size = new System.Drawing.Size(168, 45);
            this.DisplayChartBtn.TabIndex = 2;
            this.DisplayChartBtn.Text = "Display Chart";
            this.DisplayChartBtn.UseVisualStyleBackColor = true;
            this.DisplayChartBtn.Click += new System.EventHandler(this.DisplayChartBtn_Click);
            // 
            // EarningBarChart
            // 
            chartArea3.Name = "ChartArea1";
            this.EarningBarChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.EarningBarChart.Legends.Add(legend3);
            this.EarningBarChart.Location = new System.Drawing.Point(218, 346);
            this.EarningBarChart.Name = "EarningBarChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "TotalEarning";
            this.EarningBarChart.Series.Add(series3);
            this.EarningBarChart.Size = new System.Drawing.Size(689, 300);
            this.EarningBarChart.TabIndex = 1;
            this.EarningBarChart.Text = "chart2";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Total Earning Chart";
            this.EarningBarChart.Titles.Add(title3);
            // 
            // VisitorsBarChart
            // 
            chartArea4.Name = "ChartArea1";
            this.VisitorsBarChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.VisitorsBarChart.Legends.Add(legend4);
            this.VisitorsBarChart.Location = new System.Drawing.Point(218, 26);
            this.VisitorsBarChart.Name = "VisitorsBarChart";
            this.VisitorsBarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Visitor";
            this.VisitorsBarChart.Series.Add(series4);
            this.VisitorsBarChart.Size = new System.Drawing.Size(689, 300);
            this.VisitorsBarChart.TabIndex = 0;
            this.VisitorsBarChart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Total Visitors Chart";
            title4.Text = "Total Visitors Chart";
            this.VisitorsBarChart.Titles.Add(title4);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.logoutBtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(944, 694);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log Out";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.IndianRed;
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.Location = new System.Drawing.Point(349, 145);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(183, 64);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 720);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTxtField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EarningBarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsBarChart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayTxtField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.TextBox startTimeTxtField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown visitorsCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.TextBox dateTxtField;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label ageError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label durationError;
        private System.Windows.Forms.Label customerTypeError;
        private System.Windows.Forms.Label visitorsCountError;
        private System.Windows.Forms.NumericUpDown priceTxtField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ShowTicketDetailsBtn;
        private System.Windows.Forms.Button GenerateWeeklyReportBtn;
        private System.Windows.Forms.Button GenerateDailyReport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView weeklyReportGrid;
        private System.Windows.Forms.DataGridView dailyReportGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart EarningBarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VisitorsBarChart;
        private System.Windows.Forms.Button DisplayChartBtn;
    }
}