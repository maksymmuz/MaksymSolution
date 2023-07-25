namespace SerializeAndSend
{
	[Serializable]
	public class User
	{
		public string Username { get; set; }

		public int Age { get; set; }

		public User() { }

		public User(string username, int age)
		{
			Username = username;
			Age = age;
		}
	}
}
