﻿using WorkWithSerialization;
/**
 * Домашнє завдання 8
 * Завдання 2
 * Створіть клас, який підтримує серіалізацію. Виконайте серіалізацію цього об'єкта у форматі XML. 
 * Спочатку використовуйте формат за промовчанням,
 * а потім змініть його таким чином, щоб значення полів збереглися як атрибути елементів XML.
 */

Person person = new("Johnnie Walker", 30, "Manager");

SerializerDeserializer.SerializePerson(person);