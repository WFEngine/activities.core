using System;
using System.Collections.Generic;

namespace WFEngine.Activities.Core.Model
{
    public class WFWorkflow
    {
        public Guid UniqueKey{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<WFVariable> Variables{ get; set; }

        public List<WFBlock> Blocks { get; set; }

        public WFWorkflow()
        {
            Variables = new List<WFVariable>();
            Blocks = new List<WFBlock>();
        }
    }
}
