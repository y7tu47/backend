using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Booking : Crud
    {
        FileManager fileManager = new FileManager();

        public string userName { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string mobile { get; set; }

        public override void Add(string filePath)
        {
            base.Add(filePath);
            StreamWriter sw = new StreamWriter(filePath, append: true);
            sw.Write($"{id},");
            sw.Write(name + ',');
            sw.Write($"{price},");
            sw.Write(userName + ',');
            sw.Write(from + ',');
            sw.Write(to + ',');
            sw.WriteLine(mobile);
            sw.Close();
        }

        public override void Update(string filePath)
        {
            fileManager.GetContentLines(List<string> (string[] parts, int index) => {             
                parts[3] = userName;
                parts[4] = from;
                parts[5] = to;
                parts[6] = mobile.ToString();
                contentLines[index] = string.Join(',', parts);
                return contentLines;
            }, filePath, id);
        }
    }
}
