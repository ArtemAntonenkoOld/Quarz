using Quartz;
using System;

public class RozkladTrigger : IJob
{
    public int a = 1;

    public void Execute(IJobExecutionContext context)
    {
       
            Console.Write("harasho");
     }
}