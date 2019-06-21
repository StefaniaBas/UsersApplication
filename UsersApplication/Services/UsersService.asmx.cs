using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UsersApplication
{
	/// <summary>
	/// Summary description for UsersService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class UsersService : System.Web.Services.WebService
	{

		[WebMethod(Description ="Use this method to get user's info searching by id")]
		public UserDataResponse GetUserById(int Id)
		{
			UserDataResponse response = new UserDataResponse();
			User user = new User();
			string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
			using (SqlConnection con = new SqlConnection(connectionString)) {
				string query = "Select Username, FirstName, LastName from MyUsers " +
					"where ID=@Id";
				using (SqlCommand cmd = new SqlCommand(query, con)) {
					cmd.Parameters.AddWithValue("@Id", Id);
					con.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						user.Id = Id;
						user.Username = reader["Username"].ToString();
						user.FirstName = reader["FirstName"].ToString();
						user.LastName = reader["LastName"].ToString();
						response.user = user;
					}
					con.Close();
				}
			}
			if (user.Id==0)
			{
				response.errorResponse = "The id "+ Id +" doesn't exist!";
			}
			return response;
		}

		[WebMethod(Description = "Use this method to validate your username and password")]
		public Boolean UserAuthentication(string username, string password)
		{
			User user = new User();
			Boolean flag = true;
			string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string query = "Select ID from myusers where Username=@username AND MyPassword=@password";
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@username", username);
					cmd.Parameters.AddWithValue("@password", password);
					con.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						user.Id = Convert.ToInt32(reader["ID"]);
					}
					con.Close();
				}
			}
			if (user.Id == 0)
			{
				flag = false;
			}
			return flag;
		}

		[WebMethod(Description = "Use this method to register")]
		public Boolean UserRegistration(string username, string password, string firstName, string lastName)
		{
			User user = new User();
			Boolean responseMessage = true;
			string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string query = "Insert into MyUsers values(@username, @password, @firstName, @lastName)";
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					try
					{
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue("@password", password);
						cmd.Parameters.AddWithValue("@firstName", firstName);
						cmd.Parameters.AddWithValue("@lastName", lastName);
						con.Open();

						cmd.ExecuteNonQuery();
						con.Close();
					} catch (Exception e) {
						responseMessage = false;
					}
				}
			}
			return responseMessage;
		}
	}
}
