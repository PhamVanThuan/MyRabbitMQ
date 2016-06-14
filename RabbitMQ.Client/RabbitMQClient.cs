using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRabbitMQ.Lib
{
    /// <summary>
    /// 客户端
    /// </summary>
    public class RabbitMQClient
    {
        /// <summary>
        /// 上下文
        /// </summary>
        public RabbitMQClientContext context { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public RabbitMQClient()
        {
            context = new RabbitMQClientContext();
            context.SendConnection = RabbitMQClientFactory.CreateConnection();
            context.SendChannel = RabbitMQClientFactory.CreateChannel(context.SendConnection);
            //在MQ上定义一个队列
            context.SendChannel.QueueDeclare(
                context.RabbitMQQueueName,
                context.QueueDurable,
                context.QueueExclusive,
                context.QueueAutoDelete,
                null);
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="msg"></param>
        public void Send(string msg)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(msg);
            //设置消息持久化
            IBasicProperties properties = context.SendChannel.CreateBasicProperties();
            properties.DeliveryMode = 2;
            context.SendChannel.BasicPublish("", context.RabbitMQQueueName, properties, bytes);
        }
    }
}
