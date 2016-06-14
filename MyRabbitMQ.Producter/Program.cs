using MyRabbitMQ.Lib;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRabbitMQ.Producter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //客户端(生产者)
                RabbitMQClient client = new RabbitMQClient();
                //模拟消息
                while (true)
                {
                    string customStr = Console.ReadLine();
                    //发送消息
                    client.Send(customStr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
