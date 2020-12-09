namespace WFEngine.Activities.Core.Model
{
    public class WFArgument
    {
        public string Name { get; set; }
        public string ArgumentType { get; set; }
        public bool IsVariable { get; set; }
        public object Value { get; set; }
    }
}
