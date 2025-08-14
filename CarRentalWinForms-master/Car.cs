using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace WinFormsApp1
{
    internal class Car : Crud
    {
        [JsonPropertyName("fileManager")]
        FileManager fileManager = new FileManager();

        [KernelFunction("fill")]
        [Description("fill the name and price of the new car.")]
        private void fill(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        [KernelFunction("Add")]
        [Description("adds a new car to the system.")]
        public override void Add(string filePath)
        {
            base.Add(filePath);
            StreamWriter sw = new StreamWriter(filePath, append: true);
            sw.Write($"{id},");
            sw.Write(name + ',');
            sw.WriteLine(price);
            sw.Close();
        }
        [KernelFunction("Update")]
        [Description("updates the selected car.")]
        public override void Update(string filePath)
        {
            fileManager.GetContentLines(List<string> (string[] parts, int index) => {
                parts[1] = name;
                parts[2] = price.ToString();
                contentLines[index] = string.Join(',', parts);
                return contentLines;
            }, filePath, id);
        }
    }
}
