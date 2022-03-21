using CsvHelper;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace RFMonitor
{
    public static class DataTableExtensions
    {
        // Extension class to write any datatable to a CSV file.
        // myDataTable.WriteToCsvFile("C:\\MyDataTable.csv")  for example.
        public static void WriteToCsvFile(this DataTable dataTable, string filePath)
        {
            StringBuilder fileContent = new StringBuilder();

            foreach (var col in dataTable.Columns)
            {
                fileContent.Append(col.ToString() + ",");
            }

            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (var column in dr.ItemArray)
                {
                    fileContent.Append("\"" + column.ToString() + "\",");
                }

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
            }

            System.IO.File.WriteAllText(filePath, fileContent.ToString());
        }


        public static void ReadFromCsvFile(this DataTable dataTable, string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))

                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    using (var dr = new CsvDataReader(csv))
                    {
                        dataTable.Load(dr);
                        Debug.WriteLine("Successfully loaded CSV data.");
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error loading CSV file.");
                Debug.WriteLine(e);
            }
        }

    }

}