
namespace DocumentedAttribute
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DocumentAttribute : Attribute
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public DocumentAttribute(string description)
        {
            Description = description;
        }
    }
}
