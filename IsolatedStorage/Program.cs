/**
 * Завдання 4
 * Створіть програму WPF Application, яка дозволяє користувачам зберігати дані в ізольованому сховищі.
*/

using System.IO.IsolatedStorage;

IsolatedStorageFile isolatedStorage = IsolatedStorageFile.GetUserStoreForAssembly();
IsolatedStorageFileStream storageFileStream = new IsolatedStorageFileStream("UserSensitivityInfo.txt", FileMode.Create, isolatedStorage);
StreamWriter writer = new StreamWriter(storageFileStream);

Console.WriteLine("Enter your information to place it in the Isolated storage file: ");
var userInfo = Console.ReadLine();
writer.WriteLine(userInfo);

Console.WriteLine("Your information has been successfully saved.");

writer.Close();
