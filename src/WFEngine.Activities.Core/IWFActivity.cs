using System.Collections.Generic;
using WFEngine.Activities.Core.Model;

namespace WFEngine.Activities.Core
{
    public interface IWFActivity
    {
        void SetArguments(List<WFArgument> arguments);
        void SetVariables(List<WFVariable> variables);
        void Run();
    }
}
