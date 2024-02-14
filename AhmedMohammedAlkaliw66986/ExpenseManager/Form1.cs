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

namespace ExpenseManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var path = pathbox.Text;
                var result = File.ReadAllText(path);

                result = result.Replace("|", "\t");

                var lines = result.Split('\n').Skip(1);

                var formattedResult = string.Join(Environment.NewLine, lines);
                outputbox.Text = $"Date \t\tPrice \tCategory {Environment.NewLine}";
                outputbox.Text += formattedResult;
            }
            catch
            {
                MessageBox.Show("Unable to Read File", "File Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var path = pathbox.Text;
                var result = File.ReadAllLines(path);
                var Expenses = new Dictionary<string, decimal>();
                var SecondExpenses = new Dictionary<string, string>();
                var CategoryInfo = new Dictionary<string, Tuple<int, List<string>, decimal>>();

                for (int i = 1; i < result.Length; i++)
                {
                    var line = result[i];
                    var split = line.Split('|');

                    var date = split[0];
                    var price = decimal.Parse(split[1]);
                    var category = split[2];

                    var month = DateTime.Parse(date).ToString("MMMM");

                    if (Expenses.ContainsKey(date))
                    {
                        Expenses[date] += price;
                    }
                    else
                    {
                        Expenses[date] = price;
                    }

                    if (SecondExpenses.ContainsKey(date))
                    {
                        SecondExpenses[date] += category;
                    }
                    else
                    {
                        SecondExpenses[date] = category;
                    }

                    if (CategoryInfo.ContainsKey(category))
                    {
                        var count = CategoryInfo[category].Item1 + 1;
                        var dates = CategoryInfo[category].Item2;
                        dates.Add(month);
                        var totalExpense = CategoryInfo[category].Item3 + price;

                        CategoryInfo[category] = Tuple.Create(count, dates, totalExpense);
                    }
                    else
                    {
                        CategoryInfo[category] = Tuple.Create(1, new List<string> { month }, price);
                    }
                }

                var totalprice = Expenses.Values.Sum();
                var totaldates = Expenses.Keys.Count();
                var totalcategory = CategoryInfo.Keys.Count();

                outputbox.Clear();
                outputbox.Text = $"Total expenses: {totalprice}{Environment.NewLine}";
                outputbox.Text += $"Number of categories: {totalcategory}{Environment.NewLine}";
                outputbox.Text += $"Total dates of payments: {totaldates}{Environment.NewLine}";


                outputbox.Text += " Categories:";

                foreach (var category in CategoryInfo)
                {
                    var monthList = category.Value.Item2.Distinct();
                    outputbox.Text += $"{Environment.NewLine}  {category.Key} – bought {category.Value.Item1} times in total. Purchases in: {string.Join(", ", monthList)}. Total expense: {category.Value.Item3}";
                }
            }
            catch
            {
                MessageBox.Show("Unable to Read File","File Error");
            }
        }
    }
}
