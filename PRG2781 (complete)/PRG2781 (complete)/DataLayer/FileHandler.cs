using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1_PRG282_Project.BusinessLayer;

namespace WindowsFormsApp1_PRG282_Project.DataLayer
{
    internal class Filehandler
    {
        public Filehandler() { }
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "superheroes.txt");


        public static List<string> ReadAllHeroes()
        {
            if (!File.Exists(filePath))
                return new List<string>();

            return File.ReadAllLines(filePath).ToList();
        }

        public static void WriteAllHeroes(List<string> heroes)
        {
            File.WriteAllLines(filePath, heroes);
        }


        public static bool UpdateHero(string id, string name, int age, string power, int score, string rank, string threat)
        {
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;
            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts[0] == id)
                {
                    found = true;
                    string newLine = $"{id},{name},{age},{power},{score},{rank},{threat}";
                    updatedLines.Add(newLine);
                }
                else
                {
                    updatedLines.Add(line);
                }
            }

            if (found)
            {
                File.WriteAllLines(filePath, updatedLines);
                return true;
            }

            return false;
        }

        public static bool DeleteHero(string id)
        {
            string[] lines = File.ReadAllLines(filePath);

            List<string> updatedLines = new List<string>();
            bool found = false;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts[0] == id)
                {
                    found = true;
                    continue;
                }

                updatedLines.Add(line);
            }

            if (found)
            {
                File.WriteAllLines(filePath, updatedLines);
                return true;
            }

            return false;
        }
        // Add a new hero to the file
        public static void AddHero(string id, string name, int age, string power, int score)
        {
            // First, add a placeholder line for the hero if it doesn't exist yet
            var lines = Filehandler.ReadAllHeroes();

            bool heroExists = lines.Any(line => line.Split(',')[0] == id);
            if (!heroExists)
            {
                // Add basic info; rank and threat will be updated via Logic.UpdateHero
                string placeholderLine = $"{id},{name},{age},{power},{score},,";
                lines.Add(placeholderLine);
                Filehandler.WriteAllHeroes(lines);
            }

            // Now call Logic.UpdateHero to calculate rank/threat and update the file
            Logic.UpdateHero(id, name, age, power, score);
        }
    }
}
