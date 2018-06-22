
using System;
using System.Threading;
using NLog;

namespace RS.TaskScheduling
{
    /// <summary>
    ///   任务实现示例
    /// </summary>
    /// 
    /// <description class = "CS.WinService.TaskDemo">
    ///   
    /// </description>
    /// 
    /// <history>
    ///   2010-4-23 10:22:02 , zhouyu ,  创建	     
    ///  </history>
    public class TaskDemo:TaskProvider
    {
        private readonly ILogger _logWork = LogManager.GetCurrentClassLogger();


        private static readonly Random rand = new Random();
        protected static int RandSeconds()
        {
            return rand.Next(2000, 6000);
        }


        protected override TaskResult Work()
        {
            var stamp = TaskResultType.Succeed;
            var rs = RandSeconds();
            if (rs > 4500)
                stamp = TaskResultType.Failed;

            Thread.Sleep(rs );

            _logWork.Info("我是执行的任务,工作了{0}秒", rs / 1000);

            throw new NotSupportedException("测试用");
            return new TaskResult() { Result = stamp };
        }


        ///// <summary>
        ///// 如扩展配置时一定要重写本方法
        ///// </summary>
        //public override void LoadExtendConfig()
        //{
        //    base.LoadExtendConfig();   //默认时启用系统中的公共扩展
        //}
    }
}
