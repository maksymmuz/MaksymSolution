using System.Text.RegularExpressions;

namespace GettingInfoFromWebPage
{
	internal class ToolsForWebPage
	{
		public static async Task<string> GetWebPageSource(string url)
		{
			string htmlContent;
			using (var client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync(url);
				htmlContent = await response.Content.ReadAsStringAsync();
			}
			return htmlContent;
		}

		public static void GetLinks(string filePathSource, string filePathTarget)
		{
			try
			{
				string fileContent = File.ReadAllText(filePathSource);

				string linkPattern = @"<a\s+(?:[^>]*?\s+)?href=([""'])(.*?)\1";
				MatchCollection matches = Regex.Matches(fileContent, linkPattern, RegexOptions.IgnoreCase);

				Utilities.WriteToFile(filePathTarget, "\nLinks:", append: true);
				foreach (Match match in matches)
				{
					Utilities.WriteToFile(filePathTarget, match.Value, append: true);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred in the GetLinks method: " + ex.Message);
			}
		}

		public static void GetPhoneNumbers(string filePathSource, string filePathTarget)
		{
			try
			{
				string fileContent = File.ReadAllText(filePathSource);

				var phoneRegexPattern = @"(\+?\d{2}[-.\s]?)?(\(?\d{3}\)?[-.\s]?)?(\d{3}[-.\s]?\d{4})?(\d{3}[-.\s]?\d{2}[-.\s]?\d{2})";
				MatchCollection matches = Regex.Matches(fileContent, phoneRegexPattern);

				Utilities.WriteToFile(filePathTarget, "\n\nTelephone numbers:", append: true);
				foreach (Match match in matches)
				{
					Utilities.WriteToFile(filePathTarget, match.Value, append: true);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred in the GetPhoneNumbers method: " + ex.Message);
			}
		}

		public static void GetEmailAddresses(string filePathSource, string filePathTarget)
		{
			try
			{
				string fileContent = File.ReadAllText(filePathSource);

				var emailRegex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b");
				var matches = emailRegex.Matches(fileContent);

				Utilities.WriteToFile(filePathTarget, "\n\nEmail Addresses:", append: true);
				foreach (Match match in matches)
				{
					Utilities.WriteToFile(filePathTarget, match.Value, append: true);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred in the GetEmailAddresses method: " + ex.Message);
			}
		}
	}
}
