/**
 * Домашнє завдання 3
 * Завдання 4
 * Створіть програму WPF Application, яка дозволяє користувачам зберігати дані в ізольованому сховищі.
*/

using System.IO.IsolatedStorage;

IsolatedStorageFile isolatedStorage = IsolatedStorageFile.GetUserStoreForAssembly();
IsolatedStorageFileStream storageFileStream = new("UserSensitivityInfo.txt", FileMode.Create, isolatedStorage);
StreamWriter writer = new(storageFileStream);

Console.WriteLine("Enter your information to place it in the Isolated storage file: ");
var userInfo = Console.ReadLine();
writer.WriteLine(userInfo);

Console.WriteLine("Your information has been successfully saved.");

writer.Close();
