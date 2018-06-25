using System;

namespace RS.TaskScheduling
{
    /// <summary>
    /// 配置错误
    /// </summary>
    public class ConfigException:Exception
    {
        public ConfigException(string msg) : base(msg)
        {
        }
    }
}