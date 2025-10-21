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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
