using Receipt;
using System.Globalization;
using System.Text;

/**
* Домашнє завдання 4
* Завдання 4
* Створіть текстовий файл-чек на кшталт «Найменування товару – 0.00(ціна)грн.»
* з певною кількістю найменувань товарів та датою здійснення покупки
* Виведіть на екран інформацію з чека у форматі поточної локалі користувача та у форматі локалі en-US.
*/

Console.OutputEncoding = Encoding.UTF8;

CheckProcessing check = new(@"C:\SomePath\Receipt.txt");

check.ToString("C2", CultureInfo.CurrentCulture);
check.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
check.ToString("C2", CultureInfo.CreateSpecificCulture("uk-UA"));
check.ToString("C2", new CultureInfo("en-GB"));
