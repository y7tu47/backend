using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    abstract class Crud
    {
        IdManager idManager = new IdManager();

        FileManager fileManager = new FileManager();

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("price")]
        public double price { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("contentLines")]
        protected List<string> contentLines;


        public virtual void Add(string filePath)
        {
            id = idManager.ReadLastId(contentLines, filePath);
            id++;
        }
        public abstract void Update(string filePath);

        //[KernelFunction("setId")]
        //[Description("sets id for the item to delete or update.")]
        //private void setId(int id)
        //{
        //    this.id = id;
        //}

        //[KernelFunction("Delete")]
        //[Description("deletes the selected item from the system.")]
        public void Delete(string filePath)
        {
            fileManager.GetContentLines(List<string> (string[] parts, int index) => {
                contentLines.RemoveAt(index);
                return contentLines;
            }
            , filePath, id);
        }


        [KernelFunction("Delete")]
        [Description("deletes the selected item from the system.")]
        public void AiDelete(string filePath, int id)
        {
            string[] parts;

            List<string> contentLines = File.ReadAllLines(filePath).ToList();
            for (int i = 1; i < contentLines.Count; i++)
            {
                parts = contentLines[i].Split(",");
                if (parts[0].Equals(id.ToString()))
                {
                    contentLines.RemoveAt(i);
                    File.WriteAllLines(filePath, contentLines);
                }
            }         
        }

        public DataTable ReadData(string filePath)
        {
            contentLines = File.ReadAllLines(filePath).ToList();
            DataTable table = new DataTable();
            string[] headers = contentLines[0].Split(',');
            foreach (string header in headers)
            {
                table.Columns.Add(header);
            }

            for (int i = 1; i < contentLines.Count; i++)
            {
                string[] fields = contentLines[i].Split(",");
                table.Rows.Add(fields);
            }
            return table;
        }

    }
}
