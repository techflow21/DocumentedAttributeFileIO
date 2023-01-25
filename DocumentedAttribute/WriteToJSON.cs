using System.Reflection;
using System.Text;

namespace DocumentedAttribute
{
    internal class WriteToJSON
    {
        private static JsonFormat jsonOutput = new();
        private static List<JsonFormat> jsonOutputs = new();

        static string fileName = "traineeJson.json";

        internal static void GetWriteToJson()
        {
            Type type = typeof(Trainee);

            GetClass(type);
            GetConstructors(type);

            GetProperties(type);
            GetMethods(type);

            GetEnums();

            if (!string.IsNullOrEmpty(jsonOutput.Name))
            {
                jsonOutputs.Add(jsonOutput);
            }

            Operation.WriteToJson(jsonOutputs, fileName);
        }

        internal static void GetClass(Type type)
        {
            var classAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

            if (classAttribute != null)
            {
                jsonOutput.Name = type.Name;
                jsonOutput.Description = classAttribute.Description;
            }
        }


        internal static void GetConstructors(Type type)
        {
            var constructors = type.GetConstructors();

            foreach (var constructor in constructors)
            {
                var constructorAttribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute));

                if (constructorAttribute != null)
                {
                    jsonOutput.Constructors = new()
                    {
                        Name = constructor.Name,
                        Description = constructorAttribute.Description
                    };
                }
            }
        }


        internal static void GetProperties(Type type)
        {
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var propertyAttribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute));

                if (propertyAttribute != null)
                {
                    jsonOutput.Properties.Add(new()
                    {
                        Name = property.Name,
                        Description = propertyAttribute.Description
                    });
                }
            }
        }


        internal static void GetEnums()
        {
            Type enumType = typeof(Level);
            var enumValues = enumType.GetEnumValues();

            foreach (var value in enumValues)
            {
                var valueAttribute = (DocumentAttribute)enumType.GetField(value.ToString()).GetCustomAttribute(typeof(DocumentAttribute));

                if (valueAttribute != null)
                {
                    jsonOutput.Enums.Add(new()
                    {
                        Name = enumType.Name,
                        Description = valueAttribute.Description,

                        Input = string.IsNullOrEmpty(valueAttribute?.Input) ? string.Empty : valueAttribute.Input,
                        Output = string.IsNullOrEmpty(valueAttribute?.Output) ? string.Empty : valueAttribute.Output
                    });
                }
            }
        }


        internal static void GetMethods(Type type)
        {
            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                var methodAttribute = (DocumentAttribute)method.GetCustomAttribute(typeof(DocumentAttribute));

                if (methodAttribute != null)
                {                    
                    jsonOutput.Methods.Add(new()
                    {
                        Name = method.Name,
                        Description = methodAttribute.Description,

                        Input = string.IsNullOrEmpty(methodAttribute?.Input) ? string.Empty : methodAttribute.Input,
                        Output = string.IsNullOrEmpty(methodAttribute?.Output) ? string.Empty : methodAttribute.Output,
                    });
                }
            }
        }

    }
}
