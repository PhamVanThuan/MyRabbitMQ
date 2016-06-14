using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRabbitMQ.Lib
{
    /// <summary>
    /// RabbitMQ上下文
    /// </summary>
    public class RabbitMQClientContext
    {
        /// <summary>
        /// 用于发送消息的Connection
        /// </summary>
        public IConnection SendConnection { get;  set; }
        /// <summary>
        /// 用于发送消息的Channel
        /// </summary>
        public IModel SendChannel { get; set; }
        /// <summary>
        /// 用于侦听消息的Connection
        /// </summary>
        public IConnection ListerConnection { get; set; }
        /// <summary>
        /// 用于侦听消息的Channel
        /// </summary>
        public IModel ListerChannel { get; set; }
        /// <summary>
        /// 队列名称
        /// </summary>
        public string RabbitMQQueueName = "RabbitMQ";
        /// <summary>
        /// 队列是否持久化（当前会话结束的时候，会被销毁）
        /// </summary>
        public bool QueueDurable = true;
        /// <summary>
        /// 使队列成为私有队列，只有当前应用程序可用，当需要限制队列只有一个消费者，这是很有用的。
        /// </summary>
        public bool QueueExclusive = false;
        /// <summary>
        ///  当没有消费者连接到该队列的时候，队列自动销毁。
        /// </summary>
        public bool QueueAutoDelete = true;
    }
}