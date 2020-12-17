using System;
using System.Collections.Generic;
using WFEngine.Activities.Core.Model;

namespace WFEngine.Activities.Core
{
    public class WFActivity : IWFActivity
    {
        public List<WFVariable> Variables { get; set; }
        public List<WFArgument> Arguments { get; set; }

        public WFActivity()
        {
            Variables = new List<WFVariable>();
        }

        public void SetArguments(List<WFArgument> arguments)
        {
            this.Arguments = arguments;
        }

        public void SetVariables(List<WFVariable> variables)
        {
            Variables.AddRange(variables);
        }

        public virtual void Run()
        {
            throw new NotImplementedException();
        }       
    }
}
