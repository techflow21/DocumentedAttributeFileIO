
namespace DocumentedAttribute
{
    internal class TraineeDocumentation
    {
        internal string GetDocs()
        {
            var output = "";

            output += GetClass();

            output += GetMethods();

            output += GetProperties();

            output += GetEnum();

            return output;
        }

        internal string GetClass()
        {
            var classOutput = "";

            Type type = typeof(Trainee);
            classOutput += $"\t Target Class Name: {type.Name}\n\t ==========================\n";

            var attributes = type.GetCustomAttributes(true);

            foreach (var attribute in attributes)
            {
                if (attribute is DocumentAttribute)
                {
                    var doc = attribute as DocumentAttribute;
                    classOutput += $"\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}\n";
                }
            }
            return classOutput;
        }


        internal string GetMethods()
        {
            var methodsOutput = "";

            Type type = typeof(Trainee);

            Console.WriteLine("\n\t Methods of Trainee class:\n\t =========================");
            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                var methodAttributes = method.GetCustomAttributes(true);
                foreach (var attribute in methodAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        methodsOutput += $"\n\t Method Name: {method.Name}\n\t ========================\n\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}\n";
                    }
                }
            }

            return methodsOutput;
        }


        internal string GetProperties()
        {
            var propertiesOutput = "";

            Type type = typeof(Trainee);
            propertiesOutput += "\n\t Properties of Trainee class:\n\t ============================";
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var propertyAttributes = property.GetCustomAttributes(true);
                foreach (var attribute in propertyAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        propertiesOutput += $"\n\t Property Name: {property.Name} \n\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}\n";
                    }
                }
            }
            return propertiesOutput;
        }


        internal string GetEnum()
        {
            var enumOutput = "";
            Type enumType = typeof(Level);
            var enumValues = enumType.GetEnumValues();

            enumOutput += "\n\t Values of LevelEnum:\n\t =====================";
            foreach (var value in enumValues)
            {
                var valueAttributes = enumType.GetField(value.ToString()).GetCustomAttributes(true);

                foreach (var attribute in valueAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        enumOutput += $"\n\t Description: {doc.Description} \n\t Value: {value}\n";
                    }
                }
            }
            return enumOutput;
        }

    }
}
