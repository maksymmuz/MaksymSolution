﻿using WorkWithConfigurations;
/**
* Домашнє завдання 5
* Завдання 4
* Використовуючи приклади, розглянуті на уроці, створіть свою програму для адміністратора, 
* яка зберігатиме дані конфігурації у спеціальному файлі або в реєстрі.
* Створіть програму користувача, зовнішнім виглядом якого можна керувати за допомогою адмінпрограми.
*/


Admin admin = new();
admin.CreteConfigFile();

User user = new();
user.Print();