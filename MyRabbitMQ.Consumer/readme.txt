1、RabbitMQ：作用就是提高系统的并发性，将一些不需要及时响应客户端且占用较多资源的操作，放入队列，再由另外一个线程，去异步处理这些队列，可极大的提高系统的并发能力。
下载地址：http://www.rabbitmq.com/download.html

2、Erlang环境：安装RabbitMQ服务前，需要安装Erlang运行环境，没有安装会在安装过程中会提醒先安装Erlang环境。（安装完RabbitMQ服务后，会在Windows服务中看到。）
下载地址：http://www.erlang.org/download.html
安装完以后，设置用户环境变量：ERLANG_HOME=安装的目前

3、找到安装RabbitMQ的目录，找到sbin文件，按住Shift的同时点击右键，选择【在此处打开命令窗口】，进行CMD
示例：
D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin>rabbitmq-server
ERROR: node with name "rabbit" already running on "WIN-20160416PGH"

//注：因为安装完RabbitMQ已启动，这里提示"already running"。
//注：停止运行：rabbitmqctl stop

4、下面我们使用rabbitmqctl控制台命令（位于D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin）来配置vhost，创建用户，密码，绑定权限等。
(1)、首先创建vhosts，命令如下：
//添加创建虚拟主机（名称为：RabbitMQ_Server）：      
D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin>rabbitmqctl add_vhost RabbitMQ_Server
Creating vhost "RabbitMQ_Server" ...  

//注：删除虚拟主机（名称为：RabbitMQ_Server）：
rabbitmqctl delete_vhost RabbitMQ_Server

(2)、显示出所有虚拟主机信息，命令如下：
D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin>rabbitmqctl list_vhosts
Listing vhosts ...
/
RabbitMQ_Server

(3)、下面添加用户和密码(用户名rabbitmq, 密码：rabbitmq)：
D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin>rabbitmqctl add_user rabbitmq rabbitmq
Creating user "rabbitmq" ...

//注:修改用户(用户名rabbitmq)密码：
rabbitmqctl change_password rabbitmq rabbitmq

(4)、绑定用户(用户名rabbitmq)权限：
D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin>rabbitmqctl set_permissions -p RabbitMQ_Server rabbitmq ".*" ".*" ".*"
Setting permissions for user "rabbitmq" in vhost "RabbitMQ_Server" ...

//注：清除用户(用户名rabbitmq)权限：
rabbitmqctl clear_permissions [-p vhostpath] rabbitmq

(5)、列出用户(用户名rabbitmq)权限：
D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin>rabbitmqctl list_user_permissions rabbitmq
Listing permissions for user "rabbitmq" ...
RabbitMQ_Server .*      .*      .*

(5)我们还可以安装 RabbitMQWeb管理插件
D:\Program Files\RabbitMQ Server\rabbitmq_server-3.6.1\sbin>rabbitmq-plugins enable rabbitmq_management
The following plugins have been enabled:
  mochiweb
  webmachine
  rabbitmq_web_dispatch
  amqp_client
  rabbitmq_management_agent
  rabbitmq_management

Applying plugin configuration to rabbit@WIN-20160416PGH... started 6 plugins.

//注：安装后需要重启服务
service rabbitmq-server restart
//有时候 使用service 可能无法实现服务器 restart,可以直接使用：
rabbitmq-plugins enable rabbitmq_management
rabbitmq-server started

测试是否安装成功,打开浏览器登录：http://127.0.0.1:15672 (55672也可以)，直接跳转到web管理,使用guest/guest默认的账户登录管理