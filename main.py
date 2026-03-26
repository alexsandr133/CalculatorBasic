# Импортируем класс CharacterBuilder из модуля character_builder.py
# CharacterBuilder используется для пошагового создания персонажей
from character_builder import CharacterBuilder
# Импортируем класс CharacterDirector из модуля character_builder.py
# CharacterDirector содержит готовые шаблоны для создания персонажей
from character_builder import CharacterDirector
# Импортируем перечисление CharacterClass из модуля character_builder.py
# CharacterClass содержит типы классов персонажей (воин, маг, лучник)
from character_builder import CharacterClass
# Выводим разделительную линию из 50 знаков "="
# print() выводит текст в консоль
# "*50" означает повторить символ "=" 50 раз
print("="*50)
# Выводим заголовок программы
print("СИСТЕМА СОЗДАНИЯ ПЕРСОНАЖЕЙ RPG")
# Выводим еще одну разделительную линию
print("="*50)
# Создаем объект класса CharacterBuilder
# builder будет использоваться для построения персонажей
builder = CharacterBuilder()
# Создаем объект класса CharacterDirector
# Передаем builder в конструктор директора
# Director будет использовать builder для создания персонажей
director = CharacterDirector(builder)
# Выводим пустую строку (\n) и текст о создании воина
# \n создает перенос строки для лучшего форматирования
print("\n1. Создаем воина...")
# Вызываем метод create_warrior() у директора
# Передаем имя "Конан" для персонажа
# Метод возвращает готового объекта Character
# Результат сохраняем в переменную warrior
warrior = director.create_warrior("Конан")
# Выводим информацию о созданном воине в консоль
# Вызывается метод __str__() у объекта warrior
print(warrior)
# Выводим пустую строку и текст о создании мага
print("\n2. Создаем мага...")
# Вызываем метод create_mage() у директора
# Передаем имя "Гэндальф" для персонажа
# Результат сохраняем в переменную mage
mage = director.create_mage("Гэндальф")
# Выводим информацию о созданном маге в консоль
print(mage)
# Выводим пустую строку и текст о создании лучника
print("\n3. Создаем лучника...")
# Вызываем метод create_archer() у директора
# Передаем имя "Леголас" для персонажа
# Результат сохраняем в переменную archer
archer = director.create_archer("Леголас")
# Выводим информацию о созданном лучнике в консоль
print(archer)
# Выводим пустую строку и текст о сохранении в JSON
print("\n4. Сохраняем персонажей в JSON...")
# Вызываем метод to_json() у объекта warrior
# Метод сохраняет данные персонажа в файл "warrior.json"
warrior.to_json("warrior.json")
# Вызываем метод to_json() у объекта mage
# Метод сохраняет данные персонажа в файл "mage.json"
mage.to_json("mage.json")
# Вызываем метод to_json() у объекта archer
# Метод сохраняет данные персонажа в файл "archer.json"
archer.to_json("archer.json")
# Выводим пустую строку и текст о загрузке из JSON
print("\n5. Загружаем из JSON...")
# Импортируем класс Character из модуля character_builder.py
# Импортируем здесь потому что класс нужен только для загрузки
from character_builder import Character
# Вызываем класс-метод from_json() у класса Character
# Метод читает данные из файла "warrior.json"
# Создает и возвращает новый объект Character
# Результат сохраняем в переменную loaded_warrior
loaded_warrior = Character.from_json("warrior.json")
# Выводим информацию о загруженном персонаже
# f-string позволяет вставлять переменные в строку через {}
# loaded_warrior.name - имя персонажа
# loaded_warrior.level - уровень персонажа
print(f"Загружен: {loaded_warrior.name}, уровень {loaded_warrior.level}")
# Выводим пустую строку и сообщение об успешном завершении
