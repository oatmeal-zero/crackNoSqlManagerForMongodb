# 无限使用NoSQL Manager for MongoDB免费！！！

##软件开发说明：
* 你是不是在使用NoSQL Manager for MongoDB管理你的mongodb数据库？
* 你是不是因为NoSQL Manager for MongoDB不是免费版而使用“30天无限用”的工具每个月清理一次，让软件又重新得到30天的使用期限？
* 你是不是因为“30天无限用”这个工具而每次都要重新配置数据库链接而感到烦恼？
* 如果是这样的话，那么这款基于C#的开源软件就可以帮助到你。
* 只需一键就可以无限延续30天，不用为配置数据库链接而烦恼。


##使用说明：
* 编辑config.xml配置表，修改为本地的目录
* 执行“破解.exe”
* 破解过程中会启动NoSQL Manager for MongoDB
* 你需要手动依次点击“使用30天”->关闭弹出窗口->关闭主窗口
* 在控制台提示破解成功后按回车退出程序
* 现在打开NoSQL Manager for MongoDB软件看看吧

##设计说明：
* 猜测appConfig.xml配置文件的存放目录（程序优先取用户的应用数据目录，然后才是公共应用数据目录）
* 拷贝appConfig.xml到程序运行目录
* 修改appConfig.xml的时间到最新
* 删除appConfig.xml配置文件的存放目录
* 删除注册表中对应的键值
* 启动NoSQL Manager for MongoDB等待其被退出
* 拷贝先前备份的appConfig.xml到先前猜测的appConfig.xml配置文件的存放目录
* 删除备份的appConfig.xml（考虑到用户有可能误操作，这步没有执行，所以如果操作失误，这个appConfig.xml还是可以在这里找回来的）


注：config.xml中的program项配置的是NoSQL Manager for MongoDB软件的安装路径