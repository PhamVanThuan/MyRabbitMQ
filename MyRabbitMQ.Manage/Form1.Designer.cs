namespace MyRabbitMQ.Manage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetApiResult = new System.Windows.Forms.Button();
            this.txtApiName = new System.Windows.Forms.TextBox();
            this.btnQueuesDelete = new System.Windows.Forms.Button();
            this.btnExchangesDelete = new System.Windows.Forms.Button();
            this.btnCheckEnv = new System.Windows.Forms.Button();
            this.btnExchangesView = new System.Windows.Forms.Button();
            this.btnQueuesView = new System.Windows.Forms.Button();
            this.txtHostUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbExchangeAutoDelete = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnRefreshUserExchanges = new System.Windows.Forms.Button();
            this.cbExchangeDurable = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddExchange = new System.Windows.Forms.Button();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemoveUserExchanges = new System.Windows.Forms.Button();
            this.lbUserExchanges = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbExchangeType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRemoveSysExchanges = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSysExchanges = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnRefreshQueue = new System.Windows.Forms.Button();
            this.lbQueues = new System.Windows.Forms.ListBox();
            this.btnAddQueue = new System.Windows.Forms.Button();
            this.cbAutoDelete = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbQueueExclusive = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbQueueDurable = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMessageRoutingKey = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnRemoveBind = new System.Windows.Forms.Button();
            this.btnBind = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbMessageDurableFalse = new System.Windows.Forms.RadioButton();
            this.rbMessageDurableTrue = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbAckFalse = new System.Windows.Forms.RadioButton();
            this.rbAckTrue = new System.Windows.Forms.RadioButton();
            this.btnConsumeMessage = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSelectQueue = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSelectExchange = new System.Windows.Forms.TextBox();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnBindingDetail = new System.Windows.Forms.Button();
            this.btnBindingsRefresh = new System.Windows.Forms.Button();
            this.lbBindings = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtSysMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "其他服务(API)：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnGetApiResult);
            this.groupBox1.Controls.Add(this.txtApiName);
            this.groupBox1.Controls.Add(this.btnQueuesDelete);
            this.groupBox1.Controls.Add(this.btnExchangesDelete);
            this.groupBox1.Controls.Add(this.btnCheckEnv);
            this.groupBox1.Controls.Add(this.btnExchangesView);
            this.groupBox1.Controls.Add(this.btnQueuesView);
            this.groupBox1.Controls.Add(this.txtHostUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtHostName);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 120);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RabbitMQ基本配置";
            // 
            // btnGetApiResult
            // 
            this.btnGetApiResult.Location = new System.Drawing.Point(479, 88);
            this.btnGetApiResult.Name = "btnGetApiResult";
            this.btnGetApiResult.Size = new System.Drawing.Size(86, 23);
            this.btnGetApiResult.TabIndex = 42;
            this.btnGetApiResult.Text = "查看返回信息";
            this.btnGetApiResult.UseVisualStyleBackColor = true;
            this.btnGetApiResult.Click += new System.EventHandler(this.btnGetApiResult_Click);
            // 
            // txtApiName
            // 
            this.txtApiName.Location = new System.Drawing.Point(104, 89);
            this.txtApiName.Name = "txtApiName";
            this.txtApiName.Size = new System.Drawing.Size(367, 21);
            this.txtApiName.TabIndex = 41;
            this.txtApiName.Text = "users";
            // 
            // btnQueuesDelete
            // 
            this.btnQueuesDelete.Location = new System.Drawing.Point(479, 54);
            this.btnQueuesDelete.Name = "btnQueuesDelete";
            this.btnQueuesDelete.Size = new System.Drawing.Size(86, 23);
            this.btnQueuesDelete.TabIndex = 40;
            this.btnQueuesDelete.Text = "删除所有队列";
            this.btnQueuesDelete.UseVisualStyleBackColor = true;
            this.btnQueuesDelete.Click += new System.EventHandler(this.btnQueuesDelete_Click);
            // 
            // btnExchangesDelete
            // 
            this.btnExchangesDelete.Location = new System.Drawing.Point(385, 54);
            this.btnExchangesDelete.Name = "btnExchangesDelete";
            this.btnExchangesDelete.Size = new System.Drawing.Size(86, 23);
            this.btnExchangesDelete.TabIndex = 39;
            this.btnExchangesDelete.Text = "删除用户交换机";
            this.btnExchangesDelete.UseVisualStyleBackColor = true;
            this.btnExchangesDelete.Click += new System.EventHandler(this.btnExchangesDelete_Click);
            // 
            // btnCheckEnv
            // 
            this.btnCheckEnv.Location = new System.Drawing.Point(103, 54);
            this.btnCheckEnv.Name = "btnCheckEnv";
            this.btnCheckEnv.Size = new System.Drawing.Size(86, 23);
            this.btnCheckEnv.TabIndex = 38;
            this.btnCheckEnv.Text = "检查基本环境";
            this.btnCheckEnv.UseVisualStyleBackColor = true;
            this.btnCheckEnv.Click += new System.EventHandler(this.btnCheckEnv_Click);
            // 
            // btnExchangesView
            // 
            this.btnExchangesView.Location = new System.Drawing.Point(197, 54);
            this.btnExchangesView.Name = "btnExchangesView";
            this.btnExchangesView.Size = new System.Drawing.Size(86, 23);
            this.btnExchangesView.TabIndex = 30;
            this.btnExchangesView.Text = "查看所有交换机";
            this.btnExchangesView.UseVisualStyleBackColor = true;
            this.btnExchangesView.Click += new System.EventHandler(this.btnExchangesView_Click);
            // 
            // btnQueuesView
            // 
            this.btnQueuesView.Location = new System.Drawing.Point(291, 54);
            this.btnQueuesView.Name = "btnQueuesView";
            this.btnQueuesView.Size = new System.Drawing.Size(86, 23);
            this.btnQueuesView.TabIndex = 31;
            this.btnQueuesView.Text = "查看所有队列";
            this.btnQueuesView.UseVisualStyleBackColor = true;
            this.btnQueuesView.Click += new System.EventHandler(this.btnQueuesView_Click);
            // 
            // txtHostUrl
            // 
            this.txtHostUrl.Location = new System.Drawing.Point(78, 26);
            this.txtHostUrl.Name = "txtHostUrl";
            this.txtHostUrl.Size = new System.Drawing.Size(151, 21);
            this.txtHostUrl.TabIndex = 28;
            this.txtHostUrl.Text = "http://localhost:15672";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "宿主地址：";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(7, 54);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "刷新用户配置";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(504, 26);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(66, 21);
            this.txtPwd.TabIndex = 35;
            this.txtPwd.Text = "guest";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(284, 26);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(66, 21);
            this.txtHostName.TabIndex = 32;
            this.txtHostName.Text = "localhost";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(405, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(56, 21);
            this.txtUsername.TabIndex = 32;
            this.txtUsername.Text = "guest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "主机名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "用户名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbExchangeAutoDelete);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.btnExchange);
            this.groupBox2.Controls.Add(this.btnRefreshUserExchanges);
            this.groupBox2.Controls.Add(this.cbExchangeDurable);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnAddExchange);
            this.groupBox2.Controls.Add(this.txtExchangeName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnRemoveUserExchanges);
            this.groupBox2.Controls.Add(this.lbUserExchanges);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbExchangeType);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnRemoveSysExchanges);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbSysExchanges);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 172);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "交换机";
            // 
            // cbExchangeAutoDelete
            // 
            this.cbExchangeAutoDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExchangeAutoDelete.FormattingEnabled = true;
            this.cbExchangeAutoDelete.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbExchangeAutoDelete.Location = new System.Drawing.Point(479, 118);
            this.cbExchangeAutoDelete.Name = "cbExchangeAutoDelete";
            this.cbExchangeAutoDelete.Size = new System.Drawing.Size(90, 20);
            this.cbExchangeAutoDelete.TabIndex = 62;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(410, 121);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 61;
            this.label24.Text = "自动删除：";
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(339, 98);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(51, 23);
            this.btnExchange.TabIndex = 60;
            this.btnExchange.Text = "查看";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnRefreshUserExchanges
            // 
            this.btnRefreshUserExchanges.Location = new System.Drawing.Point(339, 71);
            this.btnRefreshUserExchanges.Name = "btnRefreshUserExchanges";
            this.btnRefreshUserExchanges.Size = new System.Drawing.Size(51, 23);
            this.btnRefreshUserExchanges.TabIndex = 59;
            this.btnRefreshUserExchanges.Text = "刷新";
            this.btnRefreshUserExchanges.UseVisualStyleBackColor = true;
            this.btnRefreshUserExchanges.Click += new System.EventHandler(this.btnRefreshUserExchanges_Click);
            // 
            // cbExchangeDurable
            // 
            this.cbExchangeDurable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExchangeDurable.FormattingEnabled = true;
            this.cbExchangeDurable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbExchangeDurable.Location = new System.Drawing.Point(479, 95);
            this.cbExchangeDurable.Name = "cbExchangeDurable";
            this.cbExchangeDurable.Size = new System.Drawing.Size(90, 20);
            this.cbExchangeDurable.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 57;
            this.label16.Text = "持久化：";
            // 
            // btnAddExchange
            // 
            this.btnAddExchange.Location = new System.Drawing.Point(498, 144);
            this.btnAddExchange.Name = "btnAddExchange";
            this.btnAddExchange.Size = new System.Drawing.Size(71, 23);
            this.btnAddExchange.TabIndex = 56;
            this.btnAddExchange.Text = "添加";
            this.btnAddExchange.UseVisualStyleBackColor = true;
            this.btnAddExchange.Click += new System.EventHandler(this.btnAddExchange_Click);
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(479, 65);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(90, 21);
            this.txtExchangeName.TabIndex = 50;
            this.txtExchangeName.Text = "testExchange";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 55;
            this.label12.Text = "名称：";
            // 
            // btnRemoveUserExchanges
            // 
            this.btnRemoveUserExchanges.Location = new System.Drawing.Point(339, 42);
            this.btnRemoveUserExchanges.Name = "btnRemoveUserExchanges";
            this.btnRemoveUserExchanges.Size = new System.Drawing.Size(51, 23);
            this.btnRemoveUserExchanges.TabIndex = 54;
            this.btnRemoveUserExchanges.Text = "移出";
            this.btnRemoveUserExchanges.UseVisualStyleBackColor = true;
            this.btnRemoveUserExchanges.Click += new System.EventHandler(this.btnRemoveUserExchanges_Click);
            // 
            // lbUserExchanges
            // 
            this.lbUserExchanges.FormattingEnabled = true;
            this.lbUserExchanges.ItemHeight = 12;
            this.lbUserExchanges.Location = new System.Drawing.Point(207, 42);
            this.lbUserExchanges.Name = "lbUserExchanges";
            this.lbUserExchanges.Size = new System.Drawing.Size(115, 112);
            this.lbUserExchanges.TabIndex = 53;
            this.lbUserExchanges.SelectedIndexChanged += new System.EventHandler(this.lbUserExchanges_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(205, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 52;
            this.label15.Text = "用户exchange";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 51;
            this.label14.Text = "类型：";
            // 
            // cbExchangeType
            // 
            this.cbExchangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExchangeType.FormattingEnabled = true;
            this.cbExchangeType.Items.AddRange(new object[] {
            "fanout",
            "topic",
            "direct"});
            this.cbExchangeType.Location = new System.Drawing.Point(479, 39);
            this.cbExchangeType.Name = "cbExchangeType";
            this.cbExchangeType.Size = new System.Drawing.Size(90, 20);
            this.cbExchangeType.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(420, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 48;
            this.label13.Text = "添加交换机";
            // 
            // btnRemoveSysExchanges
            // 
            this.btnRemoveSysExchanges.Enabled = false;
            this.btnRemoveSysExchanges.Location = new System.Drawing.Point(150, 42);
            this.btnRemoveSysExchanges.Name = "btnRemoveSysExchanges";
            this.btnRemoveSysExchanges.Size = new System.Drawing.Size(51, 23);
            this.btnRemoveSysExchanges.TabIndex = 45;
            this.btnRemoveSysExchanges.Text = "移出";
            this.btnRemoveSysExchanges.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 12);
            this.label11.TabIndex = 47;
            this.label11.Text = "限定exchange(移除才可删除):";
            // 
            // lbSysExchanges
            // 
            this.lbSysExchanges.FormattingEnabled = true;
            this.lbSysExchanges.ItemHeight = 12;
            this.lbSysExchanges.Items.AddRange(new object[] {
            "",
            "amq.direct ",
            "amq.fanout ",
            "amq.headers",
            "amq.match",
            "amq.rabbitmq.log ",
            "amq.rabbitmq.trace",
            "amq.topic"});
            this.lbSysExchanges.Location = new System.Drawing.Point(23, 42);
            this.lbSysExchanges.Name = "lbSysExchanges";
            this.lbSysExchanges.Size = new System.Drawing.Size(121, 112);
            this.lbSysExchanges.TabIndex = 46;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQueue);
            this.groupBox3.Controls.Add(this.btnRefreshQueue);
            this.groupBox3.Controls.Add(this.lbQueues);
            this.groupBox3.Controls.Add(this.btnAddQueue);
            this.groupBox3.Controls.Add(this.cbAutoDelete);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cbQueueExclusive);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.cbQueueDurable);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtQueue);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(13, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 173);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "队列";
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(85, 134);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(51, 23);
            this.btnQueue.TabIndex = 49;
            this.btnQueue.Text = "查看";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnRefreshQueue
            // 
            this.btnRefreshQueue.Location = new System.Drawing.Point(21, 134);
            this.btnRefreshQueue.Name = "btnRefreshQueue";
            this.btnRefreshQueue.Size = new System.Drawing.Size(51, 23);
            this.btnRefreshQueue.TabIndex = 56;
            this.btnRefreshQueue.Text = "刷新";
            this.btnRefreshQueue.UseVisualStyleBackColor = true;
            this.btnRefreshQueue.Click += new System.EventHandler(this.btnRefreshQueue_Click);
            // 
            // lbQueues
            // 
            this.lbQueues.FormattingEnabled = true;
            this.lbQueues.ItemHeight = 12;
            this.lbQueues.Location = new System.Drawing.Point(21, 16);
            this.lbQueues.Name = "lbQueues";
            this.lbQueues.Size = new System.Drawing.Size(115, 112);
            this.lbQueues.TabIndex = 50;
            this.lbQueues.SelectedIndexChanged += new System.EventHandler(this.lbQueues_SelectedIndexChanged);
            // 
            // btnAddQueue
            // 
            this.btnAddQueue.Location = new System.Drawing.Point(237, 121);
            this.btnAddQueue.Name = "btnAddQueue";
            this.btnAddQueue.Size = new System.Drawing.Size(71, 23);
            this.btnAddQueue.TabIndex = 55;
            this.btnAddQueue.Text = "添加";
            this.btnAddQueue.UseVisualStyleBackColor = true;
            this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
            // 
            // cbAutoDelete
            // 
            this.cbAutoDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoDelete.FormattingEnabled = true;
            this.cbAutoDelete.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbAutoDelete.Location = new System.Drawing.Point(204, 95);
            this.cbAutoDelete.Name = "cbAutoDelete";
            this.cbAutoDelete.Size = new System.Drawing.Size(104, 20);
            this.cbAutoDelete.TabIndex = 54;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(145, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 53;
            this.label20.Text = "自动删除";
            // 
            // cbQueueExclusive
            // 
            this.cbQueueExclusive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueueExclusive.FormattingEnabled = true;
            this.cbQueueExclusive.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbQueueExclusive.Location = new System.Drawing.Point(204, 69);
            this.cbQueueExclusive.Name = "cbQueueExclusive";
            this.cbQueueExclusive.Size = new System.Drawing.Size(104, 20);
            this.cbQueueExclusive.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(145, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 51;
            this.label19.Text = "排他性";
            // 
            // cbQueueDurable
            // 
            this.cbQueueDurable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueueDurable.FormattingEnabled = true;
            this.cbQueueDurable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbQueueDurable.Location = new System.Drawing.Point(204, 43);
            this.cbQueueDurable.Name = "cbQueueDurable";
            this.cbQueueDurable.Size = new System.Drawing.Size(104, 20);
            this.cbQueueDurable.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(145, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 47;
            this.label18.Text = "持久化";
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(204, 16);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(104, 21);
            this.txtQueue.TabIndex = 45;
            this.txtQueue.Text = "testQueue";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 46;
            this.label17.Text = "名称";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMessageRoutingKey);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.btnRemoveBind);
            this.groupBox4.Controls.Add(this.btnBind);
            this.groupBox4.Controls.Add(this.txtMessage);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.btnConsumeMessage);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.btnReceiveMessage);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.txtRoutingKey);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txtSelectQueue);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtSelectExchange);
            this.groupBox4.Controls.Add(this.btnAddMessage);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(342, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 350);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "消息";
            // 
            // txtMessageRoutingKey
            // 
            this.txtMessageRoutingKey.Location = new System.Drawing.Point(129, 215);
            this.txtMessageRoutingKey.Name = "txtMessageRoutingKey";
            this.txtMessageRoutingKey.Size = new System.Drawing.Size(103, 21);
            this.txtMessageRoutingKey.TabIndex = 77;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 218);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 76;
            this.label29.Text = "路由Key";
            // 
            // btnRemoveBind
            // 
            this.btnRemoveBind.Location = new System.Drawing.Point(129, 97);
            this.btnRemoveBind.Name = "btnRemoveBind";
            this.btnRemoveBind.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveBind.TabIndex = 75;
            this.btnRemoveBind.Text = "解绑";
            this.btnRemoveBind.UseVisualStyleBackColor = true;
            this.btnRemoveBind.Click += new System.EventHandler(this.btnRemoveBind_Click);
            // 
            // btnBind
            // 
            this.btnBind.Location = new System.Drawing.Point(10, 97);
            this.btnBind.Name = "btnBind";
            this.btnBind.Size = new System.Drawing.Size(103, 23);
            this.btnBind.TabIndex = 74;
            this.btnBind.Text = "绑定";
            this.btnBind.UseVisualStyleBackColor = true;
            this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(129, 188);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(103, 21);
            this.txtMessage.TabIndex = 73;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 191);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 72;
            this.label32.Text = "消息内容";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbMessageDurableFalse);
            this.groupBox5.Controls.Add(this.rbMessageDurableTrue);
            this.groupBox5.Location = new System.Drawing.Point(129, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(86, 34);
            this.groupBox5.TabIndex = 71;
            this.groupBox5.TabStop = false;
            // 
            // rbMessageDurableFalse
            // 
            this.rbMessageDurableFalse.AutoSize = true;
            this.rbMessageDurableFalse.Location = new System.Drawing.Point(47, 12);
            this.rbMessageDurableFalse.Name = "rbMessageDurableFalse";
            this.rbMessageDurableFalse.Size = new System.Drawing.Size(35, 16);
            this.rbMessageDurableFalse.TabIndex = 1;
            this.rbMessageDurableFalse.Text = "否";
            this.rbMessageDurableFalse.UseVisualStyleBackColor = true;
            // 
            // rbMessageDurableTrue
            // 
            this.rbMessageDurableTrue.AutoSize = true;
            this.rbMessageDurableTrue.Checked = true;
            this.rbMessageDurableTrue.Location = new System.Drawing.Point(6, 12);
            this.rbMessageDurableTrue.Name = "rbMessageDurableTrue";
            this.rbMessageDurableTrue.Size = new System.Drawing.Size(35, 16);
            this.rbMessageDurableTrue.TabIndex = 0;
            this.rbMessageDurableTrue.TabStop = true;
            this.rbMessageDurableTrue.Text = "是";
            this.rbMessageDurableTrue.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbAckFalse);
            this.groupBox6.Controls.Add(this.rbAckTrue);
            this.groupBox6.Location = new System.Drawing.Point(129, 282);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(86, 34);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            // 
            // rbAckFalse
            // 
            this.rbAckFalse.AutoSize = true;
            this.rbAckFalse.Location = new System.Drawing.Point(47, 12);
            this.rbAckFalse.Name = "rbAckFalse";
            this.rbAckFalse.Size = new System.Drawing.Size(35, 16);
            this.rbAckFalse.TabIndex = 1;
            this.rbAckFalse.Text = "否";
            this.rbAckFalse.UseVisualStyleBackColor = true;
            // 
            // rbAckTrue
            // 
            this.rbAckTrue.AutoSize = true;
            this.rbAckTrue.Checked = true;
            this.rbAckTrue.Location = new System.Drawing.Point(6, 12);
            this.rbAckTrue.Name = "rbAckTrue";
            this.rbAckTrue.Size = new System.Drawing.Size(35, 16);
            this.rbAckTrue.TabIndex = 0;
            this.rbAckTrue.TabStop = true;
            this.rbAckTrue.Text = "是";
            this.rbAckTrue.UseVisualStyleBackColor = true;
            // 
            // btnConsumeMessage
            // 
            this.btnConsumeMessage.Location = new System.Drawing.Point(129, 322);
            this.btnConsumeMessage.Name = "btnConsumeMessage";
            this.btnConsumeMessage.Size = new System.Drawing.Size(103, 23);
            this.btnConsumeMessage.TabIndex = 69;
            this.btnConsumeMessage.Text = "消费消息";
            this.btnConsumeMessage.UseVisualStyleBackColor = true;
            this.btnConsumeMessage.Click += new System.EventHandler(this.btnConsumeMessage_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 298);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 12);
            this.label28.TabIndex = 68;
            this.label28.Text = "是否添加确认标记";
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Location = new System.Drawing.Point(12, 322);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(103, 23);
            this.btnReceiveMessage.TabIndex = 67;
            this.btnReceiveMessage.Text = "接受消息";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 273);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 66;
            this.label27.Text = "接受消息";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(129, 70);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(103, 21);
            this.txtRoutingKey.TabIndex = 65;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 64;
            this.label26.Text = "路由Key";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 165);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 63;
            this.label25.Text = "持久化";
            // 
            // txtSelectQueue
            // 
            this.txtSelectQueue.Enabled = false;
            this.txtSelectQueue.Location = new System.Drawing.Point(129, 43);
            this.txtSelectQueue.Name = "txtSelectQueue";
            this.txtSelectQueue.Size = new System.Drawing.Size(103, 21);
            this.txtSelectQueue.TabIndex = 60;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 61;
            this.label22.Text = "选择队列";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 138);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 62;
            this.label23.Text = "推送消息";
            // 
            // txtSelectExchange
            // 
            this.txtSelectExchange.Enabled = false;
            this.txtSelectExchange.Location = new System.Drawing.Point(129, 16);
            this.txtSelectExchange.Name = "txtSelectExchange";
            this.txtSelectExchange.Size = new System.Drawing.Size(103, 21);
            this.txtSelectExchange.TabIndex = 58;
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMessage.Location = new System.Drawing.Point(129, 251);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(103, 23);
            this.btnAddMessage.TabIndex = 57;
            this.btnAddMessage.Text = "推送消息";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 59;
            this.label5.Text = "选择用户exchange";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnBindingDetail);
            this.groupBox7.Controls.Add(this.btnBindingsRefresh);
            this.groupBox7.Controls.Add(this.lbBindings);
            this.groupBox7.Location = new System.Drawing.Point(13, 487);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(322, 171);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "绑定关系";
            // 
            // btnBindingDetail
            // 
            this.btnBindingDetail.Location = new System.Drawing.Point(259, 49);
            this.btnBindingDetail.Name = "btnBindingDetail";
            this.btnBindingDetail.Size = new System.Drawing.Size(51, 23);
            this.btnBindingDetail.TabIndex = 45;
            this.btnBindingDetail.Text = "查看";
            this.btnBindingDetail.UseVisualStyleBackColor = true;
            this.btnBindingDetail.Click += new System.EventHandler(this.btnBindingDetail_Click);
            // 
            // btnBindingsRefresh
            // 
            this.btnBindingsRefresh.Location = new System.Drawing.Point(259, 20);
            this.btnBindingsRefresh.Name = "btnBindingsRefresh";
            this.btnBindingsRefresh.Size = new System.Drawing.Size(51, 23);
            this.btnBindingsRefresh.TabIndex = 47;
            this.btnBindingsRefresh.Text = "刷新";
            this.btnBindingsRefresh.UseVisualStyleBackColor = true;
            this.btnBindingsRefresh.Click += new System.EventHandler(this.btnBindingsRefresh_Click);
            // 
            // lbBindings
            // 
            this.lbBindings.FormattingEnabled = true;
            this.lbBindings.ItemHeight = 12;
            this.lbBindings.Location = new System.Drawing.Point(11, 20);
            this.lbBindings.Name = "lbBindings";
            this.lbBindings.Size = new System.Drawing.Size(235, 136);
            this.lbBindings.TabIndex = 46;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtSysMessage);
            this.groupBox8.Location = new System.Drawing.Point(600, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(287, 645);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "消息结果";
            // 
            // txtSysMessage
            // 
            this.txtSysMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSysMessage.Location = new System.Drawing.Point(3, 17);
            this.txtSysMessage.Multiline = true;
            this.txtSysMessage.Name = "txtSysMessage";
            this.txtSysMessage.Size = new System.Drawing.Size(281, 625);
            this.txtSysMessage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 662);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabbitMQ管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetApiResult;
        private System.Windows.Forms.TextBox txtApiName;
        private System.Windows.Forms.Button btnQueuesDelete;
        private System.Windows.Forms.Button btnExchangesDelete;
        private System.Windows.Forms.Button btnCheckEnv;
        private System.Windows.Forms.Button btnExchangesView;
        private System.Windows.Forms.Button btnQueuesView;
        private System.Windows.Forms.TextBox txtHostUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbExchangeAutoDelete;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnRefreshUserExchanges;
        private System.Windows.Forms.ComboBox cbExchangeDurable;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddExchange;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemoveUserExchanges;
        private System.Windows.Forms.ListBox lbUserExchanges;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbExchangeType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRemoveSysExchanges;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbSysExchanges;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnRefreshQueue;
        private System.Windows.Forms.ListBox lbQueues;
        private System.Windows.Forms.Button btnAddQueue;
        private System.Windows.Forms.ComboBox cbAutoDelete;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbQueueExclusive;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbQueueDurable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMessageRoutingKey;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnRemoveBind;
        private System.Windows.Forms.Button btnBind;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbMessageDurableFalse;
        private System.Windows.Forms.RadioButton rbMessageDurableTrue;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbAckFalse;
        private System.Windows.Forms.RadioButton rbAckTrue;
        private System.Windows.Forms.Button btnConsumeMessage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnReceiveMessage;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSelectQueue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSelectExchange;
        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnBindingDetail;
        private System.Windows.Forms.Button btnBindingsRefresh;
        private System.Windows.Forms.ListBox lbBindings;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtSysMessage;
    }
}

