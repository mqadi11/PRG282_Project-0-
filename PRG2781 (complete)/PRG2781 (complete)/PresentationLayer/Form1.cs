using System;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1_PRG282_Project.BusinessLayer;
using WindowsFormsApp1_PRG282_Project.DataLayer;

namespace WindowsFormsApp1_PRG282_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void updatebtn_Click(object sender, EventArgs e)
        {
            string id = txtHeroID.Text.Trim();
            string name = txtName.Text.Trim();
            int age = int.Parse(txtAge.Text);
            string power = txtPower.Text.Trim();
            int score = int.Parse(txtScore.Text);

            bool updated = Logic.UpdateHero(id, name, age, power, score);

            if (updated)
            {
                MessageBox.Show("Superhero updated successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Hero ID not found.");
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string id = txtHeroID.Text.Trim();
            var heroes = Filehandler.ReadAllHeroes();

            foreach (var line in heroes)
            {
                string[] parts = line.Split(',');
                if (parts[0] == id)
                {
                    txtName.Text = parts[1];
                    txtAge.Text = parts[2];
                    txtPower.Text = parts[3];
                    txtScore.Text = parts[4];
                    MessageBox.Show("Hero found. You can now edit and click Update.");
                    return;
                }
            }

            MessageBox.Show("Hero not found");
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string id = txtHeroID.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a superhero to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this hero?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = Logic.DeleteHero(id);
                if (deleted)
                {
                    MessageBox.Show("Superhero deleted successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Hero ID not found.");
                }
            }
        }

        private void dgvHero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHero.Rows[e.RowIndex];
                txtHeroID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAge.Text = row.Cells[2].Value.ToString();
                txtPower.Text = row.Cells[3].Value.ToString();
                txtScore.Text = row.Cells[4].Value.ToString();
            }
        }

        private void LoadData()
        {
            dgvHero.Rows.Clear();
            var heroes = Filehandler.ReadAllHeroes();

            foreach (var line in heroes)
            {
                string[] parts = line.Split(',');
                dgvHero.Rows.Add(parts);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Example: get data from textboxes in your form
            string id = txtHeroID.Text;
            string name = txtName.Text;
            int age = int.TryParse(txtAge.Text, out int a) ? a : 0;
            string power = txtPower.Text;
            int score = int.TryParse(txtScore.Text, out int s) ? s : 0;
            

            // Add hero
            Filehandler.AddHero(id, name, age, power, score);

            // Refresh DataGridView
            LoadData();

            MessageBox.Show("Hero added successfully!");
        }
    }
}
