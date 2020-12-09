using System.Collections.Generic;

namespace WFEngine.Activities.Core.Model
{
    public class WFBlock
    {
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public string ActivityName { get; set; }
        public List<WFArgument> Arguments{ get; set; }
        public List<WFBlock> Blocks { get; set; }
        public WFBlock()
        {
            Arguments = new List<WFArgument>();
        }
    }
}
