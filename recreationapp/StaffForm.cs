using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Windows.Forms.DataVisualization.Charting;

namespace recreationapp
{
    public partial class StaffForm : Form
    {
        XmlSerializer xmlSerializer;
        List<VisitorTicket> ticketList;

        XmlSerializer xmlSerializer2;
        List<VisitorTicket> visitorTickets;

        List<WeeklyReport> reportList;

        List<Price> priceRateList;
        String csvFileLocation;


        public StaffForm()
        {
            InitializeComponent();
            ticketList = new List<VisitorTicket>();
            xmlSerializer = new XmlSerializer(typeof(List<VisitorTicket>));

            visitorTickets = new List<VisitorTicket>();
            xmlSerializer2 = new XmlSerializer(typeof(List<VisitorTicket>));

            reportList = new List<WeeklyReport>();
            
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            startTimeTxtField.Text = DateTime.Now.ToLongTimeString();
            dateTxtField.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dayTxtField.Text = DateTime.Today.DayOfWeek.ToString();
            SetComboBoxItems();
            durationComboBox.SelectedIndex = 0;
            customerTypeComboBox.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startTimeTxtField.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nameTxtField.Text = "";
            dayTxtField.Text = "";
            priceTxtField.Text = "";
            visitorsCount.Value = 0;
            durationComboBox.SelectedIndex = 0;
            customerTypeComboBox.SelectedIndex = 0;
        }

        private int ValidateFields()
        { 
            int validationcount = 0;
            if(nameTxtField.Text == "")
            {
                nameError.ForeColor = Color.Red;
                nameError.Text = "Please enter name";
            }
            else
            {
                validationcount += 1;
                nameError.Text = "";
            }

            if (customerTypeComboBox.SelectedIndex == 0)
            {
                customerTypeError.ForeColor = Color.Red;
                customerTypeError.Text = "Please select customer type";
            }
            else
            {
                validationcount += 1;
                customerTypeError.Text = "";
            }

            if (durationComboBox.SelectedIndex == 0)
            {
                durationError.ForeColor = Color.Red;
                durationError.Text = "Please select duration";
            }
            else
            {
                validationcount += 1;
                durationError.Text = "";
            }

            if (visitorsCount.Value == 0)
            {
                visitorsCountError.ForeColor = Color.Red;
                visitorsCountError.Text = "Visitors count cannot be 0";
            }
            else
            {
                validationcount += 1;
                visitorsCountError.Text = "";
            }
            return validationcount;
        }

