using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1_PRG282_Project.DAL;
using WindowsFormsApp1_PRG282_Project.BLL;

namespace WindowsFormsApp1_PRG282_Project.Presentation_Layer
{
    internal class FormatHandler
    {
        
            public List<SuperHero> formatData()
            {
                List<SuperHero> heroes = new List<SuperHero>();
                FileHandler fh = new FileHandler();

                foreach (var line in fh.ReadFile())
                {
                    string[] item = line.Split(',');
                if (item.Length == 5)
                {
                    heroes.Add(new SuperHero(
                        int.Parse(item[0]),
                        item[1],
                        item[2],
                        int.Parse(item[3]),
                        int.Parse(item[4])
                    ));
                }


            }
            return heroes;
            }

            public void RunApp()
            {
                FileHandler fileHandler = new FileHandler();
                fileHandler.WriteData();
           

        }
    }
}
