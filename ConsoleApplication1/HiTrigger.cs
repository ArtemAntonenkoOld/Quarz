using Quartz;
using System;
namespace ConsoleApplication1
{
    public class HiTrigger : IJob
    {
        public int a = 1;

        public void Execute(IJobExecutionContext context)
        {

            Console.Write("harasho");
        }
    }
}