using System;
using System.Collections.Generic;

namespace WFEngine.Activities.Core.Model
{
    public class WFProject
    {
        public Guid UniqueKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public List<WFWorkflow> Workflows{ get; set; }

        public WFProject()
        {
            Workflows = new List<WFWorkflow>();
        }
    }
}
