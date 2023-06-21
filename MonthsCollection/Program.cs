using MonthsCollection;

/*
 * Домашнє завдання 1
 * Завдання 2
 * Створіть колекцію, в якій зберігалися б найменування 12 місяців,
 * порядковий номер і кількість днів у відповідному місяці.
 * Реалізуйте можливість вибору місяців як за порядковим номером,
 * так і кількістю днів у місяці, 
 * при цьому результатом може бути не тільки один місяць.
 */

var months = new Months();

var months31Days = months.MonthsArray.Where(m => m.NumberOfDays == 31);
var monthsOfSummer = months.MonthsArray.Where(m => m.MonthNumber > 5 && m.MonthNumber < 9);

foreach (Month item in months)
{
	Console.WriteLine(item.MonthName);
}

Console.WriteLine(new string('*', 20));

Console.WriteLine(months[0].MonthName);
Console.WriteLine(months[1].MonthName);
Console.WriteLine(months[3].MonthName);
Console.WriteLine(months[12].MonthName);
Console.WriteLine(months[13].MonthName);


Console.WriteLine();
