using System;
using System.Collections.Generic;
using System.Reflection;
using WFEngine.Activities.Core.Model;

namespace WFEngine.Activities.Core.Helper
{
    public static class BlockHelper
    {
        public static WFResponse RunBlock(this WFBlock block, List<WFVariable> variables = default)
        {
            if (variables == default)
                variables = new List<WFVariable>();
            Assembly assembly = Assembly.Load(block.AssemblyName);
            IWFActivity activity = (IWFActivity)Activator.CreateInstance(Type.GetType($"{block.ActivityName}, {assembly.FullName}", true));            
            activity.SetArguments(block.Arguments);
            activity.SetVariables(variables);
            activity.SetCurrentBlock(block);
            return activity.Run();
        }

        public static void RunBlock(this List<WFBlock>blocks,List<WFVariable> variables = default)
        {
            if (variables == default)
                variables = new List<WFVariable>();
            bool isContinue = true;
            foreach (var block in blocks)
            {
                variables.AddRange(block.Variables);
                if (isContinue)
                {
                    isContinue =  block.RunBlock(variables).Status;
                }
            }
        }
    }
}
