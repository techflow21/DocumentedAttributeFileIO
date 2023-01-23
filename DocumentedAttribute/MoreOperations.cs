
namespace DocumentedAttribute
{
    internal abstract class Operations
    {
        /*public static void WriteToXml()
        {
            TraineeDocumentation documentation = new();
            var docs = documentation.GetDocs();
           
            try
            {
                XmlSerializer serializer = new XmlSerializer(docs.GetType());
                using (FileStream xmlStream = new FileStream("traineeXml.xml", FileMode.Create))
                {
                    serializer.Serialize(xmlStream, docs);
                }

                Console.WriteLine("\n\t XML file created successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t An error occurred while writing to the XML file: " + e.Message);
            }
        

            public static void ReadFromXml()
            {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(string));

                using (FileStream xmlStream = new FileStream("traineeXml.xml", FileMode.Open))
                {
                    var docs = (string)serializer.Deserialize(xmlStream);
                    Console.WriteLine(docs);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t An error occurred while reading from the XML file: " + e.Message);
            }
        }*/
    }
}
