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
using WindowsFormsApp1_PRG282_Project.BLL;
using WindowsFormsApp1_PRG282_Project.DAL;
using WindowsFormsApp1_PRG282_Project.Presentation_Layer;

namespace WindowsFormsApp1_PRG282_Project
{
    public partial class Form1 : Form
    {

        public string name, superPower;
        public int age, heroID, examScore;
        public string filename = @"superheroes.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            FormatHandler fh = new FormatHandler();
            dataGridView1.DataSource = null;            // clear old binding
            dataGridView1.DataSource = fh.formatData(); // reload from file
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void dvgHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            heroID = int.Parse(textBox1.Text);
            name = textBox2.Text;
            age = decimal.ToInt32(numericUpDown1.Value);
            superPower = textBox4.Text;
            examScore = decimal.ToInt32(numericUpDown2.Value);

            SuperHero superHero = new SuperHero(heroID, name, superPower, age, examScore);
            superHero.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("superheroes.txt"))
                {
                    MessageBox.Show("File does not exist. Please add heroes first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var lines = File.ReadAllLines("superheros.txt");
                if (lines.Length == 0)
                {
                    MessageBox.Show("File is empty. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int totalHeroes = 0, totalAge = 0, totalScore = 0;
                int sRank = 0, aRank = 0, bRank = 0, cRank = 0;

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length < 7) continue;
                    totalHeroes++;
                    totalAge += int.Parse(parts[2]);
                    int score = int.Parse(parts[4]);
                    string rank = parts[5];
                    switch (rank)
                    {
                        case "S-Rank":
                            sRank++;
                            break;
                        case "A-Rank":
                            aRank++;
                            break;
                        case "B-Rank":
                            bRank++;
                            break;
                        case "C-Rank":
                            cRank++;
                            break;
                    }
                }
                double averageAge = totalHeroes > 0 ? (double)totalAge / totalHeroes : 0;
                double averageScore = totalHeroes > 0 ? (double)totalScore / totalHeroes : 0;
                
          dataGridView2.Columns.Clear();
          dataGridView2.Rows.Clear();
          
                //Display results on the form
                dataGridView2.Columns.Add("Total Heros", totalHeroes);
                dataGridView2.Columns.Add("Average Age" , averageAge.ToString("F2"));
                dataGridView2.Columns.Add("Average Score" averageScore.ToString("F2"));
                dataGridView2.Columns.Add("S-Rank Heros" ,sRank);
                dataGridView2.Columns.Add("A-Rank Heros" ,aRank);
                dataGridView2.Columns.Add("B-Rank Heros" ,bRank);
                dataGridView2.Columns.Add("C-Rank Heros" ,cRank);


                //Save to summary.txt

                string stats = $"Total Heroes: {totalHeroes}\n" +
                               $"Average Age: {averageAge:F2}\n" +
                               $"Average Exam Score: {averageScore:F2}\n" +
                               $"S-Rank Heroes: {sRank}\n" +
                               $"A-Rank Heroes: {aRank}\n" +
                               $"B-Rank Heroes: {bRank}\n" +
                               $"C-Rank Heroes: {cRank}";


                File.WriteAllText("summary.txt", stats);

                MessageBox.Show("Summary report generated successfully!", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Git commit
                System.Diagnostics.Process.Start("cmd.exe", "/C git add . && git commit -m \"Generated summary report\"");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = textBox1.Text.Trim().ToLower();
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    MessageBox.Show("Please enter a search keyword.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridView1.Rows.Clear();

                if (File.Exists("superheros.txt"))
                {
                    var lines = File.ReadAllLines("superheros.txt");
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');

                        //Match ID or Name 
                        if (parts[0].ToLower().Contains(keyword) || parts[1].ToLower().Contains(keyword))
                        {
                            dataGridView1.Rows.Add(parts);
                        }


                        if (parts.Length < 5) continue;
                        string name = parts[1].ToLower();
                        string superPower = parts[3].ToLower();
                        if (name.Contains(keyword) || superPower.Contains(keyword))
                        {
                            dataGridView1.Rows.Add(parts);
                        }
                    }
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching heroes found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//exception
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            RefreshTable();
            textBox1.Clear();
            MessageBox.Show("Data refreshed successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
