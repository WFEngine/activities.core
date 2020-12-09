using System;

namespace WFEngine.Activities.Core.Model
{
    public class WFVariable
    {
        public Guid UniqueKey { get; set; }
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public bool IsVariable { get; set; }
        public bool IsClass { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDefault { get; set; }
        public object Value { get; set; }
    }
}
