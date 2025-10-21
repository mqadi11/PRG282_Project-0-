using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1_PRG282_Project.DataLayer;

namespace WindowsFormsApp1_PRG282_Project.BusinessLayer
{
    internal class Logic
    {
        // Recalculate rank and threat level based on exam score
        private static (string rank, string threat) CalculateRankAndThreat(int score)
        {
            if (score >= 81) return ("S-Rank", "Finals Week");
            if (score >= 61) return ("A-Rank", "Midterm Madness");
            if (score >= 41) return ("B-Rank", "Group Project Gone Wrong");
            return ("C-Rank", "Pop Quiz");
        }

        // Update hero info
        public static bool UpdateHero(string id, string name, int age, string power, int score)
        {
            var (rank, threat) = CalculateRankAndThreat(score);
            return Filehandler.UpdateHero(id, name, age, power, score, rank, threat);
        }

        // Delete Hero
        public static bool DeleteHero(string id)
        {
            return Filehandler.DeleteHero(id);
        }
    }
}
