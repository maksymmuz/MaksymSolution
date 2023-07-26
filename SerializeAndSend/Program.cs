using SerializeAndSend;
using System.IO.Compression;
using System.Text;
using System.Text.Json;
/**
 * Домашнє завдання 8
 * Завдання 5 
 * Створіть тип користувача (наприклад, клас) і виконайте серіалізацію об'єкта цього типу,
 * враховуючи той факт, що стан об'єкта необхідно буде передати по мережі.
 */

var user = new User("Johnnie", 30);
string jsonString = JsonSerializer.Serialize(user);

byte[] compressedData;
using (var memoryStream = new MemoryStream())
{
	using var gzipStream = new GZipStream(memoryStream, CompressionMode.Compress);

	byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
	gzipStream.Write(jsonBytes, 0, jsonBytes.Length);

	compressedData = memoryStream.ToArray();
}

// compressedData for sending over the network
