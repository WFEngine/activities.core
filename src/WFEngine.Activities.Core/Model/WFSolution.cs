using System;
using System.Collections.Generic;

namespace WFEngine.Activities.Core.Model
{
    public class WFSolution
    {
        public Guid UniqueKey { get; set; }
        public string OrganizationName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<WFProject> Projects{ get; set; }

        public WFSolution()
        {
            Projects = new List<WFProject>();
        }
    }
}