        private void BuyTicketBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields() == 4)
                {
                    FileStream fileStream = new FileStream(Path.Combine(Application.StartupPath, "VisitorTicket.xml"), FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);

                    VisitorTicket ticket = new VisitorTicket();
                    ticket.Name = nameTxtField.Text;
                    ticket.Date = DateTime.Parse(dateTxtField.Text);
                    ticket.Day = dayTxtField.Text;
                    ticket.StartTime = startTimeTxtField.Text;
                    ticket.TotalVistors = (int)visitorsCount.Value;
                    ticket.CustomerType = customerTypeComboBox.Text;
                    ticket.Duration = durationComboBox.Text;
                    CalculatePrice();
                    ticket.Price = int.Parse(priceTxtField.Text);

                    ticketList.Add(ticket);
                    MessageBox.Show("Ticket added successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //dataGridView1.DataSource = ticketList;
                    xmlSerializer.Serialize(fileStream, ticketList);
                    fileStream.Close();
                    ShowTicketDetails();
                }
                else
                {
                    ValidateFields();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTicketDetails()
        {
            try
            {
                FileStream fileStream2 = new FileStream(Path.Combine(Application.StartupPath, "VisitorTicket.xml"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                var data = xmlSerializer.Deserialize(fileStream2);

                ticketList = (List<VisitorTicket>)data;

                dataGridView1.DataSource = ticketList;
                fileStream2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ShowTicketDetailsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream(Path.Combine(Application.StartupPath, "VisitorTicket.xml"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                Button button = (Button)sender;

                var data = xmlSerializer.Deserialize(fileStream);

                ticketList = (List<VisitorTicket>)data;

                dataGridView1.DataSource = ticketList;
                fileStream.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalculatePrice()
        {
            int totalPrice = 0;
            int TotalVistors = (int)visitorsCount.Value;
            string CustomerType = customerTypeComboBox.Text;
            string Duration = durationComboBox.SelectedIndex.ToString();
            AdminForm adminForm = new AdminForm();
            foreach (Price price in priceRateList)
            {
                if (CustomerType == price.Type)
                {
                    if (Duration == "1")
                    {
                        totalPrice += (price.OneHourRate * TotalVistors);
                    }
                    else if(Duration == "2")
                    {
                        totalPrice +=  (price.TwoHourRate * TotalVistors);
                    }
                    else if (Duration == "3")
                    {
                        totalPrice +=  (price.ThreeHourRate * TotalVistors);
                    }
                    else if (Duration == "4")
                    {
                        totalPrice += (price.FourHourRate * TotalVistors);
                    }
                    else if (Duration == "5")
                    {
                        totalPrice += (price.WholeDayRate * TotalVistors);
                    }
                    priceTxtField.Text = totalPrice.ToString();
                }
            }
        }


        //Receive Method To Receive the List from other form
        public void Receive(List<Price> priceRate, String   fileLocation)
        {
            priceRateList = priceRate;
            csvFileLocation = fileLocation;
        }

        public void SetComboBoxItems()
        {
            try
            {
                string[] lines = File.ReadAllLines(csvFileLocation);

                string[] duration = lines[0].Split(',');

                //fetch data for durationComboBox
                for (int i = 1; i < lines.Length; i++)
                {
                    durationComboBox.Items.Add(duration[i]);
                }

                //fetch data for customerType ComboBox
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] customertype = lines[i].Split(',');
                    customerTypeComboBox.Items.Add(customertype[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            Visible = false;
        }

        private void GenerateDailyReport_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream(Path.Combine(Application.StartupPath, "VisitorTicket.xml"), FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                
                Button button = (Button)sender;

                var ticketData = xmlSerializer.Deserialize(fileStream);

                visitorTickets = (List<VisitorTicket>)ticketData;

                FileStream fileStream1 = new FileStream(Path.Combine(Application.StartupPath, "PriceRate.csv"), FileMode.Open, FileAccess.Read);

                string[] lines = File.ReadAllLines(fileStream1.Name);

                string[] duration = lines[0].Split(',');

                DataTable dt = new DataTable();
                dt.Columns.Add("Visitor Type");
                dt.Columns.Add("Count");
                string date = DateTime.Today.ToString("yyyy-MM-dd");
                //fetch data for customerType ComboBox
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] visitortype = lines[i].Split(',');

                    int count = 0;
                    if(visitorTickets != null)
                    {
                        for (int j = 0; j < visitorTickets.Count; j++)
                        {
                            if (visitorTickets[j].CustomerType == visitortype[0] && visitorTickets[j].Date.ToString("yyyy-MM-dd") == date)
                            {
                                count += visitorTickets[j].TotalVistors;
                            }
                        }
                        dt.Rows.Add(visitortype[0], count);
                    }
                    else
                    {
                        dt.Rows.Add(visitortype[0], 0);
                    }


                }
                dailyReportGrid.DataSource = dt;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("File Not Found as there are no visitor details yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void GenerateWeeklyReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream(Path.Combine(Application.StartupPath, "VisitorTicket.xml"), FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);

                Button button = (Button)sender;

                var ticketData = xmlSerializer.Deserialize(fileStream);

                visitorTickets = (List<VisitorTicket>)ticketData;

                DataTable dt = new DataTable();
                dt.Columns.Add("Day");
                dt.Columns.Add("Total Visitors");
                dt.Columns.Add("Total Earning");

                DayOfWeek Day = DateTime.Now.DayOfWeek;
                int Days = Day - DayOfWeek.Sunday; //here you can set your Week Start Day
                DateTime WeekStartDate = DateTime.Now.AddDays(-Days);
                string day1 = WeekStartDate.DayOfWeek.ToString();
                string day2 = WeekStartDate.AddDays(1).DayOfWeek.ToString();
                string day3 = WeekStartDate.AddDays(2).DayOfWeek.ToString();
                string day4 = WeekStartDate.AddDays(3).DayOfWeek.ToString();
                string day5 = WeekStartDate.AddDays(4).DayOfWeek.ToString();
                string day6 = WeekStartDate.AddDays(5).DayOfWeek.ToString();
                string day7 = WeekStartDate.AddDays(6).DayOfWeek.ToString();

                //for each day earning
                int firstdaycount = 0;
                int firstdayearning = 0;
                int seconddaycount = 0;
                int seconddayearning = 0;
                int thirddaycount = 0;
                int thirddayearning = 0;
                int fourthdaycount = 0;
                int fourthdayearning = 0;
                int fifthdaycount = 0;
                int fifthdayearning = 0;
                int sixthdaycount = 0;
                int sixthdayearning = 0;
                int seventhdaycount = 0;
                int seventhdayearning = 0;

                    
                    if (visitorTickets != null)
                    {
                        for (int j = 0; j < visitorTickets.Count; j++)
                        {
                            if (visitorTickets[j].Day == day1)
                            {
                                firstdaycount += visitorTickets[j].TotalVistors;
                                firstdayearning += visitorTickets[j].Price;
                            }
                            else if (visitorTickets[j].Day == day2)
                            {
                                seconddaycount += visitorTickets[j].TotalVistors;
                                seconddayearning += visitorTickets[j].Price;
                            }
                            else if (visitorTickets[j].Day == day3)
                            {
                                thirddaycount += visitorTickets[j].TotalVistors;
                                thirddayearning += visitorTickets[j].Price;
                            }
                            else if (visitorTickets[j].Day == day4)
                            {
                                fourthdaycount += visitorTickets[j].TotalVistors;
                                fourthdayearning += visitorTickets[j].Price;
                            }
                            else if (visitorTickets[j].Day == day5)
                            {
                                fifthdaycount += visitorTickets[j].TotalVistors;
                                fifthdayearning += visitorTickets[j].Price;
                            }
                            else if (visitorTickets[j].Day == day6)
                            {
                                sixthdaycount += visitorTickets[j].TotalVistors;
                                sixthdayearning += visitorTickets[j].Price;
                            }
                            else if (visitorTickets[j].Day == day7)
                            {
                                seventhdaycount += visitorTickets[j].TotalVistors;
                                seventhdayearning += visitorTickets[j].Price;
                            }
                        }   
                    }
                //    else
                //    {
                //        dt.Rows.Add(visitortype[0], 0);
                //    }
                //}
                dt.Rows.Add(day1, firstdaycount, firstdayearning);
                dt.Rows.Add(day2, seconddaycount, seconddayearning);
                dt.Rows.Add(day3, thirddaycount, thirddayearning );
                dt.Rows.Add(day4, fourthdaycount, fourthdayearning);
                dt.Rows.Add(day5, fifthdaycount, fifthdayearning);
                dt.Rows.Add(day6, sixthdaycount, sixthdayearning);
                dt.Rows.Add(day7, seventhdaycount, seventhdayearning);
                weeklyReportGrid.DataSource = dt;


                WeeklyReport report1 = new WeeklyReport();
                report1.Day = day1;
                report1.TotalVisitors = firstdaycount;
                report1.TotalEarning = firstdayearning;

                WeeklyReport report2 = new WeeklyReport();
                report2.Day = day2;
                report2.TotalVisitors = seconddaycount;
                report2.TotalEarning = seconddayearning;

                WeeklyReport report3 = new WeeklyReport();
                report3.Day = day3;
                report3.TotalVisitors = thirddaycount;
                report3.TotalEarning = thirddayearning;

                WeeklyReport report4 = new WeeklyReport();
                report4.Day = day4;
                report4.TotalVisitors = fourthdaycount;
                report4.TotalEarning = fourthdayearning;

                WeeklyReport report5 = new WeeklyReport();
                report5.Day = day5;
                report5.TotalVisitors = fifthdaycount;
                report5.TotalEarning = fifthdayearning;

                WeeklyReport report6 = new WeeklyReport();
                report6.Day = day6;
                report6.TotalVisitors = sixthdaycount;
                report6.TotalEarning = sixthdayearning;

                WeeklyReport report7 = new WeeklyReport();
                report7.Day = day7;
                report7.TotalVisitors = seventhdaycount;
                report7.TotalEarning = seventhdayearning;

                reportList.Add(report1);
                reportList.Add(report2);
                reportList.Add(report3);
                reportList.Add(report4);
                reportList.Add(report5);
                reportList.Add(report6);
                reportList.Add(report7);

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("File Not Found as there are no visitor details yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DisplayChartBtn_Click(object sender, EventArgs e)
        {
            if (reportList != null)
            {

                VisitorsBarChart.DataSource = reportList;
                VisitorsBarChart.Series["Visitor"].ChartType = SeriesChartType.Column;
                //set the member of the chart data source used to data bind to the X-values of the series  
                VisitorsBarChart.Series["Visitor"].XValueMember = "Day";
                //set the member columns of the chart data source used to data bind to the X-values of the series  
                VisitorsBarChart.Series["Visitor"].YValueMembers = "TotalVisitors";


                EarningBarChart.DataSource = reportList;
                EarningBarChart.Series["TotalEarning"].ChartType = SeriesChartType.Column;
                EarningBarChart.Series["TotalEarning"].XValueMember = "Day";
                EarningBarChart.Series["TotalEarning"].YValueMembers = "TotalEarning";
         
            }
            else
            {
                MessageBox.Show("Please Generate Report First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
