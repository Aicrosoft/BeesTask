using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.TaskScheduling;

namespace RS.BeeTask.Tests.TaskScheduling
{
    [TestClass]
    public class CronExpressionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }



        [TestMethod]
        public void CronExpression_Test()
        {
            var cronExp = new CronExpression("0 */5 * * * ? ");//从0秒开始每5秒执行一次
            var sum = cronExp.GetExpressionSummary();
            var now = SystemTime.Now();
            var runTime = cronExp.GetNextValidTimeAfter(now); //Meta.Execution.LastSucceedRun.Value.ToUniversalTime()
            Console.WriteLine($"Now:{now};NextTime:{(runTime)}[{sum}]");


            //Assert.IsTrue(runTime.Value == now.AddMilliseconds(5));
        }
    }
}
