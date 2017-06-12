using UnityEngine;
using System.Collections;
using Util;
using UnityEngine.UI;
using Packets;

public class LoginView : SingletonMonoBehaviour<LoginView>
{
	[SerializeField]
	private UIInput txtName;
	[SerializeField]
	private UIInput txtPwd;
	[SerializeField]
	private UILabel txtTip;

	void Start () 
	{
		
	}
	 
	public void OnClickLoginBtn()
	{
		Login login = new Login();
		login.username = txtName.text;
		login.password = txtPwd.text;

		LoginModel.Instance.TocLogin (login);

		Debug.Log(login.username);
		Debug.Log(login.password);
	}
		
}
