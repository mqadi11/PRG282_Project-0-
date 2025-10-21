using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp1_PRG282_Project.Presentation_Layer;
using System.Windows.Forms;

namespace WindowsFormsApp1_PRG282_Project.DAL
{
    internal class FileHandler
    {
        public List<string> ReadFile()
        {
            string filename = "superheroes.txt";
            return File.ReadAllLines(filename).ToList();
        }


        public void WriteData()
        {
            List<string> output = new List<string>();
            FormatHandler fh = new FormatHandler();

            foreach (var item in fh.formatData())
            {
                output.Add(item.ToString());
            }

            string filename = "superheroes.txt";
            File.WriteAllLines(filename, output);

            MessageBox.Show("Heroes saved to file.");
        }
    }
}
