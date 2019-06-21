using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsersManagement
{
	public partial class RegistrationForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void register_Click(object sender, EventArgs e)
		{
			string username = usernameValue.Text;
			string password = passwordValue.Text;
			string passwordConfirmation = passwordConfirmationValue.Text;
			string firstName = firstNameValue.Text;
			string lastName = lastNameValue.Text;
			Boolean registrationResponse = false;
			bool isEmail = Regex.IsMatch(username, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

			if (password == passwordConfirmation && isEmail)
			{
				UsersApplicationService.UsersServiceSoapClient client = new UsersApplicationService.UsersServiceSoapClient();
				registrationResponse = client.UserRegistration(username, password, firstName, lastName);

			}
			if (registrationResponse == true)
			{

				usernameValue.Text = null;
				passwordValue.Text = null;
				passwordConfirmationValue.Text = null;
				firstNameValue.Text = null;
				lastNameValue.Text = null;

				responseMessage.Text = "Your registration is successfully completed!";
				Response.Redirect("http://localhost:62110/Forms/LoginForm.aspx");

			}
			else
			{
				if (password != passwordConfirmation && !isEmail)
				{
					responseMessage.Text = "Your registration failed, because your username and  your password is not valid!";
				}
				else if (!isEmail)
				{
					responseMessage.Text = "Your registration failed, because your username is not valid!";
				}
				else if (password != passwordConfirmation)
				{
					responseMessage.Text = "Your registration failed, because your password is not valid !";
				}
				else
				{
					responseMessage.Text = "Your registration failed";
				}
			}
		}


	}
}