using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class FileManager
    {
        public delegate List<string> GetContentLinesDelegate(string[] parts, int index);

        //[KernelFunction("GetContentLines")]
        //[Description("get the lines in the text file.")]
        public void GetContentLines(GetContentLinesDelegate getContentLinesDelegate, string filePath, int id)
        {
            string[] parts;

            List<string> contentLines = File.ReadAllLines(filePath).ToList();
            for (int i = 1; i < contentLines.Count; i++)
            {
                parts = contentLines[i].Split(",");
                if (parts[0].Equals(id.ToString()))
                {
                    File.WriteAllLines(filePath, getContentLinesDelegate(parts, i));
                }
            }
        }
    }
}
