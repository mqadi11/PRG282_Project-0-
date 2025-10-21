using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1_PRG282_Project.BusinessLayer;
using WindowsFormsApp1_PRG282_Project.DataLayer;

namespace WindowsFormsApp1_PRG282_Project.BusinessLayer
{
    internal class SuperHero
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Power { get; set; }
        public int Score { get; set; }
        public string Rank { get; set; }
        public string Threat { get; set; }

        public SuperHero(string Id, string name, int age, string power, int score, string rank, string threat)
        {
            ID = Id;
            Name = name;
            Age = age;
            Power = power;
            Score = score;
            Threat = threat;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{ID},{Name},{Age},{Power},{Score},{Threat},{Rank}";
        }
    }
}
