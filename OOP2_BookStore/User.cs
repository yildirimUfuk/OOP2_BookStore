using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
	public abstract class User
	{
		private int userID;//kendimiz atayacağız.
		private string name;
		private string adress;
		private string email;
		private string username;
		private string password;
		private string surname;

		/// <summary>
		/// user ID
		/// </summary>
		public int UserID { get => userID; set => userID = value; }
		/// <summary>
		/// user Name
		/// </summary>
		public string Name { get => name; set => name = value; }
		/// <summary>
		/// user Adress
		/// </summary>
		public string Adress { get => adress; set => adress = value; }
		/// <summary>
		/// user Email
		/// </summary>
		public string Email { get => email; set => email = value; }
		/// <summary>
		/// user Username
		/// </summary>
		public string Username { get => username; set => username = value; }
		/// <summary>
		/// user password
		/// </summary>
		public string Password { get => password; set => password = value; }
		/// <summary>
		/// user surname
		/// </summary>
		public string Surname { get => surname; set => surname = value; }
	}
}
