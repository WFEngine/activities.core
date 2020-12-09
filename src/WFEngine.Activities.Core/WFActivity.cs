using System;
using System.Collections.Generic;
using WFEngine.Activities.Core.Model;

namespace WFEngine.Activities.Core
{
    public class WFActivity : IWFActivity
    {
        public List<WFArgument> Arguments { get; set; }

        public void SetArguments(List<WFArgument> arguments)
        {
            this.Arguments = arguments;
        }

        public virtual string CompileActivity()
        {
            throw new NotImplementedException();
        }       
    }
}
