using System.Text.Json;

namespace DocumentedAttribute
{
    internal class Operation
    {
        public static void WriteToTxt()
        {
            WriteToText documentation = new();
            var docs = documentation.GetDocs();

            try
            {
                File.WriteAllText("traineeTxt.txt", docs);

                Console.WriteLine("\n\t Txt file created successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t An error occurred while writing to the Txt file: " + e.Message);
            }
        }

        public static void ReadFromTxt()
        {
            try
            {
                var txtText = File.ReadAllText("traineeTxt.txt");

                Console.WriteLine(txtText);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t An error occurred while writing to the Txt file: " + e.Message);
            }
        }

        public static void WriteToJson(object obj, string fileName)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                    WriteIndented = true
                };

                string jsonText = JsonSerializer.Serialize(obj, options);

                File.WriteAllText(fileName, jsonText);

                Console.WriteLine("\n\t JSON file created successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t An error occurred while writing to the JSON file: " + e.Message);
            }
        }


        public static void ReadFromJson()
        {
            try
            {
                if (!File.Exists("traineeJson.json"))
                {
                    Console.WriteLine("\n\t You need to write to JSON File, before reading as JSON file does not exists!\n");
                }

                string json = File.ReadAllText("traineeJson.json");

                var jsonData = JsonSerializer.Deserialize<dynamic>(json);
                Console.WriteLine(jsonData);

            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t An error occurred while reading from the JSON file: " + e.Message);
            }
        }
    }
}
