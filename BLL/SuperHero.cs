using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_PRG282_Project.BLL
{
    internal class SuperHero
    {
        public int HeroID { get; set; }
        public string Name { get; set; }
        public string SuperPower { get; set; }
        public int Age { get; set; }
        public int ExamScore { get; set; }

        public SuperHero(int ID, string name, string superPower, int age, int examScore)
        {
            HeroID = ID;
            Name = name;
            SuperPower = superPower;
            Age = age;
            ExamScore = examScore;
        }

        public override string ToString()
        {
            return $"{HeroID},{Name},{SuperPower},{Age},{ExamScore}";
        }
    }

}
