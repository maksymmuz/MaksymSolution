using WorkWithCollections;

/**
 *Завдання 6
 *Створіть метод, який як аргумент приймає масив цілих чисел і повертає колекцію квадратів усіх непарних чисел масиву. 
 *Для формування колекції використовуйте оператор yield.
 * */

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach (var square in arr.SquaresOfOddNumbers())
	Console.WriteLine(square);