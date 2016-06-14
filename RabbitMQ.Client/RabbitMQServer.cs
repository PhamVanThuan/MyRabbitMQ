using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRabbitMQ.Lib
{
    public delegate void ReceivedHandler(object obj);
    /// <summary>
    /// 服务端
    /// </summary>
    public class RabbitMQServer
    {
        public ReceivedHandler ConsumerReceivedHandler;
        /// <summary>
        /// 上下文
        /// </summary>
        public RabbitMQClientContext context { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public RabbitMQServer()
        {
            context = new RabbitMQClientContext();
            context.ListerConnection = RabbitMQClientFactory.CreateConnection();
            context.ListerConnection.ConnectionShutdown+=ListerConnection_ConnectionShutdown;
            context.ListerChannel = RabbitMQClientFactory.CreateChannel(context.ListerConnection);
            //在MQ上定义一个队列
            context.ListerChannel.QueueDeclare(context.RabbitMQQueueName, false, false, false, null);
        }
        /// <summary>
        /// 连接断开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListerConnection_ConnectionShutdown(object sender, ShutdownEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="msg"></param>
        public void Listen()
        {
            /*
            //输入1，那如果接收一个消息，但是没有应答，则客户端不会收到下一个消息
            context.ListerChannel.BasicQos(0, 1, false);
            //在队列上定义一个消费者
            QueueingBasicConsumer consumer = new QueueingBasicConsumer(context.ListerChannel);
            //消费队列，并设置应答模式为程序主动应答
            context.ListerChannel.BasicConsume("RabbitMQ", false, consumer);

            while (true)
            {
                //阻塞函数，获取队列中的消息
                BasicDeliverEventArgs e = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                byte[] bytes = e.Body;
                string str = Encoding.UTF8.GetString(bytes);
                object msg = JsonConvert.DeserializeObject<object>(str);
                //回复确认
                context.ListerChannel.BasicAck(e.DeliveryTag, false);
            }*/

            //创建事件驱动的消费者类型
            EventingBasicConsumer consumer = new EventingBasicConsumer(context.ListerChannel);
            consumer.Received += consumer_Received;
            context.ListerChannel.BasicQos(0, 1, false);//一次只获取一个消息进行消费
            context.ListerChannel.BasicConsume(context.RabbitMQQueueName, false, consumer);//一次只获取一个消息进行消费
        }
        /// <summary>
        /// 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            try
            {
                byte[] bytes = e.Body;
                string str = Encoding.UTF8.GetString(bytes);
                //object msg = JsonConvert.DeserializeObject<object>(str);
                if (str != null)
                {
                    context.ListerChannel.BasicAck(e.DeliveryTag, false);
                    if (ConsumerReceivedHandler != null)
                        ConsumerReceivedHandler(str);
                }
                else
                {
                    //未能消息此消息，重新放入队列头
                    context.ListerChannel.BasicReject(e.DeliveryTag,true);
                }
            }
            catch
            {

            }
        }
    }
}
