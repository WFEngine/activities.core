using System;
using System.Collections.Generic;

namespace WFEngine.Activities.Core.Model
{
    public class WFBlock
    {
        public Guid UniqueKey { get; set; }
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public string ActivityName { get; set; }
        public List<WFVariable> Variables { get; set; }
        public List<WFArgument> Arguments{ get; set; }
        public List<WFBlock> Blocks { get; set; }
        public bool IsContainer { get; set; }
        public WFBlock()
        {
            Variables = new List<WFVariable>();
            Arguments = new List<WFArgument>();
            Blocks = new List<WFBlock>();

            IsContainer = false;

            UniqueKey = Guid.NewGuid();
        }
    }
}
