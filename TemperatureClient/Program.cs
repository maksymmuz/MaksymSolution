using System.Globalization;
using System.Reflection;

/**
 * Домашнє завдання 6
 * Завдання 2
 * Створіть власну користувальницьку збірку за прикладом складання CarLibrary з уроку, складання буде використовуватися для роботи з конвертером температури.
 * 
 * Завдання 3
 * Створіть програму, в якій надайте користувачеві доступ до збірки із завдання 2. 
 * Реалізуйте використання методу конвертації значення температури зі шкали Цельсія в шкалу Фаренгейта. 
 * Виконуючи завдання використовуйте лише рефлексію.
 */

Assembly? assembly = null;

try
{
	assembly = Assembly.LoadFrom("C:\\Users\\Maksym_Muzyka\\Desktop\\MaksymSolution\\Temperature\\bin\\Debug\\net6.0\\Temperature.dll");
	Console.WriteLine("Loaded Temperature assembly");
}
catch (FileNotFoundException ex)
{
	Console.WriteLine(ex.Message);
}

Type temperatureConverter = assembly.GetType("Temperature.TemperatureConverter");
ConstructorInfo temperatureConverterConstructor = temperatureConverter.GetConstructor(new Type[] { typeof(decimal) });
dynamic converter = temperatureConverterConstructor.Invoke(new object[] { 12m });

#region Variant 1

Console.WriteLine(converter.ToString());
Console.WriteLine(converter.ToString("F", CultureInfo.CurrentCulture));
#endregion

Console.WriteLine(new string('*', 30));

#region Variant 2 Finding method by specifying matching parameters

MethodInfo ToStringMethod = temperatureConverter
	.GetMethod("ToString", BindingFlags.Public | BindingFlags.Instance, new Type[] { typeof(string), typeof(IFormatProvider) });

var str1 = ToStringMethod.Invoke(converter, new object[] { "F", CultureInfo.CurrentCulture });
var str2 = ToStringMethod.Invoke(converter, new object[] { "K", CultureInfo.CurrentCulture });
Console.WriteLine(str1);
Console.WriteLine(str2);
#endregion