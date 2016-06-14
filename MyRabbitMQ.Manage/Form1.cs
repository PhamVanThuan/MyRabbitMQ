using MyRabbitMQ.Lib;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRabbitMQ.Manage
{
    public partial class Form1 : Form
    {
        #region 属性
        public RabbitMQClientContext context;
        private string hostName = "localhost";
        private string hostUrl = "http://localhost:15672";
        private string userName = "guest";
        private string passWord = "guest";
        private string exchangesApi;
        private string queuesApi;
        private string bingdingsApi;
        private List<ExchangeEntity> userExchanges;
        private List<QueueEntity> queues;
        private List<BindingEntity> bindings;
        private ExchangeEntity exchange;
        private QueueEntity queue;
        private BindingEntity binding;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitRabbit();
        }
        /// <summary>
        /// 初始化配置环境
        /// </summary>
        public void InitRabbit()
        {
            context = new RabbitMQClientContext();
            hostName = this.txtHostName.Text.Trim();
            userName = this.txtUsername.Text.Trim();
            passWord = this.txtPwd.Text.Trim();
            hostUrl = this.txtHostUrl.Text.Trim();
            exchangesApi = hostUrl + "/api/exchanges";
            queuesApi = hostUrl + "/api/queues";
            bingdingsApi = hostUrl + "/api/bindings";
            context.SendConnection = RabbitMQClientFactory.CreateConnection(hostName, 5672, userName, passWord);
            context.SendChannel = RabbitMQClientFactory.CreateChannel(context.SendConnection);
            context.ListerConnection = RabbitMQClientFactory.CreateConnection(hostName, 5672, userName, passWord);
            context.ListerChannel = RabbitMQClientFactory.CreateChannel(context.ListerConnection);

            cbExchangeType.SelectedIndex = 0;//交换机类型
            cbExchangeDurable.SelectedIndex = 0;//交换机持久化
            cbExchangeAutoDelete.SelectedIndex = 1;//交换机自动销毁
            cbQueueDurable.SelectedIndex = 0;//队列持久化
            cbQueueExclusive.SelectedIndex = 1;//队列排他性(只有自己可见的队列，即不允许其它用户访问)
            cbAutoDelete.SelectedIndex = 1;////队列自动销毁

            ShowExchangesToList(exchangesApi);
            ShowQueuesToList(queuesApi);
            ShowBindingsToList(bingdingsApi);
            
        }

        #region RabbitMQ配置
        /// <summary>
        /// 刷新RabbitMQ配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitRabbit();
        }
        /// <summary>
        /// 检查配置环境
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckEnv_Click(object sender, EventArgs e)
        {
            CheckEnv(hostUrl);
        }
        /// <summary>
        /// 查看交换机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExchangesView_Click(object sender, EventArgs e)
        {
            ShowAllExchangesInfo(exchangesApi);
        }
        /// <summary>
        /// 查看队列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueuesView_Click(object sender, EventArgs e)
        {
            ShowAllQueuesInfo(queuesApi);
        }
        /// <summary>
        /// 删除交换机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExchangesDelete_Click(object sender, EventArgs e)
        {
            DeleteExchanges();
            ShowExchangesToList(exchangesApi);
        }
        /// <summary>
        /// 删除队列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueuesDelete_Click(object sender, EventArgs e)
        {
            DeleteQueues(queuesApi);
            ShowBindingsToList(bingdingsApi);
        }
        /// <summary>
        /// 获取调用Api接口结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetApiResult_Click(object sender, EventArgs e)
        {
            try
            {
                ShowApiResult(hostUrl + "/api/" + txtApiName.Text.Trim());
            }
            catch
            {
                ShowSysMessage("该服务不支持");
            }
        }
        /// <summary>
        /// 检查配置环境
        /// </summary>
        /// <param name="Url"></param>
        private async void CheckEnv(string Url)
        {
            try
            {
                var response = await GetHttpClientResult(Url);
                txtSysMessage.Clear();
                ShowSysMessage(response.IsSuccessStatusCode ? "环境正常" : "服务器未运行");
            }
            catch
            {
                ShowSysMessage("服务器未运行");
            }
        }
        #endregion

        #region 交换机
        /// <summary>
        /// 移除用户交换机Exchanges
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveUserExchanges_Click(object sender, EventArgs e)
        {
            lbUserExchanges.Items.Remove(lbUserExchanges.SelectedItem);
        }
        /// <summary>
        /// 刷新用户交换机Exchanges
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshUserExchanges_Click(object sender, EventArgs e)
        {
            ShowExchangesToList(exchangesApi);
        }
        /// <summary>
        /// 查看选中用户交换机Exchanges信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (lbUserExchanges.SelectedItem == null)
            {
                return;
            }
            exchange = userExchanges.FirstOrDefault(x => x.name == lbUserExchanges.SelectedItem.ToString());
            txtSysMessage.Clear();
            if (exchange != null)
            {
                if (exchange.message_stats == null) exchange.message_stats = new MessageStatsEntity();
                ShowSysMessage(string.Format("Name:{0},\r\nType:{1},Durable:{2},Auto_delete:{3},Internal:{4},Publish_in:{5},Publish_out：{6}\r\n",
                         exchange.name, exchange.type, exchange.durable, exchange.auto_delete, exchange.internalFlag, exchange.message_stats.publish_in, exchange.message_stats.publish_out));
            }
            else
            {
                ShowSysMessage("未发现该交换机");
            }
        }
        /// <summary>
        /// 添加用户交换机Exchanges
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddExchange_Click(object sender, EventArgs e)
        {
            context.SendChannel.ExchangeDeclare(txtExchangeName.Text.Trim(), cbExchangeType.SelectedItem.ToString(), cbExchangeDurable.SelectedIndex == 0, cbExchangeAutoDelete.SelectedIndex == 0, null);
            ShowExchangesToList(exchangesApi);
        }
        /// <summary>
        /// 交换机列表选中改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbUserExchanges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUserExchanges.SelectedItem != null)
            {
                txtSelectExchange.Text = lbUserExchanges.SelectedItem.ToString();
            }
        }
        /// <summary>
        /// 调用RabbitMQ接口获取用户交换机信息
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <returns></returns>
        private async Task<List<ExchangeEntity>> GetUserExchanges(string apiUrl)
        {
            string jsonContent = await GetApiResult(apiUrl);
            var exchanges = JsonConvert.DeserializeObject<List<ExchangeEntity>>(jsonContent);
            var sysExchanges = (from object item in lbSysExchanges.Items select item.ToString().Trim()).ToList();
            var exchangeEntities = exchanges.Where(x => !sysExchanges.Contains(x.name.Trim())).ToList();
            return exchangeEntities;
        }
        /// <summary>
        /// 显示交换机信息到列表框
        /// </summary>
        /// <param name="apiUrl"></param>
        private async void ShowExchangesToList(string apiUrl)
        {
            lbUserExchanges.Items.Clear();
            userExchanges = await GetUserExchanges(apiUrl);
            if (userExchanges != null && userExchanges.Count != 0)
            {
                foreach (var entity in userExchanges)
                {
                    lbUserExchanges.Items.Add(entity.name);
                }
            }
        }
        /// <summary>
        /// 查看所有交换机信息（显示到右边的文本框中）
        /// </summary>
        /// <param name="apiUrl"></param>
        private async void ShowAllExchangesInfo(string apiUrl)
        {
            string jsonContent = await GetApiResult(apiUrl);
            var exchanges = JsonConvert.DeserializeObject<List<ExchangeEntity>>(jsonContent);
            int count = exchanges.Count;
            txtSysMessage.Clear();
            var s = new StringBuilder();
            s.AppendLine(string.Format("Exchanges Count:{0}", count));
            s.AppendLine("NameList:");
            int index = 1;
            foreach (var exchangeEntity in exchanges)
            {
                s.AppendLine(index + ":" + exchangeEntity.name + "  ");
                index++;
            }
            s.AppendLine("");
            s.AppendLine("Detail:");
            index = 1;
            foreach (var entity in exchanges)
            {
                if (entity.message_stats == null) entity.message_stats = new MessageStatsEntity();
                s.AppendLine(string.Format("{0}.Name:{1},\r\nType:{2},Durable:{3},Auto_delete:{4},Internal:{5},Publish_in:{6},Publish_out：{7}\r\n",
                    index, entity.name, entity.type, entity.durable, entity.auto_delete, entity.internalFlag, entity.message_stats.publish_in, entity.message_stats.publish_out));
                index++;
            }
            ShowSysMessage(s.ToString());
        }
        /// <summary>
        /// 删除所有用户交换机信息
        /// </summary>
        private void DeleteExchanges()
        {
            var list = (from object item in lbUserExchanges.Items select item.ToString().Trim()).ToList();
            txtSysMessage.Clear();
            var sb = new StringBuilder();
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    context.SendChannel.ExchangeDelete(item);
                    sb.AppendLine("已删除交换机Name：" + item);
                }
            }
            else
            {
                sb.AppendLine("当前没有交换机可删");
            }
            ShowSysMessage(sb.ToString());
        }
        #endregion

        #region 队列
        /// <summary>
        /// 刷新队列信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshQueue_Click(object sender, EventArgs e)
        {
            ShowQueuesToList(queuesApi);
        }
        /// <summary>
        /// 查看选中队列信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueue_Click(object sender, EventArgs e)
        {
            if (lbQueues.SelectedItem == null)
            {
                return;
            }
            queue = queues.FirstOrDefault(x => x.name == lbQueues.SelectedItem.ToString());
            txtSysMessage.Clear();
            if (queue != null)
            {
                ShowSysMessage(string.Format("Name:{0},\r\nState:{1},vhost:{2},Node:{3},Durable:{4},Auto_delete:{5},Memory:{6},Messages:{7},Messages_ready：{8},Messages_unacknowledged:{9},Idle_since:{10},Consumers:{11}\r\n",
                     queue.name, queue.state, queue.vhost, queue.node, queue.durable, queue.auto_delete, queue.memory, queue.messages, queue.messages_ready, queue.messages_unacknowledged, queue.idle_since, queue.consumers));
            }
            else
            {
                ShowSysMessage("未发现该队列");
            }
        }
        /// <summary>
        /// 添加队列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            context.SendChannel.QueueDeclare(txtQueue.Text.Trim(),
                cbQueueDurable.SelectedIndex == 0,
                cbQueueExclusive.SelectedIndex == 0,
                cbAutoDelete.SelectedIndex == 0,
                null);
            ShowQueuesToList(queuesApi);
            ShowBindingsToList(bingdingsApi);
        }
        /// <summary>
        /// 队列列表选中改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbQueues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQueues.SelectedItem != null)
            {
                txtSelectQueue.Text = lbQueues.SelectedItem.ToString();
            }
        }
        /// <summary>
        /// 调用RabbitMQ接口获取队列信息
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <returns></returns>
        private async Task<List<QueueEntity>> GetQueues(string apiUrl)
        {
            string jsonContent = await GetApiResult(apiUrl);
            queues = JsonConvert.DeserializeObject<List<QueueEntity>>(jsonContent);
            return queues;
        }
        /// <summary>
        /// 查看所有队列信息（显示到右边的文本框中）
        /// </summary>
        /// <param name="apiUrl"></param>
        private async void ShowAllQueuesInfo(string apiUrl)
        {
            queues = await GetQueues(apiUrl);
            int count = queues.Count;
            txtSysMessage.Clear();
            var s = new StringBuilder();
            s.AppendLine(string.Format("Queues Count:{0}", count));
            s.AppendLine("NameList:");
            int index = 1;
            foreach (var queueEntity in queues)
            {
                s.AppendLine(index + ":" + queueEntity.name + "  ");
                index++;
            }
            s.AppendLine("");
            s.AppendLine("Detail:");
            index = 1;
            foreach (var queueEntity in queues)
            {
                s.AppendLine(string.Format("{0}.Name:{1},\r\nState:{2},vhost:{3},Node:{4},Durable:{5},Auto_delete:{6},Memory:{7},Messages:{8},Messages_ready：{9},Messages_unacknowledged:{10},Idle_since:{11},Consumers:{12}\r\n",
                    index, queueEntity.name, queueEntity.state, queueEntity.vhost, queueEntity.node, queueEntity.durable, queueEntity.auto_delete, queueEntity.memory, queueEntity.messages, queueEntity.messages_ready, queueEntity.messages_unacknowledged, queueEntity.idle_since, queueEntity.consumers));
                index++;
            }
            ShowSysMessage(s.ToString());
        }
        /// <summary>
        /// 显示队列信息到列表框
        /// </summary>
        /// <param name="apiUrl"></param>
        private async void ShowQueuesToList(string apiUrl)
        {
            lbQueues.Items.Clear();
            queues = await GetQueues(apiUrl);
            if (queues != null)
            {
                foreach (var queueEntity in queues)
                {
                    lbQueues.Items.Add(queueEntity.name);
                }
            }
        }
        /// <summary>
        /// 删除所有队列消息
        /// </summary>
        /// <param name="apiUrl"></param>
        private async void DeleteQueues(string apiUrl)
        {
            string jsonContent = await GetApiResult(apiUrl);
            var queueEntities = JsonConvert.DeserializeObject<List<QueueEntity>>(jsonContent);
            txtSysMessage.Clear();
            var s = new StringBuilder();
            if (queueEntities != null && queueEntities.Count != 0)
            {
                foreach (var queueEntity in queueEntities)
                {
                    context.SendChannel.QueueDelete(queueEntity.name);
                    s.AppendLine("已删除队列Name：" + queueEntity.name);
                }
            }
            else
            {
                s.AppendLine("当前没有队列可删");
            }
            ShowSysMessage(s.ToString());
            ShowQueuesToList(queuesApi);
        }
        #endregion

        #region 消息
        /// <summary>
        /// 绑定（交换机、队列、路由）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBind_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                context.SendChannel.QueueBind(queue.name, exchange.name, txtRoutingKey.Text);
                ShowSysMessage(string.Format("队列{0}与交换机{1}绑定成功", queue.name, exchange.name));
                ShowBindingsToList(bingdingsApi);
            }
            else
            {
                ShowSysMessage("未绑定成功");
            }
        }
        /// <summary>
        /// 解除绑定（交换机、队列、路由）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveBind_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                context.SendChannel.QueueUnbind(queue.name, exchange.name, txtRoutingKey.Text, null);
                ShowSysMessage(string.Format("队列{0}与交换机{1}解绑成功", queue.name, exchange.name));
                ShowBindingsToList(bingdingsApi);
            }
            else
            {
                ShowSysMessage("未解绑成功");
            }
        }
        /// <summary>
        /// 添加推送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            IBasicProperties properties = context.SendChannel.CreateBasicProperties();
            if (rbMessageDurableTrue.Checked)
            {
                properties.DeliveryMode = 2;
            }
            byte[] payload = Encoding.ASCII.GetBytes(this.txtMessage.Text.Trim());
            context.SendChannel.BasicPublish(exchange.name, txtMessageRoutingKey.Text.Trim(), properties, payload);
            txtSysMessage.Text = txtSysMessage.Text + string.Format("\r\nSent Message {0} RoutingKey:{1}", txtMessage.Text.Trim(), txtMessageRoutingKey.Text.Trim());
        }
        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                var s = new StringBuilder();
                s.AppendLine("Waiting for messages");
                var q = context.ListerChannel.BasicGet(queue.name, rbAckTrue.Checked);
                if (q != null)
                {
                    string w = Encoding.ASCII.GetString(q.Body);
                    s.AppendLine(string.Format("队列{0}读取从交换机{1}读取消息{2}", queue.name, exchange.name, w));
                    ShowSysMessage(s.ToString());
                }
                else
                {
                    ShowSysMessage("已经无消息可读取\r\n");
                }
            }
        }
        /// <summary>
        /// 消费消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsumeMessage_Click(object sender, EventArgs e)
        {
            txtSysMessage.Text = txtSysMessage.Text + @"Waiting for messages";
            var consumer = new QueueingBasicConsumer(context.ListerChannel);
            context.ListerChannel.BasicQos(0, 1, false);
            context.ListerChannel.BasicConsume(queue.name, rbAckTrue.Checked, consumer);
            while (true)
            {
                var res = consumer.Queue.Dequeue();
                MessageBox.Show(string.Format("队列{0}获取消息{1},线程id为{2}", queue.name, Encoding.ASCII.GetString(res.Body), Process.GetCurrentProcess().Id));
                Thread.Sleep(1000);
            }
        }
        /// <summary>
        /// 验证绑定信息
        /// </summary>
        /// <returns></returns>
        private bool CheckBind()
        {
            bool checkResult = false;
            if (string.IsNullOrWhiteSpace(txtSelectExchange.Text))
            {
                ShowSysMessage("未选择交换机");
            }
            else if (string.IsNullOrWhiteSpace(txtSelectQueue.Text))
            {
                ShowSysMessage("未选择队列");
            }
            else
            {
                //当前选中的交换机及队列
                exchange = userExchanges.FirstOrDefault(x => x.name == txtSelectExchange.Text);
                queue = queues.FirstOrDefault(x => x.name == txtSelectQueue.Text);

                if (exchange == null)
                {
                    ShowSysMessage("交换机不存在");
                }
                else if (queue == null)
                {
                    ShowSysMessage("队列不存在");
                }
                else
                {
                    checkResult = true;
                }
            }
            return checkResult;
        }
        #endregion

        #region 绑定
        /// <summary>
        /// 刷新绑定信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBindingsRefresh_Click(object sender, EventArgs e)
        {
            ShowBindingsToList(bingdingsApi);
        }
        /// <summary>
        /// 查看绑定详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBindingDetail_Click(object sender, EventArgs e)
        {
            if (lbBindings.SelectedItem == null)
            {
                return;
            }
            string bindingContent = lbBindings.SelectedItem.ToString().Replace("默认", "");
            var attr = new Regex(@"交换机:(?<1>.*?)---队列:(?<2>.*?)---Key:(?<3>.*)");
            var mat = attr.Matches(bindingContent);
            if (mat.Count != 0)
            {
                var item = mat[0];

                binding = bindings.FirstOrDefault(x => x.source == item.Groups[1].ToString() && x.destination == item.Groups[2].ToString() && x.routing_key == item.Groups[3].ToString());
                txtSysMessage.Clear();
                if (binding != null)
                {
                    ShowSysMessage(string.Format("exchange:{0},\r\nqueue:{1},\r\nvhost:{2},\r\nrouting_key:{3},\r\ndestination_type:{4},\r\nproperties_key:{5}",
                         binding.source, binding.destination, binding.vhost, binding.routing_key, binding.destination_type, binding.properties_key));
                }
                else
                {
                    ShowSysMessage("未发现该绑定关系");
                }
            }
            else
            {
                ShowSysMessage("正则匹配失败");
            }
        }
        /// <summary>
        /// 调用RabbitMQ接口获取绑定信息
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <returns></returns>
        private async Task<List<BindingEntity>> GetBindings(string apiUrl)
        {
            string jsonContent = await GetApiResult(apiUrl);
            bindings = JsonConvert.DeserializeObject<List<BindingEntity>>(jsonContent);
            return bindings;
        }

        /// <summary>
        /// 显示绑定信息
        /// </summary>
        /// <param name="apiUrl"></param>
        private async void ShowBindingsToList(string apiUrl)
        {
            lbBindings.Items.Clear();
            bindings = await GetBindings(apiUrl);
            if (bindings != null)
            {
                foreach (var bindingEntity in bindings)
                {
                    lbBindings.Items.Add(string.Format("交换机:{0}---队列:{1}---Key:{2}", string.IsNullOrWhiteSpace(bindingEntity.source) ? "默认" : bindingEntity.source, bindingEntity.destination, bindingEntity.routing_key));
                }
            }
        }
        #endregion

        #region RabbitMQ的Api操作
        /// <summary>
        /// 获取调用RabbitMQ请求结果
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <returns></returns>
        private async Task<string> GetApiResult(string apiUrl)
        {
            var response = await GetHttpClientResult(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        /// <summary>
        /// 获取Http请求结果
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> GetHttpClientResult(string Url)
        {
            var client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes(string.Format("{0}:{1}", userName, passWord));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            HttpResponseMessage response = await client.GetAsync(Url);
            return response;
        }
        /// <summary>
        /// 显示调用Api返回结果到右边的文本框中
        /// </summary>
        /// <param name="apiUrl"></param>
        private async void ShowApiResult(string apiUrl)
        {
            string jsonContent = await GetApiResult(apiUrl);
            txtSysMessage.Clear();
            ShowSysMessage(jsonContent);
        }
        #endregion

        #region 消息结果
        /// <summary>
        /// 显示消息结果
        /// </summary>
        /// <param name="msg"></param>
        public void ShowSysMessage(string msg)
        {
            if (!string.IsNullOrWhiteSpace(txtSysMessage.Text))
            {
                txtSysMessage.Text = txtSysMessage.Text + @"\r\n";
            }
            txtSysMessage.Text = txtSysMessage.Text + msg;
        }
        #endregion
       
    }
}
