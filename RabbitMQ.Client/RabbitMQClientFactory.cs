using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRabbitMQ.Lib
{
    /// <summary>
    /// RabbitMQ创建工厂
    /// </summary>
    public class RabbitMQClientFactory
    {
        /// <summary>
        /// 心跳超时时间
        /// </summary>
        public static ushort RequestedHeartbeat = 60;
        /// <summary>
        /// 是否自动重连
        /// </summary>
        public static bool AutomaticRecoveryEnabled = false;

        /// <summary>
        /// 创建Connetion
        /// </summary>
        /// <returns></returns>
        public static IConnection CreateConnection()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.Port = 5672;
            factory.UserName = "guest";
            factory.Password = "guest";
            factory.RequestedHeartbeat = RequestedHeartbeat;//心跳超时时间
            factory.AutomaticRecoveryEnabled = AutomaticRecoveryEnabled;//自动重连

            return factory.CreateConnection();
        }
        /// <summary>
        /// 创建Connetion
        /// </summary>
        /// <returns></returns>
        public static IConnection CreateConnection(string hostName,int port,string username,string pwd)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = hostName;
            factory.Port = port;
            factory.UserName = username;
            factory.Password = pwd;
            factory.RequestedHeartbeat = RequestedHeartbeat;//心跳超时时间
            factory.AutomaticRecoveryEnabled = AutomaticRecoveryEnabled;//自动重连

            return factory.CreateConnection();
        }
        /// <summary>
        /// 创建Channel
        /// </summary>
        /// <param name="connetion"></param>
        /// <returns></returns>
        public static IModel CreateChannel(IConnection connetion)
        {
            return connetion.CreateModel();
        }
    }
}