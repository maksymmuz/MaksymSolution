using System.Text.RegularExpressions;

namespace Authorization
{
	internal class LoginPasswordVerification
	{
		string? _login;
		string? _password;
		bool _isMatch;

		public void Start()
		{
			while (!_isMatch && _login != "Exit")
			{
				Invitation();

				if (CheckLoginPassword())
				{
					Congratulation();
				}
			}
		}

		void Invitation()
		{
			Console.Write("Enter login (English letters only) or \"Exit\" to exit: ");
			_login = Console.ReadLine();

			Console.Write("Enter password (Numbers and special symbols only): ");
			_password = Console.ReadLine();
		}

		public bool CheckLoginPassword()
		{
			bool loginFlag = CheckLogin(_login);
			bool passwordFlag = CheckPassword(_password);

			return loginFlag && passwordFlag;
		}

		private bool CheckLogin(string login)
		{
			if (!Regex.IsMatch(login, "^[a-zA-Z]+$"))
			{
				Console.WriteLine("Login should consist only of characters of the English alphabet.");
				return false;
			}

			return true;
		}

		private bool CheckPassword(string password)
		{
			if (!Regex.IsMatch(password, @"^[0-9!@#$%^&*()\-_=+{}[\]|\\;:'"",.<>/?]+$"))
			{
				Console.WriteLine("Password should consist only of numbers and special symbols. ");
				return false;
			}
			return true;
		}

		void Congratulation()
		{
			_isMatch = true;
			Console.WriteLine("Registration was successful!");
			Console.WriteLine("Login: {0}", _login);
			Console.WriteLine("Password: {0}", _password);
		}
	}
}
