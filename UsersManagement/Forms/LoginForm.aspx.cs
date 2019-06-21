using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsersManagement
{
	public partial class LoginForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void login_Click(object sender, EventArgs e)
		{
			UsersApplicationService.UsersServiceSoapClient client = new UsersApplicationService.UsersServiceSoapClient();
			Boolean loginResponse = client.UserAuthentication(usernameValue.Text, passwordValue.Text);

			if (loginResponse == true)
			{
				usernameValue.Text = null;
				passwordValue.Text = null;
				responseMessage.Text = "Your login is successfully completed!";
			}
			else
			{
				responseMessage.Text = "Your login failed!";
			}
		}
	}
}