    public bool createConn()
    {     
        try
        {
            IPAddress ip = IPAddress.Parse(textBox_serverIp.Text);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int connPort = Int16.Parse(textBox_serverPort.Text);
            clientSocket.Connect(new IPEndPoint(ip, connPort)); //配置服务器IP与端口  
            writeLog("连接服务器成功");
            button_createConn.Text = "断开连接";
            //开启监听线程
            receiveThread = new Thread(receiveMsg);
            receiveThread.Start(this);
        }
            catch (Exception e)
        {
            writeLog("连接服务器失败" + e.ToString());
            return false;
        }
        return true;
    }