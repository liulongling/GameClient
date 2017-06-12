using UnityEngine;
using System.Collections;
using ServerMessage;
using Packets;

public class LoginModel : BaseModel<LoginModel>
{
    protected override void InitAddTocHandler()
    {
		AddTocHandler(typeof(Login), TocLogin);
    }

	public void TocLogin(object data)
    {
		//Login login = data as Login;
        // Debug.Log(login.username);
		//Debug.Log(login.password);
        SendTos(data);
    }

}
