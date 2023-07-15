using WorkWithAttributes;

/**
 * Домашнє завдання 7
 * Завдання 2
 * Створіть клас і застосуйте до його методів атрибут Obsolete спочатку у формі, що просто виводить попередження,
 * а потім у формі, що перешкоджає компіляції. Продемонструйте роботу атрибута з прикладу виклику даних методів.
 * */

ClassWithObsoleteMethods obsoleteMethods = new();

Console.WriteLine(obsoleteMethods.ObsoleteSum(2, 5));
obsoleteMethods.ObsoletePrint();
obsoleteMethods.Print();