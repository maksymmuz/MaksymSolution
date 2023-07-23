using WorkWithGarbageCollector;
/**
 * Домашнє завдання 9
 * Завдання 2
 * Створіть клас, який дозволить виконувати моніторинг ресурсів, що використовуються програмою.
 * Використовуйте його з метою спостереження за роботою програми, а саме: 
 * користувач може вказати прийнятні рівні споживання ресурсів (пам'яті), 
 * а методи класу дозволять видати попередження, коли кількість ресурсів, 
 * що реально використовуються, наблизитися до максимально допустимого рівня.
 */

// Acceptable level of memory consumption in bytes (10 MB)
long acceptableMemoryUsageBytes = 10 * 1024 * 1024;

var resourceMonitor = new ResourceMonitor(acceptableMemoryUsageBytes);

for (int i = 0; i < 10; i++)
{
	ResourceMonitor.AuxiliaryMethod();
	resourceMonitor.CheckMemoryUsage();
}