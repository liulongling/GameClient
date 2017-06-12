using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerMessage;
using UnityEngine;
using Util;
using Net;

public class ChatModel : BaseModel<ChatModel>
{
    protected override void InitAddTocHandler()
    {
        AddTocHandler(typeof(TocChat), STocChat);
    }

    private void STocChat(object data)
    {
        TocChat toc = data as TocChat;
        if(ChatView.Exists)
        {
             string content = toc.name + ":" + toc.content;
             Debug.Log(content);
             ChatView.Instance.AddChatItem(content);
        }
    }

    public void CTosChat(string name , string content)
    {
        TosChat tos = new TosChat();
        tos.name = name;
        tos.content = content;
        SendTos(tos);
    }
}