using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1_PRG282_Project.DataLayer;
using WindowsFormsApp1_PRG282_Project.BusinessLayer;

namespace WindowsFormsApp1_PRG282_Project.DataLayer
{
    internal class FormatHandler
    {
        public List<SuperHero> formatData()
        {
            List<SuperHero> heroes = new List<SuperHero>();

            // Read all lines from the file
            var lines = Filehandler.ReadAllHeroes();

            foreach (var line in lines)
            {
                string[] item = line.Split(',');
                if (item.Length == 7)
                {
                    heroes.Add(new SuperHero(
                        item[0],
                        item[1],
                        int.Parse(item[2]),
                        item[3],
                        int.Parse(item[4]),
                        item[5],
                        item[6]
                    ));
                }
            }
                return heroes;
        }
    }
}
