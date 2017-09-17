namespace _05.Custom_Enum_Attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        private string type;
        private string category;
        private string description;

        public TypeAttribute(string type)
        {
            this.type = "Enumeration";
            this.category = type;
            this.description = $"Provides {type.ToLower()} constants for a Card class.";
        }

        public string Type { get { return this.type; } }

        public string Description { get { return this.description; } }
    }
}
