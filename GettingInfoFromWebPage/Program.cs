using GettingInfoFromWebPage;

/**
 * Домашнє завдання 4
 * Завдання 2
 * Напишіть програму, яка дозволила б за вказаною адресою web-сторінки вибирати всі посилання на інші сторінки,
 * номери телефонів, поштові адреси та зберігала отриманий результат у файл.
 * */

string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ForExperiments");
string filePathSource = Path.Combine(directoryPath, "Source.txt");
string filePathTarget = Path.Combine(directoryPath, "Target.txt");

string htmlContent = await ToolsForWebPage.GetWebPageSource("http://web.simmons.edu/~grovesd/comm244/notes/week3/html-test-page.html");
Utilities.WriteToFile(filePathSource, htmlContent);

ToolsForWebPage.GetLinks(filePathSource, filePathTarget);
ToolsForWebPage.GetPhoneNumbers(filePathSource, filePathTarget);
ToolsForWebPage.GetEmailAddresses(filePathSource, filePathTarget);
