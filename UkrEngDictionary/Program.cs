using System.Text;
using UkrEngDictionary;
/**
 * Домашнє завдання 1
 * Завдання 4 
 * Створіть колекцію, в яку можна записувати два значення одного слова, на кшталт російсько-англо-українського словника
 * І в ній можна для українського слова знайти або лише російське значення, або лише англійське та вивести його на екран. 
 */

Console.OutputEncoding = Encoding.UTF8;

var dictionaryCollection = new DictionaryCollection();

dictionaryCollection.Add("Привіт", new Translation("Hi"));
dictionaryCollection.Add("Світ", new Translation("World"));
dictionaryCollection.Add("Полуниця", new Translation("Палуніца", false));

foreach (var word in dictionaryCollection)
	Console.WriteLine(word);
