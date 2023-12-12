using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.LinkLabel;

namespace AOC2023
{
    public partial class Day1 : Form
    {
        public Day1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                buttonRun.Text = "Run";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            ProcessStartInfo sInfo = new ProcessStartInfo
            {
                FileName = "https://adventofcode.com/2023/day/1",
                UseShellExecute = true
            };
            Process.Start(sInfo);
        }

        private void calculate(string filePath)
        {

            List<string> lines = File.ReadLines(filePath).ToList();
            char[] digits = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
            int firstIndex = -1;
            int first;
            int lastIndex = -1;
            int last;
            int sum = 0;
            foreach (string line in lines)
            {
                firstIndex = line.IndexOfAny(digits);
                if (firstIndex > -1)
                {
                    lastIndex = line.LastIndexOfAny(digits);
                    first = int.Parse(line[firstIndex].ToString());
                    last = int.Parse(line[lastIndex].ToString());
                    sum += 10 * first;
                    sum += last;
                }

            }
            textBoxAnswer.Text = sum.ToString();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                buttonRun.Text = "Running";
                buttonRun.Enabled = false;
                calculate(textBox1.Text);
                buttonRun.Text = "Done!";
                buttonRun.Enabled = true;
            }
            else
            {
                buttonRun.Text = "Browse First!";
            }

        }

        private void buttonRunAdvanced_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                buttonRunAdvanced.Text = "Running";
                buttonRunAdvanced.Enabled = false;
                calculateAdvanced(textBox1.Text);
                buttonRunAdvanced.Text = "Done!";
                buttonRunAdvanced.Enabled = true;
            }
            else
            {
                buttonRun.Text = "Browse First!";
            }
        }

        private void calculateAdvanced(string filePath)
        {

            List<string> lines = File.ReadLines(filePath).ToList();
            Regex regex = new Regex(@"\d|one|two|three|four|five|six|seven|eight|nine");
            string firstNumber;
            string lastNumber;
            MatchCollection matchedNumbers;
            int first;
            int last;
            int sum = 0;
            foreach (string line in lines)
            {
                matchedNumbers = regex.Matches(line);
                if (matchedNumbers.Count != 0)
                {
                    firstNumber = matchedNumbers[0].Value;
                    lastNumber = matchedNumbers[matchedNumbers.Count - 1].Value;
                    first = stringToDigit(firstNumber);
                    last = stringToDigit(lastNumber);
                    sum += 10 * first;
                    sum += last;
                }

            }
            textBoxAnswer.Text = sum.ToString();
        }

        private int stringToDigit(string str)
        {
            if (str.Length==1)
            {
                return int.Parse(str);
            }
            else
            {
                switch (str)
                {
                    case "one":
                        return 1;
                    case "two":
                        return 2;
                    case "three":
                        return 3;
                    case "four":
                        return 4;
                    case "five":
                        return 5;
                    case "six":
                        return 6;
                    case "seven":
                        return 7;
                    case "eight":
                        return 8;
                    case "nine":
                        return 9;
                    default:
                        return 0;
                }
            }
        }
    }
}
