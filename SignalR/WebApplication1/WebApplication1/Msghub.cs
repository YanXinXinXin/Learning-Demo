using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Msghub : Hub
    {
        //在hub方法中编写的方法，都是要被客户端调用的方法
        public void SenMsg(string name,string txt)
        {
        

            //服务器主动调用客户端的方法
            Clients.All.getMsg(name,txt);

            //除了自己 其他的人接收
           // Clients.Others.getMsg(txt);

        }
    }
}