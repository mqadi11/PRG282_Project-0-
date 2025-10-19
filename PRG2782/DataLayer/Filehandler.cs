using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_PRG282_Project.DataLayer
{
    internal class Filehandler
    {
        public Filehandler() { }
        private static string filePath = @"C:\Users\601781\Documents\Superheroes\superheroes.txt";

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
    }
}
