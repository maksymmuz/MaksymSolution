using DeserializeObject;
/**
 * Домашнє завдання 8
 * Завдання 3
 * Створіть нову програму, в якій виконайте десеріалізацію об'єкта з попереднього прикладу. 
 * Відобразіть стан об'єкта на екрані.
 */

var person = Deserializer<Person>.DeserializePerson();

Console.WriteLine("Name: {0};\nAge: {1};\nPosition: {2};\n", person.Name, person.Age, person.Position);