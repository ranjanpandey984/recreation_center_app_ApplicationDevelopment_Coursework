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

namespace recreationapp
{
    public partial class AdminForm : Form
    {
        List<Price> priceList;

        public AdminForm()
        {
            InitializeComponent();
            priceList = new List<Price>();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Receive(priceList,csvFileName.Text);
            form.Show();
            Visible = false;
        }

        private void ImportCSVBtn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                csvFileName.Text = openFileDialog1.FileName;
                //var listOfObjects = File.ReadLines(csvFileName.Text).Select(line => new Price(line)).ToList();

                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(csvFileName.Text);
                if (lines.Length > 0)
                {
                    //first line to create header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //fetch data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        Price price = new Price();
                        price.Type = dataWords[0];
                        price.OneHourRate = int.Parse(dataWords[1]);
                        price.TwoHourRate = int.Parse(dataWords[2]);
                        price.ThreeHourRate = int.Parse(dataWords[3]);
                        price.FourHourRate = int.Parse(dataWords[4]);
                        price.WholeDayRate = int.Parse(dataWords[5]);
                        priceList.Add(price);

                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                    //Console.WriteLine(priceList.Count);
                    //StaffForm staffform = new StaffForm();
                    //staffform.Receive(priceList);
                    //staffform.Show();
                }
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                MessageBox.Show("Price Rates Imported Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
