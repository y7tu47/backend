using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class IdManager
    {
        public int ReadLastId(List<string> contentLines, string filePath )
        {
            string[] parts = [];

            contentLines = File.ReadAllLines(filePath).ToList();
            if (contentLines.Count != 1)
            {
                for (int i = 1; i < contentLines.Count; i++)
                {
                    parts = contentLines[i].Split(',');
                }
                return int.Parse(parts[0]);
            }
            return -1;
        }
    }
}
