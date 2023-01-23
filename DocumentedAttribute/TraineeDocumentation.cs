
namespace DocumentedAttribute
{
    internal class TraineeDocumentation
    {
        internal string GetDocs()
        {
            var output = "";

            Type type = typeof(Trainee);
            output += $"\n\t Target Class Name: {type.Name}\n\t ==========================\n";

            var attributes = type.GetCustomAttributes(true);

            foreach (var attribute in attributes)
            {
                if (attribute is DocumentAttribute)
                {
                    var doc = attribute as DocumentAttribute;
                    output += $"\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}\n";
                }
            }


            output += "\n\t Methods of Trainee class:\n\t =========================\n";
            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                var methodAttributes = method.GetCustomAttributes(true);
                foreach (var attribute in methodAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        output += $"\t Method Name: {method.Name} \n\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}\n";
                    }
                }
            }


            output += "\n\t Properties of Trainee class:\n\t ============================\n";
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var propertyAttributes = property.GetCustomAttributes(true);
                foreach (var attribute in propertyAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        output += $"\t Property Name: {property.Name} \n\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}\n\n";
                    }
                }
            }


            Type enumType = typeof(Level);
            var enumValues = enumType.GetEnumValues();

            output += "\n\t Values of LevelEnum:\n\t ====================\n";
            foreach (var value in enumValues)
            {
                var valueAttributes = enumType.GetField(value.ToString()).GetCustomAttributes(true);

                foreach (var attribute in valueAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        output += $"\t Description: {doc.Description} \n\t Value: {value}\n\n";
                    }
                }
            }
            return output;
        }
    }
}
