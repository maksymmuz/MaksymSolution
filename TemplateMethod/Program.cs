using TemplateMethod;
/**
 * Домашнє завдання 10
 * Завдання 2
 * Вивчіть опис шаблону Template method (Шаблонний метод). Зверніть увагу на застосування шаблону,
 * а також на склад його учасників і зв'язку відносини між ними. Напишіть невелику програму мовою C#, 
 * що є абстрактною реалізацією даного шаблону.
 */

TemplateClass templateObject_1 = new ConcreteClass_1();
TemplateClass templateObject_2 = new ConcreteClass_2();

templateObject_1.LoadWebPageTemplateMethod();
templateObject_2.LoadWebPageTemplateMethod();