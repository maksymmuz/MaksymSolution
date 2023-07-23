using LargeObjectCleaningPattern;

/**
 * Домашнє завдання 9
 * Завдання 4
 * Створіть свій клас, об'єкти якого займатимуть багато місця в пам'яті (наприклад, у коді класу буде великий масив)
 * і реалізуйте для цього класу формалізований шаблон очищення.
 */

using (var largeObject = new LargeObject())
{
	for (int i = 0; i < 10; i++)
		largeObject.Dispose(); // Dispose() method will called only once due to the pattern implemented in the class

}// The largeObject object will be automatically cleaned up after the using scope ends